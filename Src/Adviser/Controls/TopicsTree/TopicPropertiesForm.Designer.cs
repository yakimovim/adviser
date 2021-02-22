namespace EdlinSoftware.Adviser.Controls.TopicsTree
{
	partial class TopicPropertiesForm
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
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTooltip = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.bOk = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.rtfDescription = new EdlinSoftware.Controls.WinForms.RTFEditor();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title:";
			// 
			// tbTitle
			// 
			this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.tbTitle.Location = new System.Drawing.Point(66, 6);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(456, 20);
			this.tbTitle.TabIndex = 0;
			this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.OnTitleValidating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tooltip:";
			// 
			// tbTooltip
			// 
			this.tbTooltip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.tbTooltip.Location = new System.Drawing.Point(66, 38);
			this.tbTooltip.Name = "tbTooltip";
			this.tbTooltip.Size = new System.Drawing.Size(456, 20);
			this.tbTooltip.TabIndex = 1;
			this.tbTooltip.Validating += new System.ComponentModel.CancelEventHandler(this.OnTooltipValidating);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(241, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Description:";
			// 
			// bOk
			// 
			this.bOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bOk.Location = new System.Drawing.Point(182, 340);
			this.bOk.Name = "bOk";
			this.bOk.Size = new System.Drawing.Size(75, 23);
			this.bOk.TabIndex = 3;
			this.bOk.Text = "Ok";
			this.bOk.UseVisualStyleBackColor = true;
			this.bOk.Click += new System.EventHandler(this.OnOk);
			// 
			// bCancel
			// 
			this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bCancel.CausesValidation = false;
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point(287, 340);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(75, 23);
			this.bCancel.TabIndex = 4;
			this.bCancel.Text = "Cancel";
			this.bCancel.UseVisualStyleBackColor = true;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// rtfDescription
			// 
			this.rtfDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.rtfDescription.EditorRTF = "{\\rtf1\\ansi\\ansicpg1251\\deff0\\deflang1049{\\fonttbl{\\f0\\fnil\\fcharset204 Microsoft" +
				 " Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
			this.rtfDescription.Location = new System.Drawing.Point(19, 96);
			this.rtfDescription.Name = "rtfDescription";
			this.rtfDescription.Size = new System.Drawing.Size(507, 234);
			this.rtfDescription.TabIndex = 2;
			// 
			// TopicPropertiesForm
			// 
			this.AcceptButton = this.bOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CancelButton = this.bCancel;
			this.ClientSize = new System.Drawing.Size(544, 368);
			this.Controls.Add(this.rtfDescription);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bOk);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbTooltip);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbTitle);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TopicPropertiesForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Topic properties...";
			this.Load += new System.EventHandler(this.OnLoad);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbTooltip;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private EdlinSoftware.Controls.WinForms.RTFEditor rtfDescription;
	}
}