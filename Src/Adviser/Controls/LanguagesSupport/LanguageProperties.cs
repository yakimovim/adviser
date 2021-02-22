using System;
using System.ComponentModel;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Properties;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.LanguagesSupport
{
	public partial class LanguageProperties : Form
	{
        /// <summary>
		/// Programming language.
		/// </summary>
		public Language Language { get; set; }

        /// <summary>
		/// Constructor.
		/// </summary>
		public LanguageProperties()
		{
			InitializeComponent();
		}

        /// <summary>
		/// Handles form loading.
		/// </summary>
		private void OnFormLoad(object sender, EventArgs e)
		{
            if (Language == null)
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
				if (Language != null)
				{
					if (Language.Name != tbLanguageName.Text)
					{
						try
						{
							Language.Name = tbLanguageName.Text;
						}
						catch (Exception ex)
						{ MessageBox.Show(this, ex.Message, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error); }
					}
				}
				DialogResult = DialogResult.OK;
			}
		}

		/// <summary>
		/// Handles language name validation.
		/// </summary>
		private void OnLanguageNameValidating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(tbLanguageName.Text))
			{
				errorProvider.SetError(tbLanguageName, toolTip.GetToolTip(tbLanguageName));
				e.Cancel = true;
			}
			else
			{
				e.Cancel = false;
				errorProvider.SetError(tbLanguageName, null);
			}
		}

        /// <summary>
		/// Binds data with controls.
		/// </summary>
		private void BindData()
		{
			if (Language != null)
			{
				tbLanguageName.Text = Language.Name;
			}
		}
	}
}