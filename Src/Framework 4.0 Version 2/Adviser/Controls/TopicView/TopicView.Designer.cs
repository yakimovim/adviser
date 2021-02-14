namespace EdlinSoftware.Adviser.Controls
{
	partial class TopicView
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.topicDescriptionEditor = new EdlinSoftware.Controls.WinForms.RTFEditor();
            this.codesNavigator = new EdlinSoftware.Adviser.Controls.CodesNavigator.CodesNavigator();
            this.codeEditor = new EdlinSoftware.Controls.WinForms.RTFEditor();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.topicDescriptionEditor);
            this.splitContainer.Panel1.Controls.Add(this.codesNavigator);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.codeEditor);
            this.splitContainer.Size = new System.Drawing.Size(975, 540);
            this.splitContainer.SplitterDistance = 279;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 0;
            // 
            // topicDescriptionEditor
            // 
            this.topicDescriptionEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicDescriptionEditor.EditorRTF = "{\\rtf1\\ansi\\ansicpg1251\\deff0\\deflang1049{\\fonttbl{\\f0\\fnil\\fcharset204 Microsoft" +
    " Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.topicDescriptionEditor.Location = new System.Drawing.Point(0, 0);
            this.topicDescriptionEditor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.topicDescriptionEditor.Name = "topicDescriptionEditor";
            this.topicDescriptionEditor.Size = new System.Drawing.Size(971, 221);
            this.topicDescriptionEditor.TabIndex = 0;
            // 
            // codesNavigator
            // 
            this.codesNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.codesNavigator.Location = new System.Drawing.Point(0, 221);
            this.codesNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.codesNavigator.Name = "codesNavigator";
            this.codesNavigator.Size = new System.Drawing.Size(971, 54);
            this.codesNavigator.TabIndex = 1;
            this.codesNavigator.Topic = null;
            this.codesNavigator.CodeChanged += new System.EventHandler(this.OnCodeChanged);
            // 
            // codeEditor
            // 
            this.codeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditor.EditorRTF = "{\\rtf1\\ansi\\ansicpg1251\\deff0\\deflang1049{\\fonttbl{\\f0\\fnil\\fcharset204 Microsoft" +
    " Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.codeEditor.Location = new System.Drawing.Point(0, 0);
            this.codeEditor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Size = new System.Drawing.Size(971, 252);
            this.codeEditor.TabIndex = 0;
            // 
            // TopicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TopicView";
            this.Size = new System.Drawing.Size(975, 540);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private EdlinSoftware.Controls.WinForms.RTFEditor topicDescriptionEditor;
		private EdlinSoftware.Adviser.Controls.CodesNavigator.CodesNavigator codesNavigator;
		private EdlinSoftware.Controls.WinForms.RTFEditor codeEditor;
	}
}
