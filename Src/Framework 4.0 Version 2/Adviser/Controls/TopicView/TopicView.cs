using System;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls
{
	public partial class TopicView : UserControl
	{
		private Topic m_Topic;

		/// <summary>
		/// Indicates changing of topic.
		/// </summary>
		public event EventHandler TopicChanged;

		/// <summary>
		/// Topic to show.
		/// </summary>
		public Topic Topic
		{
			get { return m_Topic; }
			set
			{
				if( m_Topic != null )
				{
                    AdviserStorage.Current.SaveChanges();
				}
				m_Topic = value;
				BindControls();
				OnTopicChanged();
			}
		}

        /// <summary>
		/// Constructor.
		/// </summary>
		public TopicView()
		{
			InitializeComponent();
		}

        /// <summary>
		/// Raises TopicChanged event.
		/// </summary>
		protected virtual void OnTopicChanged()
		{
			if( TopicChanged != null )
				TopicChanged( this, EventArgs.Empty );
		}

		/// <summary>
		/// Binds controls with data.
		/// </summary>
		private void BindControls()
		{
			codesNavigator.Topic = Topic;
            topicDescriptionEditor.EditorRTF = string.Empty;
            topicDescriptionEditor.DataBindings.Clear();
            if (Topic == null)
            {
                topicDescriptionEditor.Enabled = false;
            }
            else
            {
                topicDescriptionEditor.Enabled = true;
                var binding = topicDescriptionEditor.DataBindings.Add("EditorRTF", Topic.Text, "RtfText");
                binding.Parse += OnTopicTextChanged;
            }
		}

        private void OnTopicTextChanged(object sender, ConvertEventArgs cevent)
        {
            Topic.Text.PlainText = topicDescriptionEditor.EditorText;
        }

		/// <summary>
		/// Closes control.
		/// </summary>
		public void Close()
		{
			if( Topic != null || codesNavigator.Code != null )
                AdviserStorage.Current.SaveChanges();
		}

		/// <summary>
		/// Handles changing of code.
		/// </summary>
		private void OnCodeChanged( object sender, EventArgs e )
		{
			codeEditor.EditorRTF = string.Empty;
			codeEditor.DataBindings.Clear();
			if( codesNavigator.Code == null )
			{
				codeEditor.Enabled = false;
			}
			else
			{
                codeEditor.Enabled = true;
                var binding = codeEditor.DataBindings.Add("EditorRTF", codesNavigator.Code.Text, "RtfText");
                binding.Parse += OnCodeTextChanged;
			}
		}

        private void OnCodeTextChanged(object sender, ConvertEventArgs cevent)
        {
            codesNavigator.Code.Text.PlainText = codeEditor.EditorText;
        }
    }
}
