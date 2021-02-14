using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Controls.LinksSupport;
using EdlinSoftware.Adviser.Controls.PlatformsSupport;
using EdlinSoftware.Adviser.Properties;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.CodesNavigator
{
    public partial class CodesNavigator : UserControl
    {
        private Topic m_Topic;
        private List<Code> m_TopicCodes;
        private Code m_Code;

        public event EventHandler CodeChanged;

        /// <summary>
        /// Topic which codes will be navigated.
        /// </summary>
        public Topic Topic
        {
            get { return m_Topic; }
            set
            {
                m_Topic = value;
                m_TopicCodes = m_Topic == null ? null : m_Topic.Codes.ToList();
                BindControls();
            }
        }

        /// <summary>
        /// Current code.
        /// </summary>
        public Code Code
        {
            get { return m_Code; }
            protected set
            {
                if (m_Code != null)
                {
                    AdviserStorage.Current.SaveChanges();
                }
                m_Code = value;
                OnCodeChanged();
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public CodesNavigator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Binds controls with data.
        /// </summary>
        private void BindControls()
        {
            if (Topic == null)
            { Code = null; }
            else if (m_TopicCodes.Count == 0)
            { Code = null; }
            else
            { Code = m_TopicCodes[0]; }

            FillLanguagesList();

            SetControlsState();
        }

        /// <summary>
        /// Устанавливает состояние элементов управления.
        /// </summary>
        private void SetControlsState()
        {
            if (Topic == null)
            {
                cbLanguages.Enabled = false;
                lCount.Text = String.Format(Resources.CodeCount, 0, 0);
                bFirst.Enabled = false;
                bPrev.Enabled = false;
                bNext.Enabled = false;
                bLast.Enabled = false;
                bDelete.Enabled = false;
                bNew.Enabled = false;
                bPlatforms.Enabled = false;
                bLinks.Enabled = false;
                bLinks.ForeColor = SystemColors.ControlText;
                toolTip.SetToolTip(bPlatforms, bPlatforms.Text);
            }
            else
            {
                bNew.Enabled = true;
                bLinks.Enabled = true;
                if ((Topic.AttachedFiles.Count + Topic.AttachedLinks.Count) > 0)
                { bLinks.ForeColor = Color.Red; }
                else
                { bLinks.ForeColor = SystemColors.ControlText; }

                if (m_TopicCodes.Count == 0)
                {
                    cbLanguages.Enabled = false;
                    lCount.Text = String.Format(Resources.CodeCount, 0, 0);
                    bFirst.Enabled = false;
                    bPrev.Enabled = false;
                    bNext.Enabled = false;
                    bLast.Enabled = false;
                    bDelete.Enabled = false;
                    bPlatforms.Enabled = false;
                    toolTip.SetToolTip(bPlatforms, bPlatforms.Text);
                }
                else
                {
                    cbLanguages.Enabled = true;
                    if (Code != null)
                    {
                        if (!AdviserStorage.Current.Languages.Select(l => l.Id).Contains(Code.Language.Id))
                            Code.Language = Language.Unknown;
                        cbLanguages.SelectedItem = Code.Language.Name;
                        lCount.Text = String.Format(Resources.CodeCount, m_TopicCodes.IndexOf(Code) + 1, m_TopicCodes.Count);
                    }
                    else
                    { lCount.Text = String.Format(Resources.CodeCount, 0, Topic.Codes.Count); }
                    bFirst.Enabled = (m_TopicCodes.IndexOf(Code) > 0);
                    bPrev.Enabled = (m_TopicCodes.IndexOf(Code) > 0);
                    bNext.Enabled = (m_TopicCodes.IndexOf(Code) < (m_TopicCodes.Count - 1));
                    bLast.Enabled = (m_TopicCodes.IndexOf(Code) < (m_TopicCodes.Count - 1));
                    bDelete.Enabled = true;
                    bPlatforms.Enabled = true;
                    if (Code != null)
                    {
                        StringBuilder sb = new StringBuilder();
                        Platform[] codePlatforms = GetCodePlatforms();
                        if (codePlatforms != null)
                        {
                            foreach (Platform platform in codePlatforms)
                            {
                                if (sb.Length > 0)
                                    sb.Append(Environment.NewLine);
                                sb.Append(platform.Name);
                            }
                        }
                        if (sb.Length == 0)
                            sb.Append(bPlatforms.Text);
                        toolTip.SetToolTip(bPlatforms, sb.ToString());
                    }
                    else
                    { toolTip.SetToolTip(bPlatforms, bPlatforms.Text); }
                }
            }
        }

        /// <summary>
        /// Raises CodeChanged event.
        /// </summary>
        protected virtual void OnCodeChanged()
        {
            if (CodeChanged != null)
                CodeChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fills list of languages.
        /// </summary>
        private void FillLanguagesList()
        {
            cbLanguages.Items.Clear();
            if (Topic != null)
            {
                foreach (Language lang in AdviserStorage.Current.Languages)
                { cbLanguages.Items.Add(lang.Name); }
                Language.LanguagesListChanged -= new EventHandler(LanguagesChanged);
                Language.LanguagesListChanged += new EventHandler(LanguagesChanged);
                if (Code != null)
                    cbLanguages.SelectedItem = Code.Language.Name;
            }
        }

        /// <summary>
        /// Returns code platforms.
        /// </summary>
        /// <returns>Code platforms.</returns>
        private Platform[] GetCodePlatforms()
        {
            if (Code == null)
                return null;

            return Code.Platforms.ToArray();
        }

        /// <summary>
        /// Handles changing of the list of languages.
        /// </summary>
        public void LanguagesChanged(object sender, EventArgs e)
        {
            FillLanguagesList();
            SetControlsState();
        }

        /// <summary>
        /// Goes to the first code.
        /// </summary>
        private void OnMoveToFirst(object sender, EventArgs e)
        {
            Debug.Assert(Topic != null);
            Debug.Assert(Topic.Codes.Count != 0);
            Code = Topic.Codes.First();
            SetControlsState();
        }

        /// <summary>
        /// Goes to the previous code.
        /// </summary>
        private void OnMoveToPrev(object sender, EventArgs e)
        {
            Debug.Assert(Topic != null);
            Debug.Assert(m_TopicCodes.Count != 0);
            Debug.Assert(Code != null);
            int pos = m_TopicCodes.IndexOf(Code);
            Debug.Assert(pos > 0);
            Code = m_TopicCodes[pos - 1];
            SetControlsState();
        }

        /// <summary>
        /// Goes to the next code.
        /// </summary>
        private void OnMoveToNext(object sender, EventArgs e)
        {
            Debug.Assert(Topic != null);
            Debug.Assert(m_TopicCodes.Count != 0);
            Debug.Assert(Code != null);
            int pos = m_TopicCodes.IndexOf(Code);
            Debug.Assert(pos < (m_TopicCodes.Count - 1));
            Code = m_TopicCodes[pos + 1];
            SetControlsState();
        }

        /// <summary>
        /// Goes to the first code.
        /// </summary>
        private void OnMoveToLast(object sender, EventArgs e)
        {
            Debug.Assert(Topic != null);
            Debug.Assert(m_TopicCodes.Count != 0);
            Code = m_TopicCodes.Last();
            SetControlsState();
        }

        /// <summary>
        /// Creates new code.
        /// </summary>
        private void OnCreateNewCode(object sender, EventArgs e)
        {
            Debug.Assert(Topic != null);
            Code newCode = new Code
            {
                Language = Language.Unknown,
                Text = new Text { RtfText = string.Empty, PlainText = string.Empty }
            };
            m_TopicCodes.Add(newCode);
            Topic.Codes.Add(newCode);
            AdviserStorage.Current.SaveChanges();
            Code = newCode;
            SetControlsState();
        }

        /// <summary>
        /// Deletes selected code.
        /// </summary>
        private void OnDeleteCode(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resources.DeleteCodeConfirmation, Resources.Confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            Debug.Assert(Topic != null);
            Debug.Assert(Code != null);

            int pos = m_TopicCodes.IndexOf(Code);
            m_TopicCodes.RemoveAt(pos);
            Topic.Codes.Remove(Code);
            AdviserStorage.Current.Codes.Remove(Code);
            AdviserStorage.Current.SaveChanges();

            if (m_TopicCodes.Count == 0)
            { Code = null; }
            else if (pos > m_TopicCodes.Count)
            { Code = m_TopicCodes[pos]; }
            else
            { Code = m_TopicCodes[m_TopicCodes.Count - 1]; }

            SetControlsState();
        }

        /// <summary>
        /// Handles language changing.
        /// </summary>
        private void OnLanguageChange(object sender, EventArgs e)
        {
            if ((Topic == null) || (Code == null))
                return;
            string langName = (string)cbLanguages.SelectedItem;
            Language lang = AdviserStorage.Current.Languages.FirstOrDefault(l => l.Name == langName);
            if (lang != null)
            {
                Code.Language = lang;
                AdviserStorage.Current.SaveChanges();
            }
        }

        /// <summary>
        /// Shows code platforms.
        /// </summary>
        private void OnShowPlatforms(object sender, EventArgs e)
        {
            if (Code != null)
            {
                PlatformsChooser frm = new PlatformsChooser();
                frm.Owner = this.ParentForm;
                frm.Code = Code;
                frm.ShowDialog();
                SetControlsState();
            }
        }

        /// <summary>
        /// Shows attached links and files.
        /// </summary>
        private void OnShowLinks(object sender, EventArgs e)
        {
            if (Topic != null)
            {
                AttachmentManager frm = new AttachmentManager();
                frm.Owner = this.ParentForm;
                frm.Topic = Topic;
                frm.ShowDialog();
                SetControlsState();
            }
        }
    }
}
