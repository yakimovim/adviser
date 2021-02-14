namespace EdlinSoftware.Adviser.Controls.TopicsTree
{
	partial class TopicsTreeControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicsTreeControl));
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.tvTopics = new System.Windows.Forms.TreeView();
			this.cmsTopics = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.createTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.toolStripTopics = new System.Windows.Forms.ToolStrip();
			this.bAddTopTopic = new System.Windows.Forms.ToolStripButton();
			this.bAddSubTopic = new System.Windows.Forms.ToolStripButton();
			this.bDeleteTopic = new System.Windows.Forms.ToolStripButton();
			this.bTopicProperties = new System.Windows.Forms.ToolStripButton();
			this.cmsTopics.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.toolStripTopics.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar.Location = new System.Drawing.Point(0, 305);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(237, 17);
			this.progressBar.TabIndex = 0;
			this.progressBar.Visible = false;
			// 
			// tvTopics
			// 
			this.tvTopics.AllowDrop = true;
			this.tvTopics.ContextMenuStrip = this.cmsTopics;
			this.tvTopics.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvTopics.HideSelection = false;
			this.tvTopics.Location = new System.Drawing.Point(0, 0);
			this.tvTopics.Name = "tvTopics";
			this.tvTopics.ShowNodeToolTips = true;
			this.tvTopics.Size = new System.Drawing.Size(237, 280);
			this.tvTopics.TabIndex = 2;
			this.tvTopics.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
			this.tvTopics.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.OnBeforeTopicExpand);
			this.tvTopics.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnAfterSelect);
			this.tvTopics.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
			this.tvTopics.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
			this.tvTopics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
			// 
			// cmsTopics
			// 
			this.cmsTopics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTopicToolStripMenuItem,
            this.deleteTopicToolStripMenuItem,
            this.propertiesToolStripMenuItem});
			this.cmsTopics.Name = "cmsTopics";
			this.cmsTopics.Size = new System.Drawing.Size(157, 70);
			this.cmsTopics.Opening += new System.ComponentModel.CancelEventHandler(this.OnMenuOpening);
			// 
			// createTopicToolStripMenuItem
			// 
			this.createTopicToolStripMenuItem.Name = "createTopicToolStripMenuItem";
			this.createTopicToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.createTopicToolStripMenuItem.Text = "Create topic...";
			this.createTopicToolStripMenuItem.Click += new System.EventHandler(this.OnMenuCreateTopic);
			// 
			// deleteTopicToolStripMenuItem
			// 
			this.deleteTopicToolStripMenuItem.Name = "deleteTopicToolStripMenuItem";
			this.deleteTopicToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.deleteTopicToolStripMenuItem.Text = "Delete topic...";
			this.deleteTopicToolStripMenuItem.Click += new System.EventHandler(this.OnMenuDeleteTopic);
			// 
			// propertiesToolStripMenuItem
			// 
			this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
			this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.propertiesToolStripMenuItem.Text = "Properties...";
			this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.OnMenuTopicProperties);
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.tvTopics);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(237, 280);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.LeftToolStripPanelVisible = false;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.RightToolStripPanelVisible = false;
			this.toolStripContainer.Size = new System.Drawing.Size(237, 305);
			this.toolStripContainer.TabIndex = 3;
			this.toolStripContainer.Text = "toolStripContainer1";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripTopics);
			// 
			// toolStripTopics
			// 
			this.toolStripTopics.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripTopics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bAddTopTopic,
            this.bAddSubTopic,
            this.bDeleteTopic,
            this.bTopicProperties});
			this.toolStripTopics.Location = new System.Drawing.Point(3, 0);
			this.toolStripTopics.Name = "toolStripTopics";
			this.toolStripTopics.Size = new System.Drawing.Size(135, 25);
			this.toolStripTopics.TabIndex = 0;
			// 
			// bAddTopTopic
			// 
			this.bAddTopTopic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bAddTopTopic.Image = global::EdlinSoftware.Adviser.Properties.Resources.CreateTopLevelTopic;
			this.bAddTopTopic.ImageTransparentColor = System.Drawing.Color.White;
			this.bAddTopTopic.Name = "bAddTopTopic";
			this.bAddTopTopic.Size = new System.Drawing.Size(23, 22);
			this.bAddTopTopic.Text = "Add top level topic";
			this.bAddTopTopic.Click += new System.EventHandler(this.OnAddTopTopic);
			// 
			// bAddSubTopic
			// 
			this.bAddSubTopic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bAddSubTopic.Image = global::EdlinSoftware.Adviser.Properties.Resources.CreateSubTopic;
			this.bAddSubTopic.ImageTransparentColor = System.Drawing.Color.White;
			this.bAddSubTopic.Name = "bAddSubTopic";
			this.bAddSubTopic.Size = new System.Drawing.Size(23, 22);
			this.bAddSubTopic.Text = "Add subtopic";
			this.bAddSubTopic.Click += new System.EventHandler(this.OnAddTopic);
			// 
			// bDeleteTopic
			// 
			this.bDeleteTopic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bDeleteTopic.Image = global::EdlinSoftware.Adviser.Properties.Resources.DeleteTopic;
			this.bDeleteTopic.ImageTransparentColor = System.Drawing.Color.White;
			this.bDeleteTopic.Name = "bDeleteTopic";
			this.bDeleteTopic.Size = new System.Drawing.Size(23, 22);
			this.bDeleteTopic.Text = "Delete topic";
			this.bDeleteTopic.Click += new System.EventHandler(this.OnDeleteTopic);
			// 
			// bTopicProperties
			// 
			this.bTopicProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bTopicProperties.Image = ((System.Drawing.Image)(resources.GetObject("bTopicProperties.Image")));
			this.bTopicProperties.ImageTransparentColor = System.Drawing.Color.Silver;
			this.bTopicProperties.Name = "bTopicProperties";
			this.bTopicProperties.Size = new System.Drawing.Size(23, 22);
			this.bTopicProperties.Text = "Properties of topic";
			this.bTopicProperties.Click += new System.EventHandler(this.OnTopicProperties);
			// 
			// TopicsTreeControl
			// 
			this.Controls.Add(this.toolStripContainer);
			this.Controls.Add(this.progressBar);
			this.Name = "TopicsTreeControl";
			this.Size = new System.Drawing.Size(237, 322);
			this.Load += new System.EventHandler(this.OnLoad);
			this.cmsTopics.ResumeLayout(false);
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.toolStripTopics.ResumeLayout(false);
			this.toolStripTopics.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.TreeView tvTopics;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.ToolStrip toolStripTopics;
		private System.Windows.Forms.ToolStripButton bAddTopTopic;
		private System.Windows.Forms.ToolStripButton bAddSubTopic;
		private System.Windows.Forms.ToolStripButton bDeleteTopic;
		private System.Windows.Forms.ContextMenuStrip cmsTopics;
		private System.Windows.Forms.ToolStripMenuItem createTopicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteTopicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton bTopicProperties;
	}
}
