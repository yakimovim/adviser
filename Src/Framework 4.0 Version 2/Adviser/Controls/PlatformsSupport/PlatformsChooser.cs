using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.PlatformsSupport
{
	/// <summary>
	/// Form for choosing platforms for code.
	/// </summary>
	public partial class PlatformsChooser : Form
	{
		private Code m_Code;
		private bool m_IsCodeChecking = false;

		/// <summary>
		/// Code.
		/// </summary>
		public Code Code
		{
			get { return m_Code; }
			set { m_Code = value; }
		}

        /// <summary>
		/// Constructor.
		/// </summary>
		public PlatformsChooser()
		{
			InitializeComponent();
		}

        /// <summary>
		/// Handles form loading.
		/// </summary>
		private void OnFormLoad(object sender, EventArgs e)
		{
			if (Code == null)
				Close();
			FillListOfPlatforms();
			CheckCodePlatforms();
		}

		/// <summary>
		/// Handles platforms selection.
		/// </summary>
		private void OnPlatformCheck(object sender, ItemCheckEventArgs e)
		{
			if (m_IsCodeChecking)
				return;
			if (Code == null)
				return;

			if ((e.CurrentValue == CheckState.Unchecked) && (e.NewValue == CheckState.Checked))
			{
				string platformName = (string)clbPlatforms.Items[e.Index];
                Platform platform = AdviserStorage.Current.Platforms.First(p => p.Name == platformName);
                Code.Platforms.Add(platform);
                AdviserStorage.Current.SaveChanges();
			}
			if ((e.CurrentValue == CheckState.Checked) && (e.NewValue == CheckState.Unchecked))
			{
				string platformName = (string)clbPlatforms.Items[e.Index];
                Platform platform = AdviserStorage.Current.Platforms.First(p => p.Name == platformName);
                Code.Platforms.Remove(platform);
                AdviserStorage.Current.SaveChanges();
            }
		}

        /// <summary>
		/// Fills list of platforms.
		/// </summary>
		private void FillListOfPlatforms()
		{
			clbPlatforms.Items.Clear();
			if (Code != null)
			{
                foreach (Platform platform in AdviserStorage.Current.Platforms)
				{ clbPlatforms.Items.Add(platform.Name, false); }
			}
		}

		/// <summary>
		/// Checks platforms of code.
		/// </summary>
		private void CheckCodePlatforms()
		{
			try
			{
				m_IsCodeChecking = true;
				if (Code != null)
				{
					Platform[] codePlatforms = Code.Platforms.ToArray();
					if (codePlatforms == null)
						return;
					List<string> codePlatformsNames = new List<string>();
					foreach (Platform platform in codePlatforms)
					{ codePlatformsNames.Add(platform.Name); }

					for (int i = 0; i < clbPlatforms.Items.Count; i++)
					{
						if (codePlatformsNames.Contains(clbPlatforms.Items[i].ToString()))
							clbPlatforms.SetItemChecked(i, true);
					}
				}
			}
			finally
			{ m_IsCodeChecking = false; }
		}
	}
}