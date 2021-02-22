using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Controls.LanguagesSupport;
using EdlinSoftware.Adviser.Controls.PlatformsSupport;
using EdlinSoftware.Adviser.Properties;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser
{
    public partial class AdviserMainForm : Form
    {
        private readonly History _history = new History();
        private string m_FormCaption;

        /// <summary>
        /// Constructor.
        /// </summary>
        public AdviserMainForm()
        {
            InitializeComponent();

            topicView.TopicChanged += HistoryManagement;

            this.StartPosition = FormStartPosition.Manual;

            this.Location = Settings.Default.MainFormLocation;
            this.Size = Settings.Default.MainFormSize;
            this.WindowState = Settings.Default.MainFormWindowState;

            this.splitContainerSearch.SplitterDistance = Settings.Default.SearchAreaHeight;
            this.splitContainerSearch.Panel2Collapsed = true;

            if (this.splitContainerSearch.SplitterDistance >= (7 * this.Height / 8))
            {
                this.splitContainerSearch.SplitterDistance = (2 * this.Height / 3);
            }
        }

        /// <summary>
        /// Handles form loading.
        /// </summary>
        private void OnAdviserFormLoad(object sender, EventArgs e)
        {
            m_FormCaption = this.Text;

            m_FormCaption += GetVersion();

            if (!this.DesignMode)
            {
                OnSelectedTopicChanged(this, EventArgs.Empty);
                trayIcon.Visible = true;
            }
        }

        private string GetVersion()
        {
            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;

            return string.Format(" [v{0}.{1}]", assemblyVersion.Major, assemblyVersion.Minor);
        }

        /// <summary>
        /// Handles changing of selected topic.
        /// </summary>
        private void OnSelectedTopicChanged(object sender, EventArgs e)
        {
            topicView.Topic = topicsTree.SelectedTopic;
        }

        /// <summary>
        /// Handles form closing.
        /// </summary>
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            topicView.Close();

            Settings.Default.SearchAreaHeight = this.splitContainerSearch.SplitterDistance;

            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.MainFormLocation = this.Location;
                Settings.Default.MainFormSize = this.Size;
            }
            else
            {
                Settings.Default.MainFormLocation = this.RestoreBounds.Location;
                Settings.Default.MainFormSize = this.RestoreBounds.Size;
            }

            if (this.WindowState != FormWindowState.Minimized)
                Settings.Default.MainFormWindowState = this.WindowState;
            else
                Settings.Default.MainFormWindowState = FormWindowState.Normal;

            Settings.Default.Save();

            trayIcon.Visible = false;
        }

        /// <summary>
        /// Handles exiting from program.
        /// </summary>
        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Shows languages manager.
        /// </summary>
        private void OnShowLanguagesManager(object sender, EventArgs e)
        {
            LanguagesManager frm = new LanguagesManager();
            frm.Owner = this;
            frm.ShowDialog();
        }

        /// <summary>
        /// Shows manager of design platforms.
        /// </summary>
        private void OnShowPlatformsManager(object sender, EventArgs e)
        {
            PlatformsManager frm = new PlatformsManager();
            frm.Owner = this;
            frm.ShowDialog();
        }

        /// <summary>
        /// Handles tray menu opening.
        /// </summary>
        private void OnTrayMenuOpening(object sender, CancelEventArgs e)
        {
            restoreToolStripMenuItem.Visible = (this.WindowState == FormWindowState.Minimized);
        }

        /// <summary>
        /// Handles restoring form from tray menu.
        /// </summary>
        private void OnRestore(object sender, EventArgs e)
        {
            RestoreWindow();
        }

        /// <summary>
        /// Restores the window.
        /// </summary>
        public void RestoreWindow()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
            }
            this.Activate();
        }

        /// <summary>
        /// Handles form resizing.
        /// </summary>
        private void OnFormResize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        /// <summary>
        /// Handles search in topics and codes.
        /// </summary>
        private void OnFind(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                splitContainerSearch.Panel2Collapsed = false;

                Cursor curCursor = this.Cursor;
                try
                {
                    lvSearchResults.Items.Clear();

                    this.Cursor = Cursors.WaitCursor;

                    Topic[] searchRes = frm.SearchResult;
                    if ((searchRes == null) || (searchRes.Length == 0))
                        return;

                    foreach (Topic foundTopic in searchRes)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = foundTopic.Title;
                        item.SubItems.Add(foundTopic.Tooltip);
                        item.Tag = foundTopic;
                        lvSearchResults.Items.Add(item);
                    }
                }
                finally
                { this.Cursor = curCursor; }
            }
        }

        /// <summary>
        /// Handles closing of search results.
        /// </summary>
        private void OnCloseSearchResults(object sender, EventArgs e)
        {
            splitContainerSearch.Panel2Collapsed = true;
        }

        /// <summary>
        /// Handles activation of found topic.
        /// </summary>
        private void OnItemActivate(object sender, EventArgs e)
        {
            if (lvSearchResults.SelectedItems.Count == 0)
                return;

            if (!(lvSearchResults.SelectedItems[0].Tag is Topic))
                return;

            topicView.Topic = (lvSearchResults.SelectedItems[0].Tag as Topic);
        }

        /// <summary>
        /// Handles activation of topics tree.
        /// </summary>
        private void OnTopicTreeActivation(object sender, EventArgs e)
        {
            topicView.Topic = topicsTree.SelectedTopic;
        }

        /// <summary>
        /// Handles changing of active topic.
        /// </summary>
        private void OnActiveTopicChanged(object sender, EventArgs e)
        {
            this.Text = m_FormCaption;
            if (topicView.Topic != null)
            {
                this.Text += String.Format(" - [{0}]", topicView.Topic.Tooltip);
            }
            btnSync.Enabled = (topicView.Topic != null);
            btnBack.Enabled = _history.CanGoBack;
            btnForward.Enabled = _history.CanGoForward;
        }

        /// <summary>
        /// Handles changing of history.
        /// </summary>
        private void HistoryManagement(object sender, EventArgs e)
        {
            if (topicView.Topic != null)
            {
                _history.Add(topicView.Topic.Id);

                btnForward.Enabled = false;
            }
        }

        private void OnSynchronizeTopic(object sender, EventArgs e)
        {
            if (topicView.Topic == null)
            { return; }

            var parentTopicIds = Searcher.GetParentTopics(topicView.Topic.Id);

            var lastExpandedNode = topicsTree.ExpandTopics(parentTopicIds);

            if (lastExpandedNode != null)
            {
                topicsTree.SelectTopic(lastExpandedNode.Nodes, topicView.Topic.Id);
            }
        }

        private void OnGoBack(object sender, EventArgs e)
        {
            try
            {
                topicView.TopicChanged -= HistoryManagement;

                var topicId = _history.GoBack();

                var topic = AdviserStorage.Current.Topics.Find(topicId);

                topicView.Topic = topic;
            }
            finally
            {
                topicView.TopicChanged += HistoryManagement;
            }
        }

        private void OnGoForward(object sender, EventArgs e)
        {
            try
            {
                topicView.TopicChanged -= HistoryManagement;

                var topicId = _history.GoForward();

                var topic = AdviserStorage.Current.Topics.Find(topicId);

                topicView.Topic = topic;
            }
            finally
            {
                topicView.TopicChanged += HistoryManagement;
            }
        }
    }
}