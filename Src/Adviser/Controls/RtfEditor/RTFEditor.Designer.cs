namespace EdlinSoftware.Controls.WinForms
{
	partial class RTFEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTFEditor));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStripCommon = new System.Windows.Forms.ToolStrip();
            this.bPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bCut = new System.Windows.Forms.ToolStripButton();
            this.bCopy = new System.Windows.Forms.ToolStripButton();
            this.bPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bUndo = new System.Windows.Forms.ToolStripButton();
            this.bRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbScale = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripFormat = new System.Windows.Forms.ToolStrip();
            this.cbFontFamily = new System.Windows.Forms.ToolStripComboBox();
            this.cbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.bFont = new System.Windows.Forms.ToolStripButton();
            this.bWordWrap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.bCopyFormat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.bAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.bAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bBold = new System.Windows.Forms.ToolStripButton();
            this.bUnderline = new System.Windows.Forms.ToolStripButton();
            this.bItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bSuperScript = new System.Windows.Forms.ToolStripButton();
            this.bSubScript = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bBullets = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bBackColor = new System.Windows.Forms.ToolStripSplitButton();
            this.miChooseBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.bTextColor = new System.Windows.Forms.ToolStripSplitButton();
            this.miChooseTextColor = new System.Windows.Forms.ToolStripMenuItem();
            this.bSymbols = new System.Windows.Forms.ToolStripDropDownButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStripCommon.SuspendLayout();
            this.toolStripFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.richTextBox);
            this.toolStripContainer.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(824, 416);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(824, 444);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripCommon);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripFormat);
            // 
            // richTextBox
            // 
            this.richTextBox.AcceptsTab = true;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(824, 416);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.OnLinkClicked);
            this.richTextBox.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
            this.richTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnEditorKeyDown);
            // 
            // toolStripCommon
            // 
            this.toolStripCommon.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripCommon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCommon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bPrint,
            this.toolStripSeparator4,
            this.bCut,
            this.bCopy,
            this.bPaste,
            this.toolStripSeparator3,
            this.bUndo,
            this.bRedo,
            this.toolStripSeparator1,
            this.cbScale});
            this.toolStripCommon.Location = new System.Drawing.Point(727, 0);
            this.toolStripCommon.Name = "toolStripCommon";
            this.toolStripCommon.Size = new System.Drawing.Size(97, 27);
            this.toolStripCommon.TabIndex = 1;
            this.toolStripCommon.Text = "toolStrip";
            // 
            // bPrint
            // 
            this.bPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bPrint.Image = ((System.Drawing.Image)(resources.GetObject("bPrint.Image")));
            this.bPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(29, 24);
            this.bPrint.Text = "&Print";
            this.bPrint.Click += new System.EventHandler(this.OnPrint);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bCut
            // 
            this.bCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bCut.Image = ((System.Drawing.Image)(resources.GetObject("bCut.Image")));
            this.bCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bCut.Name = "bCut";
            this.bCut.Size = new System.Drawing.Size(29, 24);
            this.bCut.Text = "C&ut";
            this.bCut.Click += new System.EventHandler(this.OnCut);
            // 
            // bCopy
            // 
            this.bCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bCopy.Image = ((System.Drawing.Image)(resources.GetObject("bCopy.Image")));
            this.bCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(29, 24);
            this.bCopy.Text = "&Copy";
            this.bCopy.Click += new System.EventHandler(this.OnCopy);
            // 
            // bPaste
            // 
            this.bPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bPaste.Image = ((System.Drawing.Image)(resources.GetObject("bPaste.Image")));
            this.bPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bPaste.Name = "bPaste";
            this.bPaste.Size = new System.Drawing.Size(29, 24);
            this.bPaste.Text = "&Paste";
            this.bPaste.Click += new System.EventHandler(this.OnPaste);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bUndo
            // 
            this.bUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bUndo.Image = ((System.Drawing.Image)(resources.GetObject("bUndo.Image")));
            this.bUndo.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bUndo.Name = "bUndo";
            this.bUndo.Size = new System.Drawing.Size(29, 24);
            this.bUndo.Text = "Undo";
            this.bUndo.ToolTipText = "Undo";
            this.bUndo.Click += new System.EventHandler(this.OnUndo);
            // 
            // bRedo
            // 
            this.bRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bRedo.Image = ((System.Drawing.Image)(resources.GetObject("bRedo.Image")));
            this.bRedo.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bRedo.Name = "bRedo";
            this.bRedo.Size = new System.Drawing.Size(29, 24);
            this.bRedo.Text = "Redo";
            this.bRedo.ToolTipText = "Redo";
            this.bRedo.Click += new System.EventHandler(this.OnRedo);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // cbScale
            // 
            this.cbScale.AutoSize = false;
            this.cbScale.Items.AddRange(new object[] {
            "500%",
            "200%",
            "150%",
            "100%",
            "75%",
            "50%",
            "25%",
            "10%"});
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(70, 23);
            this.cbScale.ToolTipText = "Zoom";
            this.cbScale.SelectedIndexChanged += new System.EventHandler(this.OnScaleChanged);
            this.cbScale.Leave += new System.EventHandler(this.OnScaleChanged);
            this.cbScale.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnScaleKeyUp);
            // 
            // toolStripFormat
            // 
            this.toolStripFormat.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripFormat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbFontFamily,
            this.cbFontSize,
            this.bFont,
            this.bWordWrap,
            this.toolStripSeparator8,
            this.bCopyFormat,
            this.toolStripSeparator5,
            this.bAlignLeft,
            this.bAlignCenter,
            this.bAlignRight,
            this.toolStripSeparator2,
            this.bBold,
            this.bUnderline,
            this.bItalic,
            this.toolStripSeparator9,
            this.bSuperScript,
            this.bSubScript,
            this.toolStripSeparator7,
            this.bBullets,
            this.toolStripSeparator6,
            this.bBackColor,
            this.bTextColor,
            this.bSymbols});
            this.toolStripFormat.Location = new System.Drawing.Point(4, 0);
            this.toolStripFormat.Name = "toolStripFormat";
            this.toolStripFormat.Size = new System.Drawing.Size(723, 28);
            this.toolStripFormat.TabIndex = 1;
            this.toolStripFormat.Text = "toolStrip1";
            // 
            // cbFontFamily
            // 
            this.cbFontFamily.AutoToolTip = true;
            this.cbFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontFamily.DropDownWidth = 200;
            this.cbFontFamily.Name = "cbFontFamily";
            this.cbFontFamily.Size = new System.Drawing.Size(121, 28);
            this.cbFontFamily.Sorted = true;
            this.cbFontFamily.ToolTipText = "Font family";
            this.cbFontFamily.DropDownClosed += new System.EventHandler(this.OnFontsListClosed);
            this.cbFontFamily.SelectedIndexChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // cbFontSize
            // 
            this.cbFontSize.AutoSize = false;
            this.cbFontSize.DropDownWidth = 50;
            this.cbFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(50, 28);
            this.cbFontSize.ToolTipText = "Font size";
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.OnFontSizeChanged);
            this.cbFontSize.Leave += new System.EventHandler(this.OnFontSizeChanged);
            this.cbFontSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnFontSizeKeyUp);
            // 
            // bFont
            // 
            this.bFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bFont.Image = ((System.Drawing.Image)(resources.GetObject("bFont.Image")));
            this.bFont.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bFont.Name = "bFont";
            this.bFont.Size = new System.Drawing.Size(29, 25);
            this.bFont.Text = "Font";
            this.bFont.Click += new System.EventHandler(this.OnFontSelect);
            // 
            // bWordWrap
            // 
            this.bWordWrap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bWordWrap.Image = ((System.Drawing.Image)(resources.GetObject("bWordWrap.Image")));
            this.bWordWrap.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bWordWrap.Name = "bWordWrap";
            this.bWordWrap.Size = new System.Drawing.Size(29, 25);
            this.bWordWrap.Text = "Words wrap";
            this.bWordWrap.Click += new System.EventHandler(this.OnWordsWrapChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 28);
            // 
            // bCopyFormat
            // 
            this.bCopyFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bCopyFormat.Image = ((System.Drawing.Image)(resources.GetObject("bCopyFormat.Image")));
            this.bCopyFormat.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bCopyFormat.Name = "bCopyFormat";
            this.bCopyFormat.Size = new System.Drawing.Size(29, 25);
            this.bCopyFormat.Text = "Copy format";
            this.bCopyFormat.Click += new System.EventHandler(this.OnCopyFormat);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // bAlignLeft
            // 
            this.bAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("bAlignLeft.Image")));
            this.bAlignLeft.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bAlignLeft.Name = "bAlignLeft";
            this.bAlignLeft.Size = new System.Drawing.Size(29, 25);
            this.bAlignLeft.Text = "Align left";
            this.bAlignLeft.Click += new System.EventHandler(this.OnAlignLeft);
            // 
            // bAlignCenter
            // 
            this.bAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("bAlignCenter.Image")));
            this.bAlignCenter.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bAlignCenter.Name = "bAlignCenter";
            this.bAlignCenter.Size = new System.Drawing.Size(29, 25);
            this.bAlignCenter.Text = "Align center";
            this.bAlignCenter.Click += new System.EventHandler(this.OnAlignCenter);
            // 
            // bAlignRight
            // 
            this.bAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("bAlignRight.Image")));
            this.bAlignRight.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bAlignRight.Name = "bAlignRight";
            this.bAlignRight.Size = new System.Drawing.Size(29, 25);
            this.bAlignRight.Text = "Align right";
            this.bAlignRight.Click += new System.EventHandler(this.OnAlignRight);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // bBold
            // 
            this.bBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bBold.Image = ((System.Drawing.Image)(resources.GetObject("bBold.Image")));
            this.bBold.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bBold.Name = "bBold";
            this.bBold.Size = new System.Drawing.Size(29, 25);
            this.bBold.Text = "Bold";
            this.bBold.Click += new System.EventHandler(this.OnBold);
            // 
            // bUnderline
            // 
            this.bUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bUnderline.Image = ((System.Drawing.Image)(resources.GetObject("bUnderline.Image")));
            this.bUnderline.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bUnderline.Name = "bUnderline";
            this.bUnderline.Size = new System.Drawing.Size(29, 25);
            this.bUnderline.Text = "Underline";
            this.bUnderline.Click += new System.EventHandler(this.OnUnderline);
            // 
            // bItalic
            // 
            this.bItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bItalic.Image = ((System.Drawing.Image)(resources.GetObject("bItalic.Image")));
            this.bItalic.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bItalic.Name = "bItalic";
            this.bItalic.Size = new System.Drawing.Size(29, 25);
            this.bItalic.Text = "Italic";
            this.bItalic.Click += new System.EventHandler(this.OnItalic);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 28);
            // 
            // bSuperScript
            // 
            this.bSuperScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSuperScript.Image = ((System.Drawing.Image)(resources.GetObject("bSuperScript.Image")));
            this.bSuperScript.ImageTransparentColor = System.Drawing.Color.White;
            this.bSuperScript.Name = "bSuperScript";
            this.bSuperScript.Size = new System.Drawing.Size(29, 25);
            this.bSuperScript.Text = "Superscript";
            this.bSuperScript.Click += new System.EventHandler(this.OnSuperScript);
            // 
            // bSubScript
            // 
            this.bSubScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSubScript.Image = ((System.Drawing.Image)(resources.GetObject("bSubScript.Image")));
            this.bSubScript.ImageTransparentColor = System.Drawing.Color.White;
            this.bSubScript.Name = "bSubScript";
            this.bSubScript.Size = new System.Drawing.Size(29, 25);
            this.bSubScript.Text = "toolStripButton1";
            this.bSubScript.ToolTipText = "Subscript";
            this.bSubScript.Click += new System.EventHandler(this.OnSubScript);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // bBullets
            // 
            this.bBullets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bBullets.Image = ((System.Drawing.Image)(resources.GetObject("bBullets.Image")));
            this.bBullets.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bBullets.Name = "bBullets";
            this.bBullets.Size = new System.Drawing.Size(29, 25);
            this.bBullets.Text = "Bullets list";
            this.bBullets.Click += new System.EventHandler(this.OnBulletsList);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // bBackColor
            // 
            this.bBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bBackColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miChooseBackgroundColor});
            this.bBackColor.Image = ((System.Drawing.Image)(resources.GetObject("bBackColor.Image")));
            this.bBackColor.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bBackColor.Name = "bBackColor";
            this.bBackColor.Size = new System.Drawing.Size(39, 25);
            this.bBackColor.Text = "Background color";
            this.bBackColor.ButtonClick += new System.EventHandler(this.OnSetBackColor);
            // 
            // miChooseBackgroundColor
            // 
            this.miChooseBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miChooseBackgroundColor.Name = "miChooseBackgroundColor";
            this.miChooseBackgroundColor.Size = new System.Drawing.Size(188, 26);
            this.miChooseBackgroundColor.Text = "Choose color...";
            this.miChooseBackgroundColor.ToolTipText = "Choose background color";
            this.miChooseBackgroundColor.Click += new System.EventHandler(this.OnChooseBackgroundColor);
            // 
            // bTextColor
            // 
            this.bTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bTextColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miChooseTextColor});
            this.bTextColor.Image = ((System.Drawing.Image)(resources.GetObject("bTextColor.Image")));
            this.bTextColor.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bTextColor.Name = "bTextColor";
            this.bTextColor.Size = new System.Drawing.Size(39, 25);
            this.bTextColor.Text = "Text color";
            this.bTextColor.ButtonClick += new System.EventHandler(this.OnSetTextColor);
            // 
            // miChooseTextColor
            // 
            this.miChooseTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miChooseTextColor.Name = "miChooseTextColor";
            this.miChooseTextColor.Size = new System.Drawing.Size(188, 26);
            this.miChooseTextColor.Text = "Choose color...";
            this.miChooseTextColor.ToolTipText = "Choose text color";
            this.miChooseTextColor.Click += new System.EventHandler(this.OnChooseTextColor);
            // 
            // bSymbols
            // 
            this.bSymbols.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSymbols.Image = ((System.Drawing.Image)(resources.GetObject("bSymbols.Image")));
            this.bSymbols.ImageTransparentColor = System.Drawing.Color.Silver;
            this.bSymbols.Name = "bSymbols";
            this.bSymbols.Size = new System.Drawing.Size(34, 25);
            this.bSymbols.Text = "Insert symbols...";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.OnTimer);
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.SystemColors.ControlText;
            this.fontDialog.FontMustExist = true;
            this.fontDialog.ShowEffects = false;
            // 
            // RTFEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RTFEditor";
            this.Size = new System.Drawing.Size(824, 444);
            this.Load += new System.EventHandler(this.OnLoad);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStripCommon.ResumeLayout(false);
            this.toolStripCommon.PerformLayout();
            this.toolStripFormat.ResumeLayout(false);
            this.toolStripFormat.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.ToolStripButton bPrint;
		private System.Windows.Forms.ToolStripButton bCut;
		private System.Windows.Forms.ToolStripButton bCopy;
		private System.Windows.Forms.ToolStripButton bPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton bRedo;
		private System.Windows.Forms.ToolStripButton bUndo;
		private System.Windows.Forms.Timer timer;
		protected System.Windows.Forms.ToolStrip toolStripCommon;
		protected System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.FontDialog fontDialog;
		private System.Windows.Forms.ToolStripComboBox cbScale;
		private System.Windows.Forms.ToolStrip toolStripFormat;
		private System.Windows.Forms.ToolStripComboBox cbFontFamily;
		private System.Windows.Forms.ToolStripComboBox cbFontSize;
		private System.Windows.Forms.ToolStripButton bFont;
		private System.Windows.Forms.ToolStripButton bWordWrap;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton bAlignLeft;
		private System.Windows.Forms.ToolStripButton bAlignCenter;
		private System.Windows.Forms.ToolStripButton bAlignRight;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton bBold;
		private System.Windows.Forms.ToolStripButton bUnderline;
		private System.Windows.Forms.ToolStripButton bItalic;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripSplitButton bBackColor;
		private System.Windows.Forms.ToolStripMenuItem miChooseBackgroundColor;
		private System.Windows.Forms.ToolStripSplitButton bTextColor;
		private System.Windows.Forms.ToolStripMenuItem miChooseTextColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton bBullets;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton bCopyFormat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton bSuperScript;
        private System.Windows.Forms.ToolStripButton bSubScript;
        private System.Windows.Forms.ToolStripDropDownButton bSymbols;
	}
}
