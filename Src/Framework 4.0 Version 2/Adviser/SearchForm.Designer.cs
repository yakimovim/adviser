namespace EdlinSoftware.Adviser
{
	partial class SearchForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bCancel = new System.Windows.Forms.Button();
			this.bSearch = new System.Windows.Forms.Button();
			this.lSearch = new System.Windows.Forms.Label();
			this.cbSearchFor = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// bCancel
			// 
			this.bCancel.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point( 252, 39 );
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size( 75, 23 );
			this.bCancel.TabIndex = 2;
			this.bCancel.Text = "Cancel";
			this.bCancel.UseVisualStyleBackColor = true;
			// 
			// bSearch
			// 
			this.bSearch.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.bSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bSearch.Enabled = false;
			this.bSearch.Location = new System.Drawing.Point( 171, 39 );
			this.bSearch.Name = "bSearch";
			this.bSearch.Size = new System.Drawing.Size( 75, 23 );
			this.bSearch.TabIndex = 1;
			this.bSearch.Text = "Search";
			this.bSearch.UseVisualStyleBackColor = true;
			this.bSearch.Click += new System.EventHandler( this.OnSearchClick );
			// 
			// lSearch
			// 
			this.lSearch.AutoSize = true;
			this.lSearch.Location = new System.Drawing.Point( 12, 9 );
			this.lSearch.Name = "lSearch";
			this.lSearch.Size = new System.Drawing.Size( 59, 13 );
			this.lSearch.TabIndex = 2;
			this.lSearch.Text = "Search for:";
			// 
			// cbSearchFor
			// 
			this.cbSearchFor.FormattingEnabled = true;
			this.cbSearchFor.Location = new System.Drawing.Point( 77, 6 );
			this.cbSearchFor.Name = "cbSearchFor";
			this.cbSearchFor.Size = new System.Drawing.Size( 250, 21 );
			this.cbSearchFor.TabIndex = 0;
			this.cbSearchFor.SelectedIndexChanged += new System.EventHandler( this.OnSearchTextChange );
			this.cbSearchFor.TextUpdate += new System.EventHandler( this.OnSearchTextChange );
			// 
			// SearchForm
			// 
			this.AcceptButton = this.bSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.bCancel;
			this.ClientSize = new System.Drawing.Size( 339, 74 );
			this.Controls.Add( this.cbSearchFor );
			this.Controls.Add( this.lSearch );
			this.Controls.Add( this.bSearch );
			this.Controls.Add( this.bCancel );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Search...";
			this.Load += new System.EventHandler( this.OnFormLoad );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bSearch;
		private System.Windows.Forms.Label lSearch;
		private System.Windows.Forms.ComboBox cbSearchFor;
	}
}