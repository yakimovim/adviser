using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.LinksSupport
{
	/// <summary>
	/// Form for attached file properties.
	/// </summary>
	public partial class FileProperties : Form
	{
        /// <summary>
		/// Attached file.
		/// </summary>
		public AttachedFile File { get; set; }

		/// <summary>
		/// Is in creation mode.
		/// </summary>
		public bool CreateMode { get; set; }

        /// <summary>
		/// Constructor.
		/// </summary>
		public FileProperties()
		{
			InitializeComponent();
		}

        /// <summary>
		/// Handles form loading.
		/// </summary>
		private void OnFormLoad(object sender, EventArgs e)
		{
			if (File == null)
				Close();

			bBrowse.Visible = CreateMode;
			BindData();
		}

		/// <summary>
		/// Handles Ok click.
		/// </summary>
		private void OnOk(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
			{
				if (File != null)
				{
					File.FileName = tbFileName.Text;
					File.Comment = tbComment.Text;
				}
				DialogResult = DialogResult.OK;
			}
		}

		/// <summary>
		/// Handles file name validation.
		/// </summary>
		private void OnFileNameValidating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(tbFileName.Text))
			{
				errorProvider.SetError(tbFileName, toolTip.GetToolTip(tbFileName));
				e.Cancel = true;
			}
			else
			{
				e.Cancel = false;
				errorProvider.SetError(tbFileName, null);
			}
		}

		/// <summary>
		/// Handles file content validation.
		/// </summary>
		private void OnFileContentValidating(object sender, CancelEventArgs e)
		{
			if (!CreateMode)
			{
				e.Cancel = false;
				errorProvider.SetError(bBrowse, null);
				return;
			}

			if (File.FileContent.Content == null)
			{
				errorProvider.SetError(bBrowse, toolTip.GetToolTip(bBrowse));
				e.Cancel = true;
			}
			else
			{
				e.Cancel = false;
				errorProvider.SetError(bBrowse, null);
			}
		}

		/// <summary>
		/// Handles attaching of file.
		/// </summary>
		private void OnAttachFile(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
				{
					byte[] arr = new byte[fs.Length];
					fs.Read(arr, 0, arr.Length);
					File.FileContent.Content = arr;
				}
				tbFileName.Text = Path.GetFileName(openFileDialog.FileName);
			}
		}

        /// <summary>
		/// Binds data with controls.
		/// </summary>
		private void BindData()
		{
			if (File != null)
			{
				tbFileName.Text = File.FileName;
				tbComment.Text = File.Comment;
			}
		}
	}
}