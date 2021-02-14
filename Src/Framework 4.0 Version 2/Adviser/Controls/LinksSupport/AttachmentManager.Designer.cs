namespace EdlinSoftware.Adviser.Controls.LinksSupport
{
	partial class AttachmentManager
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachmentManager));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.bOk = new System.Windows.Forms.Button();
            this.lvAttachments = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripAttachments = new System.Windows.Forms.ToolStrip();
            this.bAddLink = new System.Windows.Forms.ToolStripButton();
            this.bAddFile = new System.Windows.Forms.ToolStripButton();
            this.bRemove = new System.Windows.Forms.ToolStripButton();
            this.bProperties = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStripAttachments.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.bOk);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lvAttachments);
            this.toolStripContainer.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(601, 302);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(601, 327);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripAttachments);
            // 
            // bOk
            // 
            this.bOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(205, 266);
            this.bOk.Margin = new System.Windows.Forms.Padding(4);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(191, 28);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            // 
            // lvAttachments
            // 
            this.lvAttachments.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAttachments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chComment});
            this.lvAttachments.FullRowSelect = true;
            this.lvAttachments.HideSelection = false;
            this.lvAttachments.Location = new System.Drawing.Point(4, 4);
            this.lvAttachments.Margin = new System.Windows.Forms.Padding(4);
            this.lvAttachments.MultiSelect = false;
            this.lvAttachments.Name = "lvAttachments";
            this.lvAttachments.Size = new System.Drawing.Size(592, 254);
            this.lvAttachments.TabIndex = 0;
            this.lvAttachments.UseCompatibleStateImageBehavior = false;
            this.lvAttachments.View = System.Windows.Forms.View.Details;
            this.lvAttachments.ItemActivate += new System.EventHandler(this.OnItemActivate);
            this.lvAttachments.SelectedIndexChanged += new System.EventHandler(this.OnSelectedAttachmentChanged);
            // 
            // chName
            // 
            this.chName.Text = "Attachment name";
            this.chName.Width = 200;
            // 
            // chComment
            // 
            this.chComment.Text = "Comment";
            this.chComment.Width = 220;
            // 
            // toolStripAttachments
            // 
            this.toolStripAttachments.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAttachments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bAddLink,
            this.bAddFile,
            this.bRemove,
            this.bProperties});
            this.toolStripAttachments.Location = new System.Drawing.Point(3, 0);
            this.toolStripAttachments.Name = "toolStripAttachments";
            this.toolStripAttachments.Size = new System.Drawing.Size(104, 25);
            this.toolStripAttachments.TabIndex = 0;
            // 
            // bAddLink
            // 
            this.bAddLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bAddLink.Image = global::EdlinSoftware.Adviser.Properties.Resources.Hyperlink;
            this.bAddLink.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bAddLink.Name = "bAddLink";
            this.bAddLink.Size = new System.Drawing.Size(23, 22);
            this.bAddLink.Text = "Add hyperlink";
            this.bAddLink.Click += new System.EventHandler(this.OnAddLink);
            // 
            // bAddFile
            // 
            this.bAddFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bAddFile.Image = global::EdlinSoftware.Adviser.Properties.Resources.CreateTopLevelTopic;
            this.bAddFile.ImageTransparentColor = System.Drawing.Color.White;
            this.bAddFile.Name = "bAddFile";
            this.bAddFile.Size = new System.Drawing.Size(23, 22);
            this.bAddFile.Text = "Add file";
            this.bAddFile.Click += new System.EventHandler(this.OnAddFile);
            // 
            // bRemove
            // 
            this.bRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bRemove.Image = ((System.Drawing.Image)(resources.GetObject("bRemove.Image")));
            this.bRemove.ImageTransparentColor = System.Drawing.Color.White;
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(23, 22);
            this.bRemove.Text = "Remove attachment";
            this.bRemove.Click += new System.EventHandler(this.OnDelete);
            // 
            // bProperties
            // 
            this.bProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bProperties.Image = global::EdlinSoftware.Adviser.Properties.Resources.TopicProperties;
            this.bProperties.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bProperties.Name = "bProperties";
            this.bProperties.Size = new System.Drawing.Size(23, 22);
            this.bProperties.Text = "Properties...";
            this.bProperties.Click += new System.EventHandler(this.OnProperties);
            // 
            // AttachmentManager
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bOk;
            this.ClientSize = new System.Drawing.Size(601, 327);
            this.Controls.Add(this.toolStripContainer);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AttachmentManager";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attachment manager";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStripAttachments.ResumeLayout(false);
            this.toolStripAttachments.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.ListView lvAttachments;
		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chComment;
		private System.Windows.Forms.ToolStrip toolStripAttachments;
		private System.Windows.Forms.ToolStripButton bAddLink;
		private System.Windows.Forms.ToolStripButton bAddFile;
		private System.Windows.Forms.ToolStripButton bRemove;
        private System.Windows.Forms.ToolStripButton bProperties;
	}
}