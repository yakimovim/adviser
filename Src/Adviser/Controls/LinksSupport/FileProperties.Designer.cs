namespace EdlinSoftware.Adviser.Controls.LinksSupport
{
	partial class FileProperties
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bBrowse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bCancel.CausesValidation = false;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(209, 284);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(100, 28);
            this.bCancel.TabIndex = 11;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bOk
            // 
            this.bOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bOk.Location = new System.Drawing.Point(81, 284);
            this.bOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(100, 28);
            this.bOk.TabIndex = 10;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.OnOk);
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComment.Location = new System.Drawing.Point(16, 70);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(336, 206);
            this.tbComment.TabIndex = 9;
            this.toolTip.SetToolTip(this.tbComment, "Enter comment.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Comment:";
            // 
            // tbFileName
            // 
            this.tbFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileName.Location = new System.Drawing.Point(96, 7);
            this.tbFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(256, 22);
            this.tbFileName.TabIndex = 7;
            this.toolTip.SetToolTip(this.tbFileName, "Enter name of file.");
            this.tbFileName.Validating += new System.ComponentModel.CancelEventHandler(this.OnFileNameValidating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "File name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bBrowse
            // 
            this.bBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowse.CausesValidation = false;
            this.bBrowse.Location = new System.Drawing.Point(209, 37);
            this.bBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(141, 26);
            this.bBrowse.TabIndex = 12;
            this.bBrowse.Text = "Browse";
            this.toolTip.SetToolTip(this.bBrowse, "Attach file.");
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Visible = false;
            this.bBrowse.Click += new System.EventHandler(this.OnAttachFile);
            this.bBrowse.Validating += new System.ComponentModel.CancelEventHandler(this.OnFileContentValidating);
            // 
            // openFileDialog
            // 
            this.openFileDialog.AddExtension = false;
            this.openFileDialog.RestoreDirectory = true;
            // 
            // FileProperties
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(389, 327);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FileProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File properties...";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.TextBox tbComment;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbFileName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button bBrowse;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}