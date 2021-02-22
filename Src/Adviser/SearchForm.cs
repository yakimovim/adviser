using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser
{
    /// <summary>
    /// Form for searching text in topics and codes.
    /// </summary>
    public partial class SearchForm : Form
    {
        private static List<string> _lastSearches = new List<string>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public SearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Result of search.
        /// </summary>
        public Topic[] SearchResult
        {
            get { return Searcher.GetTopics(cbSearchFor.Text); }
        }

        /// <summary>
        /// Handles changing of text to search for.
        /// </summary>
        private void OnSearchTextChange(object sender, EventArgs e)
        {
            bSearch.Enabled = !string.IsNullOrEmpty(cbSearchFor.Text.Trim());
        }

        /// <summary>
        /// Handles click of Search button.
        /// </summary>
        private void OnSearchClick(object sender, EventArgs e)
        {
            _lastSearches.Insert(0, cbSearchFor.Text);
        }

        /// <summary>
        /// Handles form loading.
        /// </summary>
        private void OnFormLoad(object sender, EventArgs e)
        {
            cbSearchFor.Items.AddRange(_lastSearches.ToArray());
        }
    }
}