using System;
using System.Linq;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Properties;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.LanguagesSupport
{
	/// <summary>
	/// Form for languages management.
	/// </summary>
	public partial class LanguagesManager : Form
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public LanguagesManager()
		{
			InitializeComponent();
		}

        /// <summary>
		/// Handles changing of list view size.
		/// </summary>
		private void OnListViewSizeChanged(object sender, EventArgs e)
		{
			chLanguage.Width = lvLanguages.ClientRectangle.Width - 5;
		}

		/// <summary>
		/// Handles form loading.
		/// </summary>
		private void OnFormLoad(object sender, EventArgs e)
		{
			FillLanguagesList();

			SetControlsState();
		}

		/// <summary>
		/// Handles changing of selected language.
		/// </summary>
		private void OnSelectedLanguageChanged(object sender, EventArgs e)
		{
			SetControlsState();
		}

		/// <summary>
		/// Handles creation of new language.
		/// </summary>
		private void OnCreateNewLanguage(object sender, EventArgs e)
		{
            ShowLanguagePropertiesForm(new Language{Name = "New language"}, lang => AdviserStorage.Current.Languages.Add(lang));
		}

		/// <summary>
		/// Handles language deleting.
		/// </summary>
		private void OnDeleteLanguage(object sender, EventArgs e)
		{
			if (lvLanguages.SelectedItems.Count > 0)
			{
                Language lang = (Language)lvLanguages.SelectedItems[0].Tag;
                if (lang == Language.Unknown)
                { return; }

                if (MessageBox.Show(this, Resources.DeleteLanguageConfirmation, Resources.Confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
					return;

                foreach (var code in AdviserStorage.Current.Codes.Where(c => c.LanguageId == lang.Id))
                {
                    code.Language = Language.Unknown;
                }

                AdviserStorage.Current.Languages.Remove(lang);

                SaveChangesAndRefresh();
            }
		}

		/// <summary>
		/// Handles changing of language properties.
		/// </summary>
		private void OnLanguageProperties(object sender, EventArgs e)
		{
			if (lvLanguages.SelectedItems.Count > 0)
			{
                ShowLanguagePropertiesForm((Language)lvLanguages.SelectedItems[0].Tag);
			}
		}

        /// <summary>
		/// Fills list of languages.
		/// </summary>
		private void FillLanguagesList()
		{
			lvLanguages.Items.Clear();
            foreach (Language lang in AdviserStorage.Current.Languages)
			{
                lvLanguages.Items.Add(new ListViewItem { Text = lang.Name, Tag = lang });
			}
		}

		/// <summary>
		/// Sets state of controls.
		/// </summary>
		private void SetControlsState()
		{
			bNewLanguage.Enabled = true;

			if (lvLanguages.SelectedItems.Count == 0)
			{
				bDeleteLanguage.Enabled = false;
				bLanguageProperties.Enabled = false;
			}
			else
			{
				Language selLang = (Language)lvLanguages.SelectedItems[0].Tag;
				if (selLang == Language.Unknown)
				{
					bDeleteLanguage.Enabled = false;
					bLanguageProperties.Enabled = false;
				}
				else
				{
					bDeleteLanguage.Enabled = true;
					bLanguageProperties.Enabled = true;
				}
			}
		}

        /// <summary>
        /// Shows languange properties form and saves changes on 'Ok'.
        /// </summary>
        private void ShowLanguagePropertiesForm(Language lang, Action<Language> beforeSave = null)
        {
            LanguageProperties frm = new LanguageProperties();
            frm.Owner = this;
            frm.Language = lang;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (beforeSave != null)
                { beforeSave(lang); }

                SaveChangesAndRefresh();
            }
        }

        /// <summary>
        /// Saves changes and refreshes list of languages.
        /// </summary>
        private void SaveChangesAndRefresh()
        {
            AdviserStorage.Current.SaveChanges();
            Language.RaiseLanguagesListChanged();
            FillLanguagesList();
            SetControlsState();
        }

        /// <summary>
        /// Handles presses of keys.
        /// </summary>
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Insert:
                    OnCreateNewLanguage(this, e);
                    break;
                case Keys.Delete:
                    OnDeleteLanguage(this, e);
                    break;
                case Keys.Enter:
                    if (e.Alt)
                    {
                        OnLanguageProperties(this, e);
                    }
                    break;

            }
        }
	}
}