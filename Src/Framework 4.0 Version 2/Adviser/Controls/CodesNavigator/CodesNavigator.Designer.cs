namespace EdlinSoftware.Adviser.Controls.CodesNavigator
{
	partial class CodesNavigator
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bFirst = new System.Windows.Forms.Button();
            this.bPrev = new System.Windows.Forms.Button();
            this.pCount = new System.Windows.Forms.Panel();
            this.lCount = new System.Windows.Forms.Label();
            this.bNext = new System.Windows.Forms.Button();
            this.bLast = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLanguages = new System.Windows.Forms.ComboBox();
            this.bPlatforms = new System.Windows.Forms.Button();
            this.bLinks = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel.SuspendLayout();
            this.pCount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Controls.Add(this.bFirst);
            this.flowLayoutPanel.Controls.Add(this.bPrev);
            this.flowLayoutPanel.Controls.Add(this.pCount);
            this.flowLayoutPanel.Controls.Add(this.bNext);
            this.flowLayoutPanel.Controls.Add(this.bLast);
            this.flowLayoutPanel.Controls.Add(this.bNew);
            this.flowLayoutPanel.Controls.Add(this.bDelete);
            this.flowLayoutPanel.Controls.Add(this.panel1);
            this.flowLayoutPanel.Controls.Add(this.bPlatforms);
            this.flowLayoutPanel.Controls.Add(this.bLinks);
            this.flowLayoutPanel.Location = new System.Drawing.Point(4, 1);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(885, 51);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // bFirst
            // 
            this.bFirst.Location = new System.Drawing.Point(4, 4);
            this.bFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bFirst.Name = "bFirst";
            this.bFirst.Size = new System.Drawing.Size(47, 43);
            this.bFirst.TabIndex = 0;
            this.bFirst.Text = "<<";
            this.toolTip.SetToolTip(this.bFirst, "Go to the first code");
            this.bFirst.UseVisualStyleBackColor = true;
            this.bFirst.Click += new System.EventHandler(this.OnMoveToFirst);
            // 
            // bPrev
            // 
            this.bPrev.Location = new System.Drawing.Point(59, 4);
            this.bPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(47, 43);
            this.bPrev.TabIndex = 1;
            this.bPrev.Text = "<";
            this.toolTip.SetToolTip(this.bPrev, "Go to the previous code");
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.OnMoveToPrev);
            // 
            // pCount
            // 
            this.pCount.Controls.Add(this.lCount);
            this.pCount.Location = new System.Drawing.Point(114, 4);
            this.pCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pCount.Name = "pCount";
            this.pCount.Size = new System.Drawing.Size(111, 43);
            this.pCount.TabIndex = 2;
            // 
            // lCount
            // 
            this.lCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCount.Location = new System.Drawing.Point(0, 0);
            this.lCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(111, 43);
            this.lCount.TabIndex = 0;
            this.lCount.Text = "Total:";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(233, 4);
            this.bNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(47, 43);
            this.bNext.TabIndex = 3;
            this.bNext.Text = ">";
            this.toolTip.SetToolTip(this.bNext, "Go to the next code");
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.OnMoveToNext);
            // 
            // bLast
            // 
            this.bLast.Location = new System.Drawing.Point(288, 4);
            this.bLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLast.Name = "bLast";
            this.bLast.Size = new System.Drawing.Size(47, 43);
            this.bLast.TabIndex = 4;
            this.bLast.Text = ">>";
            this.toolTip.SetToolTip(this.bLast, "Go to the last code");
            this.bLast.UseVisualStyleBackColor = true;
            this.bLast.Click += new System.EventHandler(this.OnMoveToLast);
            // 
            // bNew
            // 
            this.bNew.Image = global::EdlinSoftware.Adviser.Properties.Resources.CreateTopLevelTopic;
            this.bNew.Location = new System.Drawing.Point(343, 4);
            this.bNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(47, 43);
            this.bNew.TabIndex = 5;
            this.toolTip.SetToolTip(this.bNew, "Create new code");
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.OnCreateNewCode);
            // 
            // bDelete
            // 
            this.bDelete.Image = global::EdlinSoftware.Adviser.Properties.Resources.DeleteTopic;
            this.bDelete.Location = new System.Drawing.Point(398, 4);
            this.bDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(47, 43);
            this.bDelete.TabIndex = 6;
            this.toolTip.SetToolTip(this.bDelete, "Delete code");
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.OnDeleteCode);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLanguages);
            this.panel1.Location = new System.Drawing.Point(453, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 43);
            this.panel1.TabIndex = 7;
            // 
            // cbLanguages
            // 
            this.cbLanguages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguages.FormattingEnabled = true;
            this.cbLanguages.Location = new System.Drawing.Point(5, 9);
            this.cbLanguages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(160, 24);
            this.cbLanguages.TabIndex = 0;
            this.cbLanguages.SelectedIndexChanged += new System.EventHandler(this.OnLanguageChange);
            // 
            // bPlatforms
            // 
            this.bPlatforms.Location = new System.Drawing.Point(632, 4);
            this.bPlatforms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPlatforms.Name = "bPlatforms";
            this.bPlatforms.Size = new System.Drawing.Size(85, 43);
            this.bPlatforms.TabIndex = 8;
            this.bPlatforms.Text = "Platforms";
            this.bPlatforms.UseVisualStyleBackColor = true;
            this.bPlatforms.Click += new System.EventHandler(this.OnShowPlatforms);
            // 
            // bLinks
            // 
            this.bLinks.Location = new System.Drawing.Point(725, 4);
            this.bLinks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLinks.Name = "bLinks";
            this.bLinks.Size = new System.Drawing.Size(85, 43);
            this.bLinks.TabIndex = 9;
            this.bLinks.Text = "Links";
            this.bLinks.UseVisualStyleBackColor = true;
            this.bLinks.Click += new System.EventHandler(this.OnShowLinks);
            // 
            // CodesNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CodesNavigator";
            this.Size = new System.Drawing.Size(893, 52);
            this.flowLayoutPanel.ResumeLayout(false);
            this.pCount.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.Button bFirst;
		private System.Windows.Forms.Button bPrev;
		private System.Windows.Forms.Panel pCount;
		private System.Windows.Forms.Label lCount;
		private System.Windows.Forms.Button bNext;
		private System.Windows.Forms.Button bLast;
		private System.Windows.Forms.Button bNew;
		private System.Windows.Forms.Button bDelete;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbLanguages;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button bPlatforms;
		private System.Windows.Forms.Button bLinks;
	}
}
