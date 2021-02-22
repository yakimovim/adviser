namespace EdlinSoftware.Adviser.Controls.PlatformsSupport
{
	partial class PlatformsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlatformsManager));
            this.tsLanguages = new System.Windows.Forms.ToolStrip();
            this.bNewPlatform = new System.Windows.Forms.ToolStripButton();
            this.bDeletePlatform = new System.Windows.Forms.ToolStripButton();
            this.bPlatformProperties = new System.Windows.Forms.ToolStripButton();
            this.lvPlatforms = new System.Windows.Forms.ListView();
            this.chPlatforms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bOk = new System.Windows.Forms.Button();
            this.tsLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsLanguages
            // 
            this.tsLanguages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bNewPlatform,
            this.bDeletePlatform,
            this.bPlatformProperties});
            this.tsLanguages.Location = new System.Drawing.Point(0, 0);
            this.tsLanguages.Name = "tsLanguages";
            this.tsLanguages.Size = new System.Drawing.Size(712, 25);
            this.tsLanguages.TabIndex = 1;
            this.tsLanguages.Text = "Languages";
            // 
            // bNewPlatform
            // 
            this.bNewPlatform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNewPlatform.Image = ((System.Drawing.Image)(resources.GetObject("bNewPlatform.Image")));
            this.bNewPlatform.ImageTransparentColor = System.Drawing.Color.White;
            this.bNewPlatform.Name = "bNewPlatform";
            this.bNewPlatform.Size = new System.Drawing.Size(23, 22);
            this.bNewPlatform.Text = "New language";
            this.bNewPlatform.Click += new System.EventHandler(this.OnCreateNewPlatform);
            // 
            // bDeletePlatform
            // 
            this.bDeletePlatform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bDeletePlatform.Image = ((System.Drawing.Image)(resources.GetObject("bDeletePlatform.Image")));
            this.bDeletePlatform.ImageTransparentColor = System.Drawing.Color.White;
            this.bDeletePlatform.Name = "bDeletePlatform";
            this.bDeletePlatform.Size = new System.Drawing.Size(23, 22);
            this.bDeletePlatform.Text = "Delete language";
            this.bDeletePlatform.Click += new System.EventHandler(this.OnDeletePlatform);
            // 
            // bPlatformProperties
            // 
            this.bPlatformProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bPlatformProperties.Image = ((System.Drawing.Image)(resources.GetObject("bPlatformProperties.Image")));
            this.bPlatformProperties.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bPlatformProperties.Name = "bPlatformProperties";
            this.bPlatformProperties.Size = new System.Drawing.Size(23, 22);
            this.bPlatformProperties.Text = "Language properties";
            this.bPlatformProperties.Click += new System.EventHandler(this.OnPlatformProperties);
            // 
            // lvPlatforms
            // 
            this.lvPlatforms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPlatforms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPlatforms});
            this.lvPlatforms.FullRowSelect = true;
            this.lvPlatforms.Location = new System.Drawing.Point(16, 47);
            this.lvPlatforms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvPlatforms.MultiSelect = false;
            this.lvPlatforms.Name = "lvPlatforms";
            this.lvPlatforms.Size = new System.Drawing.Size(679, 307);
            this.lvPlatforms.TabIndex = 0;
            this.lvPlatforms.UseCompatibleStateImageBehavior = false;
            this.lvPlatforms.View = System.Windows.Forms.View.Details;
            this.lvPlatforms.SelectedIndexChanged += new System.EventHandler(this.OnSelectedPlatformChanged);
            this.lvPlatforms.SizeChanged += new System.EventHandler(this.OnListViewSizeChanged);
            // 
            // chPlatforms
            // 
            this.chPlatforms.Text = "Platforms";
            this.chPlatforms.Width = 505;
            // 
            // bOk
            // 
            this.bOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(307, 362);
            this.bOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(100, 28);
            this.bOk.TabIndex = 2;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            // 
            // PlatformsManager
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 405);
            this.Controls.Add(this.tsLanguages);
            this.Controls.Add(this.lvPlatforms);
            this.Controls.Add(this.bOk);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlatformsManager";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Platforms manager";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.tsLanguages.ResumeLayout(false);
            this.tsLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip tsLanguages;
		private System.Windows.Forms.ToolStripButton bNewPlatform;
		private System.Windows.Forms.ToolStripButton bDeletePlatform;
		private System.Windows.Forms.ToolStripButton bPlatformProperties;
		private System.Windows.Forms.ListView lvPlatforms;
		private System.Windows.Forms.ColumnHeader chPlatforms;
		private System.Windows.Forms.Button bOk;
	}
}