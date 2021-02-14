using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Repository;
using EdlinSoftware.Adviser.Properties;

namespace EdlinSoftware.Adviser.Controls.LinksSupport
{
	/// <summary>
	/// Form of list of all attachments of topic.
	/// </summary>
	public partial class AttachmentManager : Form
	{
        /// <summary>
		/// Topic.
		/// </summary>
		public Topic Topic { get; set; }

        /// <summary>
		/// Constructor.
		/// </summary>
		public AttachmentManager()
		{
			InitializeComponent();
		}

        /// <summary>
		/// Handles form loading.
		/// </summary>
		private void OnFormLoad(object sender, EventArgs e)
		{
            if (Topic == null)
            { Close(); }
			BindData();
			SetControlsState();
		}

		/// <summary>
		/// Handles adding of link.
		/// </summary>
		private void OnAddLink(object sender, EventArgs e)
		{
			AttachedLink newLink = new AttachedLink();
			LinkProperties frm = new LinkProperties();
			frm.Owner = this;
			frm.Link = newLink;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				Topic.AttachedLinks.Add(newLink);
                AdviserStorage.Current.SaveChanges();
				BindData();
				SetControlsState();
			}
		}

		/// <summary>
		/// Handles adding of file.
		/// </summary>
		private void OnAddFile(object sender, EventArgs e)
		{
            AttachedFile newFile = new AttachedFile 
                { 
                    FileContent = new FileContent()
                };
			FileProperties frm = new FileProperties();
			frm.Owner = this;
			frm.File = newFile;
			frm.CreateMode = true;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				Topic.AttachedFiles.Add(newFile);
                AdviserStorage.Current.SaveChanges();
				BindData();
				SetControlsState();
			}
		}

		/// <summary>
		/// Handles deleting of item.
		/// </summary>
		private void OnDelete(object sender, EventArgs e)
		{
			if (lvAttachments.SelectedIndices.Count > 0)
			{
				int selIndex = lvAttachments.SelectedIndices[0];
				ListViewItem item = lvAttachments.Items[selIndex];
				object attachedObject = item.Tag;
				if (attachedObject != null)
				{
					if (attachedObject is AttachedLink)
					{
                        if (MessageBox.Show(this, Resources.DeleteLinkConfirmation, Resources.Confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                            return;

                        Topic.AttachedLinks.Remove((AttachedLink)attachedObject);
                        AdviserStorage.Current.AttachedLinks.Remove((AttachedLink)attachedObject); 
                    }
					if (attachedObject is AttachedFile)
					{
                        if (MessageBox.Show(this, Resources.DeleteFileConfirmation, Resources.Confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                            return;

                        Topic.AttachedFiles.Remove((AttachedFile)attachedObject);
                        AdviserStorage.Current.AttachedFiles.Remove((AttachedFile)attachedObject); 
                    }
                    AdviserStorage.Current.SaveChanges();
				}
				lvAttachments.Items.RemoveAt(selIndex);
			}
		}

		/// <summary>
		/// Handles showing of properties.
		/// </summary>
		private void OnProperties(object sender, EventArgs e)
		{
			if (lvAttachments.SelectedIndices.Count > 0)
			{
				int selIndex = lvAttachments.SelectedIndices[0];
				ListViewItem item = lvAttachments.Items[selIndex];

				if (item.Tag is AttachedLink)
				{
					AttachedLink link = (AttachedLink) item.Tag;

					LinkProperties frm = new LinkProperties();
					frm.Owner = this;
					frm.Link = link;
					if (frm.ShowDialog() == DialogResult.OK)
					{
						item.SubItems[0].Text = link.Url;
						item.SubItems[1].Text = link.Comment;
                        AdviserStorage.Current.SaveChanges();
					}
					return;
				}

				if (item.Tag is AttachedFile)
				{
					AttachedFile file = (AttachedFile)item.Tag;

					FileProperties frm = new FileProperties();
					frm.Owner = this;
					frm.File = file;
					if (frm.ShowDialog() == DialogResult.OK)
					{
						item.SubItems[0].Text = file.FileName;
						item.SubItems[1].Text = file.Comment;
                        AdviserStorage.Current.SaveChanges();
					}
					return;
				}
			}
		}

		/// <summary>
		/// Handles changing of selected attachment.
		/// </summary>
		private void OnSelectedAttachmentChanged(object sender, EventArgs e)
		{
			SetControlsState();
		}

		/// <summary>
		/// Handles activation of one of items.
		/// </summary>
		private void OnItemActivate(object sender, EventArgs e)
		{
			if (lvAttachments.SelectedItems.Count > 0)
			{
				ListViewItem item = lvAttachments.SelectedItems[0];

				if (item.Tag is AttachedLink)
				{
					AttachedLink link = (AttachedLink)item.Tag;

					Process.Start(link.Url);

					return;
				}

				if (item.Tag is AttachedFile)
				{
					AttachedFile file = (AttachedFile)item.Tag;

                    var frm = new FileOperations();
                    frm.Owner = this;
                    frm.File = file;
                    frm.ShowDialog();

					return;
				}
			}
		}

        /// <summary>
		/// Binds data with controls.
		/// </summary>
		private void BindData()
		{
			lvAttachments.Items.Clear();

			foreach (AttachedLink link in Topic.AttachedLinks)
			{
				ListViewItem item = new ListViewItem();
				item.Text = link.Url;
				item.SubItems.Add(link.Comment);
				item.Tag = link;
				lvAttachments.Items.Add(item);
			}

			foreach (AttachedFile file in Topic.AttachedFiles)
			{
				ListViewItem item = new ListViewItem();
				item.Text = file.FileName;
				item.SubItems.Add(file.Comment);
				item.Tag = file;
				lvAttachments.Items.Add(item);
			}
		}

		/// <summary>
		/// Sets controls states according to data.
		/// </summary>
		private void SetControlsState()
		{
			bAddLink.Enabled = true;
			bAddFile.Enabled = true;
			bRemove.Enabled = (lvAttachments.SelectedIndices.Count > 0);
			bProperties.Enabled = (lvAttachments.SelectedIndices.Count > 0);
		}

        /// <summary>
        /// Handles presses of keys.
        /// </summary>
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    OnDelete(this, e);
                    break;
                case Keys.Enter:
                    if (e.Alt)
                    {
                        OnProperties(this, e);
                    }
                    break;

            }
        }
    }
}