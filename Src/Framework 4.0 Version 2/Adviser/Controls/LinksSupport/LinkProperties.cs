using System;
using System.ComponentModel;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.LinksSupport
{
	/// <summary>
	/// Form for properties of link.
	/// </summary>
	public partial class LinkProperties : Form
	{
		/// <summary>
		/// Attached link.
		/// </summary>
		public AttachedLink Link { get; set; }

        /// <summary>
		/// Constructor.
		/// </summary>
		public LinkProperties()
		{
			InitializeComponent();
		}

        /// <summary>
		/// Handles form loading.
		/// </summary>
		private void OnFormLoad(object sender, EventArgs e)
		{
			if (Link == null)
				Close();
			BindData();
		}

		/// <summary>
		/// Handles Ok click.
		/// </summary>
		private void OnOk(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
			{
				if (Link != null)
				{
					Link.Url = tbHyperlink.Text;
					Link.Comment = tbComment.Text;
				}
				DialogResult = DialogResult.OK;
			}
		}

		/// <summary>
		/// Handles hyperlink validation.
		/// </summary>
		private void OnHyperlinkValidating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(tbHyperlink.Text))
			{
				errorProvider.SetError(tbHyperlink, toolTip.GetToolTip(tbHyperlink));
				e.Cancel = true;
			}
			else
			{
				e.Cancel = false;
				errorProvider.SetError(tbHyperlink, null);
			}
		}

        /// <summary>
		/// Binds data with controls.
		/// </summary>
		private void BindData()
		{
			if (Link != null)
			{
				tbHyperlink.Text = Link.Url;
				tbComment.Text = Link.Comment;
			}
		}
	}
}