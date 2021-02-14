namespace EdlinSoftware.Adviser
{
	partial class AdviserMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdviserMainForm));
            this.splitContainerSearch = new System.Windows.Forms.SplitContainer();
            this.splitContainerTopics = new System.Windows.Forms.SplitContainer();
            this.topicsToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnSync = new System.Windows.Forms.ToolStripButton();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.lvSearchResults = new System.Windows.Forms.ListView();
            this.chTopicText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTopicToolTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pSearchLabel = new System.Windows.Forms.Panel();
            this.bCloseSearchResults = new System.Windows.Forms.Button();
            this.lSearchResults = new System.Windows.Forms.Label();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platformsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.topicsTree = new EdlinSoftware.Adviser.Controls.TopicsTree.TopicsTreeControl();
            this.topicView = new EdlinSoftware.Adviser.Controls.TopicView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearch)).BeginInit();
            this.splitContainerSearch.Panel1.SuspendLayout();
            this.splitContainerSearch.Panel2.SuspendLayout();
            this.splitContainerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTopics)).BeginInit();
            this.splitContainerTopics.Panel1.SuspendLayout();
            this.splitContainerTopics.Panel2.SuspendLayout();
            this.splitContainerTopics.SuspendLayout();
            this.topicsToolStrip.SuspendLayout();
            this.pSearchLabel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerSearch
            // 
            this.splitContainerSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSearch.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSearch.Name = "splitContainerSearch";
            this.splitContainerSearch.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSearch.Panel1
            // 
            this.splitContainerSearch.Panel1.Controls.Add(this.splitContainerTopics);
            // 
            // splitContainerSearch.Panel2
            // 
            this.splitContainerSearch.Panel2.Controls.Add(this.lvSearchResults);
            this.splitContainerSearch.Panel2.Controls.Add(this.pSearchLabel);
            this.splitContainerSearch.Panel2Collapsed = true;
            this.splitContainerSearch.Size = new System.Drawing.Size(879, 382);
            this.splitContainerSearch.SplitterDistance = 200;
            this.splitContainerSearch.TabIndex = 3;
            // 
            // splitContainerTopics
            // 
            this.splitContainerTopics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTopics.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTopics.Name = "splitContainerTopics";
            // 
            // splitContainerTopics.Panel1
            // 
            this.splitContainerTopics.Panel1.Controls.Add(this.topicsTree);
            // 
            // splitContainerTopics.Panel2
            // 
            this.splitContainerTopics.Panel2.Controls.Add(this.topicView);
            this.splitContainerTopics.Panel2.Controls.Add(this.topicsToolStrip);
            this.splitContainerTopics.Size = new System.Drawing.Size(879, 382);
            this.splitContainerTopics.SplitterDistance = 227;
            this.splitContainerTopics.TabIndex = 3;
            // 
            // topicsToolStrip
            // 
            this.topicsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward,
            this.toolStripSeparator2,
            this.btnSync});
            this.topicsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.topicsToolStrip.Name = "topicsToolStrip";
            this.topicsToolStrip.Size = new System.Drawing.Size(644, 25);
            this.topicsToolStrip.TabIndex = 1;
            // 
            // btnSync
            // 
            this.btnSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSync.Enabled = false;
            this.btnSync.Image = global::EdlinSoftware.Adviser.Properties.Resources.Sync;
            this.btnSync.ImageTransparentColor = System.Drawing.Color.White;
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(23, 22);
            this.btnSync.ToolTipText = "Synchronize topics tree";
            this.btnSync.Click += new System.EventHandler(this.OnSynchronizeTopic);
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Enabled = false;
            this.btnBack.Image = global::EdlinSoftware.Adviser.Properties.Resources.Back;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.White;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 22);
            this.btnBack.ToolTipText = "Navigate backward";
            this.btnBack.Click += new System.EventHandler(this.OnGoBack);
            // 
            // lvSearchResults
            // 
            this.lvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTopicText,
            this.chTopicToolTip});
            this.lvSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSearchResults.FullRowSelect = true;
            this.lvSearchResults.Location = new System.Drawing.Point(0, 20);
            this.lvSearchResults.MultiSelect = false;
            this.lvSearchResults.Name = "lvSearchResults";
            this.lvSearchResults.Size = new System.Drawing.Size(146, 22);
            this.lvSearchResults.TabIndex = 0;
            this.lvSearchResults.UseCompatibleStateImageBehavior = false;
            this.lvSearchResults.View = System.Windows.Forms.View.Details;
            this.lvSearchResults.ItemActivate += new System.EventHandler(this.OnItemActivate);
            // 
            // chTopicText
            // 
            this.chTopicText.Text = "Topic text";
            this.chTopicText.Width = 200;
            // 
            // chTopicToolTip
            // 
            this.chTopicToolTip.Text = "Topic tooltip";
            this.chTopicToolTip.Width = 400;
            // 
            // pSearchLabel
            // 
            this.pSearchLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pSearchLabel.Controls.Add(this.bCloseSearchResults);
            this.pSearchLabel.Controls.Add(this.lSearchResults);
            this.pSearchLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearchLabel.Location = new System.Drawing.Point(0, 0);
            this.pSearchLabel.Name = "pSearchLabel";
            this.pSearchLabel.Size = new System.Drawing.Size(146, 20);
            this.pSearchLabel.TabIndex = 1;
            // 
            // bCloseSearchResults
            // 
            this.bCloseSearchResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.bCloseSearchResults.Location = new System.Drawing.Point(126, 0);
            this.bCloseSearchResults.Name = "bCloseSearchResults";
            this.bCloseSearchResults.Size = new System.Drawing.Size(20, 20);
            this.bCloseSearchResults.TabIndex = 1;
            this.bCloseSearchResults.Text = "X";
            this.bCloseSearchResults.UseVisualStyleBackColor = true;
            this.bCloseSearchResults.Click += new System.EventHandler(this.OnCloseSearchResults);
            // 
            // lSearchResults
            // 
            this.lSearchResults.AutoSize = true;
            this.lSearchResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.lSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSearchResults.Location = new System.Drawing.Point(0, 0);
            this.lSearchResults.Name = "lSearchResults";
            this.lSearchResults.Size = new System.Drawing.Size(92, 13);
            this.lSearchResults.TabIndex = 0;
            this.lSearchResults.Text = "Search results:";
            this.lSearchResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainerSearch);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(879, 382);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(879, 406);
            this.toolStripContainer.TabIndex = 4;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(879, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.toolStripSeparator1,
            this.languagesToolStripMenuItem,
            this.platformsToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.findToolStripMenuItem.Text = "Find...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.OnFind);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.languagesToolStripMenuItem.Text = "Languages...";
            this.languagesToolStripMenuItem.Click += new System.EventHandler(this.OnShowLanguagesManager);
            // 
            // platformsToolStripMenuItem
            // 
            this.platformsToolStripMenuItem.Name = "platformsToolStripMenuItem";
            this.platformsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.platformsToolStripMenuItem.Text = "Platforms...";
            this.platformsToolStripMenuItem.Click += new System.EventHandler(this.OnShowPlatformsManager);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Adviser";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.OnRestore);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.ShowImageMargin = false;
            this.trayMenu.Size = new System.Drawing.Size(82, 48);
            this.trayMenu.Opening += new System.ComponentModel.CancelEventHandler(this.OnTrayMenuOpening);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.ShowShortcutKeys = false;
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.ToolTipText = "Restore Adviser application";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.OnRestore);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShowShortcutKeys = false;
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.ToolTipText = "Close Adviser application";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward.Enabled = false;
            this.btnForward.Image = global::EdlinSoftware.Adviser.Properties.Resources.Forward;
            this.btnForward.ImageTransparentColor = System.Drawing.Color.White;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(23, 22);
            this.btnForward.ToolTipText = "Navigate forward";
            this.btnForward.Click += new System.EventHandler(this.OnGoForward);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // topicsTree
            // 
            this.topicsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicsTree.Location = new System.Drawing.Point(0, 0);
            this.topicsTree.Name = "topicsTree";
            this.topicsTree.Size = new System.Drawing.Size(223, 378);
            this.topicsTree.TabIndex = 2;
            this.topicsTree.SelectedTopicChanged += new System.EventHandler(this.OnSelectedTopicChanged);
            this.topicsTree.Enter += new System.EventHandler(this.OnTopicTreeActivation);
            // 
            // topicView
            // 
            this.topicView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicView.Location = new System.Drawing.Point(0, 25);
            this.topicView.Name = "topicView";
            this.topicView.Size = new System.Drawing.Size(644, 353);
            this.topicView.TabIndex = 0;
            this.topicView.Topic = null;
            this.topicView.TopicChanged += new System.EventHandler(this.OnActiveTopicChanged);
            // 
            // AdviserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 406);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AdviserMainForm";
            this.Text = "Adviser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnAdviserFormLoad);
            this.Resize += new System.EventHandler(this.OnFormResize);
            this.splitContainerSearch.Panel1.ResumeLayout(false);
            this.splitContainerSearch.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearch)).EndInit();
            this.splitContainerSearch.ResumeLayout(false);
            this.splitContainerTopics.Panel1.ResumeLayout(false);
            this.splitContainerTopics.Panel2.ResumeLayout(false);
            this.splitContainerTopics.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTopics)).EndInit();
            this.splitContainerTopics.ResumeLayout(false);
            this.topicsToolStrip.ResumeLayout(false);
            this.topicsToolStrip.PerformLayout();
            this.pSearchLabel.ResumeLayout(false);
            this.pSearchLabel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private EdlinSoftware.Adviser.Controls.TopicsTree.TopicsTreeControl topicsTree;
		private System.Windows.Forms.SplitContainer splitContainerSearch;
		private System.Windows.Forms.SplitContainer splitContainerTopics;
		private System.Windows.Forms.ListView lvSearchResults;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private EdlinSoftware.Adviser.Controls.TopicView topicView;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem platformsToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.ContextMenuStrip trayMenu;
		private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Panel pSearchLabel;
		private System.Windows.Forms.Label lSearchResults;
		private System.Windows.Forms.Button bCloseSearchResults;
		private System.Windows.Forms.ColumnHeader chTopicText;
		private System.Windows.Forms.ColumnHeader chTopicToolTip;
        private System.Windows.Forms.ToolStrip topicsToolStrip;
        private System.Windows.Forms.ToolStripButton btnSync;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;


	}
}

