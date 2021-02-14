namespace EdlinSoftware.Adviser.Controls.LinksSupport
{
	partial class LinkProperties
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbHyperlink = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbComment = new System.Windows.Forms.TextBox();
			this.bOk = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider( this.components );
			this.toolTip = new System.Windows.Forms.ToolTip( this.components );
			( (System.ComponentModel.ISupportInitialize) ( this.errorProvider ) ).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 12, 9 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 54, 13 );
			this.label1.TabIndex = 0;
			this.label1.Text = "Hyperlink:";
			// 
			// tbHyperlink
			// 
			this.tbHyperlink.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
							| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tbHyperlink.Location = new System.Drawing.Point( 72, 6 );
			this.tbHyperlink.Name = "tbHyperlink";
			this.tbHyperlink.Size = new System.Drawing.Size( 193, 20 );
			this.tbHyperlink.TabIndex = 1;
			this.toolTip.SetToolTip( this.tbHyperlink, "Enter hyperlink." );
			this.tbHyperlink.Validating += new System.ComponentModel.CancelEventHandler( this.OnHyperlinkValidating );
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 12, 41 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 54, 13 );
			this.label2.TabIndex = 2;
			this.label2.Text = "Comment:";
			// 
			// tbComment
			// 
			this.tbComment.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
							| System.Windows.Forms.AnchorStyles.Left )
							| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tbComment.Location = new System.Drawing.Point( 12, 57 );
			this.tbComment.Multiline = true;
			this.tbComment.Name = "tbComment";
			this.tbComment.Size = new System.Drawing.Size( 253, 168 );
			this.tbComment.TabIndex = 3;
			this.toolTip.SetToolTip( this.tbComment, "Enter comment for link." );
			// 
			// bOk
			// 
			this.bOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bOk.Location = new System.Drawing.Point( 61, 231 );
			this.bOk.Name = "bOk";
			this.bOk.Size = new System.Drawing.Size( 75, 23 );
			this.bOk.TabIndex = 4;
			this.bOk.Text = "Ok";
			this.bOk.UseVisualStyleBackColor = true;
			this.bOk.Click += new System.EventHandler( this.OnOk );
			// 
			// bCancel
			// 
			this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bCancel.CausesValidation = false;
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point( 157, 231 );
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size( 75, 23 );
			this.bCancel.TabIndex = 5;
			this.bCancel.Text = "Cancel";
			this.bCancel.UseVisualStyleBackColor = true;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// LinkProperties
			// 
			this.AcceptButton = this.bOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CancelButton = this.bCancel;
			this.ClientSize = new System.Drawing.Size( 292, 266 );
			this.Controls.Add( this.bCancel );
			this.Controls.Add( this.bOk );
			this.Controls.Add( this.tbComment );
			this.Controls.Add( this.label2 );
			this.Controls.Add( this.tbHyperlink );
			this.Controls.Add( this.label1 );
			this.MaximizeBox = false;
			this.Name = "LinkProperties";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Link properties...";
			this.Load += new System.EventHandler( this.OnFormLoad );
			( (System.ComponentModel.ISupportInitialize) ( this.errorProvider ) ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbHyperlink;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbComment;
		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ToolTip toolTip;
	}
}