using System;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Properties;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.PlatformsSupport
{
	/// <summary>
	/// Form for management of design platforms.
	/// </summary>
	public partial class PlatformsManager : Form
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public PlatformsManager()
		{
			InitializeComponent();
		}

        /// <summary>
		/// Handles changing of list view size.
		/// </summary>
		private void OnListViewSizeChanged(object sender, EventArgs e)
		{
			chPlatforms.Width = lvPlatforms.ClientRectangle.Width - 5;
		}

		/// <summary>
		/// Handles form loading.
		/// </summary>
		private void OnFormLoad(object sender, EventArgs e)
		{
			FillPlatformsList();

			SetControlsState();
		}

		/// <summary>
		/// Handles changing of selected platform.
		/// </summary>
		private void OnSelectedPlatformChanged(object sender, EventArgs e)
		{
			SetControlsState();
		}

		/// <summary>
		/// Handles creation of new platform.
		/// </summary>
		private void OnCreateNewPlatform(object sender, EventArgs e)
		{
            ShowPlatformPropertiesForm(new Platform() { Name = "New platform" }, platform => AdviserStorage.Current.Platforms.Add(platform));
		}

		/// <summary>
		/// Handles platform deleting.
		/// </summary>
		private void OnDeletePlatform(object sender, EventArgs e)
		{
			if (lvPlatforms.SelectedItems.Count > 0)
			{
                if (MessageBox.Show(this, Resources.DeletePlatformConfirmation, Resources.Confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                { return; }
				
                Platform platform = (Platform)lvPlatforms.SelectedItems[0].Tag;
                
                AdviserStorage.Current.Platforms.Remove(platform);
                
                SaveChangesAndRefresh();
			}
		}

		/// <summary>
		/// Handles changing of platform properties.
		/// </summary>
		private void OnPlatformProperties(object sender, EventArgs e)
		{
			if (lvPlatforms.SelectedItems.Count > 0)
			{
                ShowPlatformPropertiesForm((Platform)lvPlatforms.SelectedItems[0].Tag);
			}
		}

        /// <summary>
		/// Fills list of platforms.
		/// </summary>
		private void FillPlatformsList()
		{
			lvPlatforms.Items.Clear();
            foreach (Platform platform in AdviserStorage.Current.Platforms)
			{
				ListViewItem item = new ListViewItem();
				item.Text = platform.Name;
				item.Tag = platform;
				lvPlatforms.Items.Add(item);
			}
		}

		/// <summary>
		/// Sets state of controls.
		/// </summary>
		private void SetControlsState()
		{
			bNewPlatform.Enabled = true;

			if (lvPlatforms.SelectedItems.Count == 0)
			{
				bDeletePlatform.Enabled = false;
				bPlatformProperties.Enabled = false;
			}
			else
			{
				Platform selPlatform = (Platform)lvPlatforms.SelectedItems[0].Tag;
				bDeletePlatform.Enabled = true;
				bPlatformProperties.Enabled = true;
			}
		}

        /// <summary>
        /// Shows platform properties form and saves changes on 'Ok'.
        /// </summary>
        private void ShowPlatformPropertiesForm(Platform platform, Action<Platform> beforeSave = null)
        {
            PlatformProperties frm = new PlatformProperties();
            frm.Owner = this;
            frm.Platform = platform;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (beforeSave != null)
                { beforeSave(platform); }

                SaveChangesAndRefresh();
            }
        }

        /// <summary>
        /// Saves changes and refreshes list of languages.
        /// </summary>
        private void SaveChangesAndRefresh()
        {
            AdviserStorage.Current.SaveChanges();
            FillPlatformsList();
            SetControlsState();
        }

        /// <summary>
        /// Handles presses of keys.
        /// </summary>
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    OnCreateNewPlatform(this, e);
                    break;
                case Keys.Delete:
                    OnDeletePlatform(this, e);
                    break;
                case Keys.Enter:
                    if (e.Alt)
                    {
                        OnPlatformProperties(this, e);
                    }
                    break;

            }
        }
    }
}