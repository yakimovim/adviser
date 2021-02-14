namespace EdlinSoftware.Adviser.Controls.LanguagesSupport
{
	partial class LanguageProperties
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
			this.bOk = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbLanguageName = new System.Windows.Forms.TextBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// bOk
			// 
			this.bOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bOk.Location = new System.Drawing.Point(63, 44);
			this.bOk.Name = "bOk";
			this.bOk.Size = new System.Drawing.Size(75, 23);
			this.bOk.TabIndex = 1;
			this.bOk.Text = "Ok";
			this.bOk.UseVisualStyleBackColor = true;
			this.bOk.Click += new System.EventHandler(this.OnOk);
			// 
			// bCancel
			// 
			this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point(155, 44);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(75, 23);
			this.bCancel.TabIndex = 2;
			this.bCancel.Text = "Cancel";
			this.bCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Language name:";
			// 
			// tbLanguageName
			// 
			this.tbLanguageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.tbLanguageName.Location = new System.Drawing.Point(105, 9);
			this.tbLanguageName.Name = "tbLanguageName";
			this.tbLanguageName.Size = new System.Drawing.Size(158, 20);
			this.tbLanguageName.TabIndex = 0;
			this.toolTip.SetToolTip(this.tbLanguageName, "Enter name of programming language");
			this.tbLanguageName.Validating += new System.ComponentModel.CancelEventHandler(this.OnLanguageNameValidating);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// LanguageProperties
			// 
			this.AcceptButton = this.bOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.bCancel;
			this.ClientSize = new System.Drawing.Size(292, 79);
			this.Controls.Add(this.tbLanguageName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LanguageProperties";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Language properties...";
			this.Load += new System.EventHandler(this.OnFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbLanguageName;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ToolTip toolTip;
	}
}