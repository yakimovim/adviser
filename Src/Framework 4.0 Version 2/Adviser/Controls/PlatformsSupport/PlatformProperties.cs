using System;
using System.ComponentModel;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Properties;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.PlatformsSupport
{
	/// <summary>
	/// Form for properties of platform.
	/// </summary>
	public partial class PlatformProperties : Form
	{
        /// <summary>
		/// Design platform.
		/// </summary>
		public Platform Platform { get; set; }

        /// <summary>
		/// Constructor.
		/// </summary>
		public PlatformProperties()
		{
			InitializeComponent();
		}

        /// <summary>
		/// Handles form loading.
		/// </summary>
		private void OnFormLoad(object sender, EventArgs e)
		{
            if (Platform == null)
            { Close(); }

			BindData();
		}

		/// <summary>
		/// Handles Ok click.
		/// </summary>
		private void OnOk(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
			{
				if (Platform != null)
				{
					if (Platform.Name != tbPlatformName.Text)
					{
						try
						{
							Platform.Name = tbPlatformName.Text;
						}
						catch (Exception ex)
						{ MessageBox.Show(this, ex.Message, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error); }
					}
				}
				DialogResult = DialogResult.OK;
			}
		}

		/// <summary>
		/// Handles platform name validation.
		/// </summary>
		private void OnPlatformNameValidating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(tbPlatformName.Text))
			{
				errorProvider.SetError(tbPlatformName, toolTip.GetToolTip(tbPlatformName));
				e.Cancel = true;
			}
			else
			{
				e.Cancel = false;
				errorProvider.SetError(tbPlatformName, null);
			}
		}

        /// <summary>
		/// Binds data with controls.
		/// </summary>
		private void BindData()
		{
			if (Platform != null)
			{
				tbPlatformName.Text = Platform.Name;
			}
		}
	}
}