namespace EdlinSoftware.Adviser.Controls.PlatformsSupport
{
	partial class PlatformsChooser
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
			this.bOk = new System.Windows.Forms.Button();
			this.clbPlatforms = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// bOk
			// 
			this.bOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bOk.Location = new System.Drawing.Point(49, 231);
			this.bOk.Name = "bOk";
			this.bOk.Size = new System.Drawing.Size(194, 23);
			this.bOk.TabIndex = 1;
			this.bOk.Text = "Ok";
			this.bOk.UseVisualStyleBackColor = true;
			// 
			// clbPlatforms
			// 
			this.clbPlatforms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.clbPlatforms.CheckOnClick = true;
			this.clbPlatforms.FormattingEnabled = true;
			this.clbPlatforms.Location = new System.Drawing.Point(12, 12);
			this.clbPlatforms.Name = "clbPlatforms";
			this.clbPlatforms.Size = new System.Drawing.Size(268, 199);
			this.clbPlatforms.TabIndex = 0;
			this.clbPlatforms.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnPlatformCheck);
			// 
			// PlatformsChooser
			// 
			this.AcceptButton = this.bOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.clbPlatforms);
			this.Controls.Add(this.bOk);
			this.Name = "PlatformsChooser";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Choose code platforms...";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.CheckedListBox clbPlatforms;
	}
}