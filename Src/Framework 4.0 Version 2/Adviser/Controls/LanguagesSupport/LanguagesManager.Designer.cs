namespace EdlinSoftware.Adviser.Controls.LanguagesSupport
{
	partial class LanguagesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguagesManager));
            this.bOk = new System.Windows.Forms.Button();
            this.lvLanguages = new System.Windows.Forms.ListView();
            this.chLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsLanguages = new System.Windows.Forms.ToolStrip();
            this.bNewLanguage = new System.Windows.Forms.ToolStripButton();
            this.bDeleteLanguage = new System.Windows.Forms.ToolStripButton();
            this.bLanguageProperties = new System.Windows.Forms.ToolStripButton();
            this.tsLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(307, 318);
            this.bOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(100, 28);
            this.bOk.TabIndex = 2;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            // 
            // lvLanguages
            // 
            this.lvLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLanguages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLanguage});
            this.lvLanguages.FullRowSelect = true;
            this.lvLanguages.Location = new System.Drawing.Point(16, 41);
            this.lvLanguages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvLanguages.MultiSelect = false;
            this.lvLanguages.Name = "lvLanguages";
            this.lvLanguages.Size = new System.Drawing.Size(679, 269);
            this.lvLanguages.TabIndex = 0;
            this.lvLanguages.UseCompatibleStateImageBehavior = false;
            this.lvLanguages.View = System.Windows.Forms.View.Details;
            this.lvLanguages.SelectedIndexChanged += new System.EventHandler(this.OnSelectedLanguageChanged);
            this.lvLanguages.SizeChanged += new System.EventHandler(this.OnListViewSizeChanged);
            // 
            // chLanguage
            // 
            this.chLanguage.Text = "Language";
            this.chLanguage.Width = 505;
            // 
            // tsLanguages
            // 
            this.tsLanguages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bNewLanguage,
            this.bDeleteLanguage,
            this.bLanguageProperties});
            this.tsLanguages.Location = new System.Drawing.Point(0, 0);
            this.tsLanguages.Name = "tsLanguages";
            this.tsLanguages.Size = new System.Drawing.Size(712, 25);
            this.tsLanguages.TabIndex = 1;
            this.tsLanguages.Text = "Languages";
            // 
            // bNewLanguage
            // 
            this.bNewLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNewLanguage.Image = ((System.Drawing.Image)(resources.GetObject("bNewLanguage.Image")));
            this.bNewLanguage.ImageTransparentColor = System.Drawing.Color.White;
            this.bNewLanguage.Name = "bNewLanguage";
            this.bNewLanguage.Size = new System.Drawing.Size(23, 22);
            this.bNewLanguage.Text = "New language";
            this.bNewLanguage.Click += new System.EventHandler(this.OnCreateNewLanguage);
            // 
            // bDeleteLanguage
            // 
            this.bDeleteLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bDeleteLanguage.Image = ((System.Drawing.Image)(resources.GetObject("bDeleteLanguage.Image")));
            this.bDeleteLanguage.ImageTransparentColor = System.Drawing.Color.White;
            this.bDeleteLanguage.Name = "bDeleteLanguage";
            this.bDeleteLanguage.Size = new System.Drawing.Size(23, 22);
            this.bDeleteLanguage.Text = "Delete language";
            this.bDeleteLanguage.Click += new System.EventHandler(this.OnDeleteLanguage);
            // 
            // bLanguageProperties
            // 
            this.bLanguageProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bLanguageProperties.Image = ((System.Drawing.Image)(resources.GetObject("bLanguageProperties.Image")));
            this.bLanguageProperties.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bLanguageProperties.Name = "bLanguageProperties";
            this.bLanguageProperties.Size = new System.Drawing.Size(23, 22);
            this.bLanguageProperties.Text = "Language properties";
            this.bLanguageProperties.Click += new System.EventHandler(this.OnLanguageProperties);
            // 
            // LanguagesManager
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 361);
            this.Controls.Add(this.tsLanguages);
            this.Controls.Add(this.lvLanguages);
            this.Controls.Add(this.bOk);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LanguagesManager";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Languages manager";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.tsLanguages.ResumeLayout(false);
            this.tsLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.ListView lvLanguages;
		private System.Windows.Forms.ColumnHeader chLanguage;
		private System.Windows.Forms.ToolStrip tsLanguages;
		private System.Windows.Forms.ToolStripButton bNewLanguage;
		private System.Windows.Forms.ToolStripButton bDeleteLanguage;
		private System.Windows.Forms.ToolStripButton bLanguageProperties;
	}
}