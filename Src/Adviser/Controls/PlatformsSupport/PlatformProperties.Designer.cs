namespace EdlinSoftware.Adviser.Controls.PlatformsSupport
{
	partial class PlatformProperties
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
            this.tbPlatformName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPlatformName
            // 
            this.tbPlatformName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlatformName.Location = new System.Drawing.Point(144, 11);
            this.tbPlatformName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPlatformName.Name = "tbPlatformName";
            this.tbPlatformName.Size = new System.Drawing.Size(209, 22);
            this.tbPlatformName.TabIndex = 0;
            this.toolTip.SetToolTip(this.tbPlatformName, "Enter name of design platform");
            this.tbPlatformName.Validating += new System.ComponentModel.CancelEventHandler(this.OnPlatformNameValidating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Platform name:";
            // 
            // bCancel
            // 
            this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(217, 54);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(100, 28);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bOk
            // 
            this.bOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bOk.Location = new System.Drawing.Point(95, 54);
            this.bOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(100, 28);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.OnOk);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PlatformProperties
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(387, 95);
            this.Controls.Add(this.tbPlatformName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlatformProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Platform properties...";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPlatformName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ToolTip toolTip;
	}
}