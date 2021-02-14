using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Properties;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.TopicsTree
{
	/// <summary>
	/// Form for creation of new topic.
	/// </summary>
	public partial class TopicPropertiesForm : Form
	{
		private Topic m_Topic;

		/// <summary>
		/// Åopic which properties will be displayed.
		/// </summary>
		public Topic Topic
		{
			get { return m_Topic; }
			set 
			{ 
				m_Topic = value;
				BindData();
			}
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		public TopicPropertiesForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles Ok click.
		/// </summary>
		private void OnOk(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
			{
				Debug.Assert(Topic != null);
				Topic.Title = tbTitle.Text;
				Topic.Tooltip = tbTooltip.Text;
				Topic.Text.RtfText = rtfDescription.EditorRTF;
                Topic.Text.PlainText = rtfDescription.EditorText;
				this.DialogResult = DialogResult.OK;
			}
		}

		/// <summary>
		/// Validates title.
		/// </summary>
		private void OnTitleValidating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(tbTitle.Text))
			{ 
				errorProvider.SetError(tbTitle, Resources.TopicTitleCantBeNull);
				e.Cancel = true;
			}
			else
			{ errorProvider.SetError(tbTitle, null); }

		}

		/// <summary>
		/// Validates tooltip.
		/// </summary>
		private void OnTooltipValidating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(tbTooltip.Text))
			{ 
				errorProvider.SetError(tbTooltip, Resources.TopicTooltipCantBeNull);
				e.Cancel = true;
			}
			else
			{ errorProvider.SetError(tbTooltip, null); }
		}

		/// <summary>
		/// Handles form loading.
		/// </summary>
		private void OnLoad(object sender, EventArgs e)
		{
			BindData();
		}

		/// <summary>
		/// Binds data with controls.
		/// </summary>
		private void BindData()
		{
            Debug.Assert(Topic != null);
			tbTitle.Text = Topic.Title;
			tbTooltip.Text = Topic.Tooltip;
			rtfDescription.EditorRTF = Topic.Text.RtfText;
		}
	}
}