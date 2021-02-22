//------------------------------------------------------------------------------
// Copyright: (c) 2006/2007 Edlin Software, Russia
//------------------------------------------------------------------------------
// $Source$
// Unit:        Controls\Src\Controls\WinForms
// Author:      Ivan_Yakimov
// Responsible: Ivan_Yakimov
//------------------------------------------------------------------------------
// Description: Class of RTF-documents editor.
//------------------------------------------------------------------------------
// $Log$
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;

namespace EdlinSoftware.Controls.WinForms
{
    /// <summary>
    /// Class of RTF-documents editor.
    /// </summary>
    public partial class RTFEditor : UserControl
    {
        #region Classes
        /// <summary>
        /// Arguments of event with boolean parameter.
        /// </summary>
        [Serializable]
        protected class BoolEventArgs : EventArgs
        {
            #region Fields
            private bool m_BoolValue;
            #endregion

            #region Properties
            /// <summary>
            /// Boolean value.
            /// </summary>
            public bool BoolValue
            {
                get { return m_BoolValue; }
                set { m_BoolValue = value; }
            }
            #endregion
        }
        #endregion

        #region Fields
        private const double ScriptSizeChange = 1.5;

        private Color m_BackgroundColor = Color.White;
        private Color m_TextColor = Color.Black;

        // Fields for format copying.
        private static Font m_StoredFont = null;
        private static Color m_StoredForeColor = Color.Black;
        private static Color m_StoredBackColor = Color.White;
        #endregion

        #region Events
        protected static event EventHandler<BoolEventArgs> CopyFormatStateChanged;
        #endregion

        #region Properties
        /// <summary>
        /// Видимость общего тулбара.
        /// </summary>
        [DefaultValue(true)]
        [Category("Appearance")]
        [Browsable(true)]
        public virtual bool CommonToolbarVisible
        {
            get { return toolStripCommon.Visible; }
            set { toolStripCommon.Visible = value; }
        }

        /// <summary>
        /// Видимость тулбара для форматирования текста.
        /// </summary>
        [DefaultValue(true)]
        [Category("Appearance")]
        [Browsable(true)]
        public virtual bool FormatToolbarVisible
        {
            get { return toolStripFormat.Visible; }
            set { toolStripFormat.Visible = value; }
        }

        /// <summary>
        /// RTF-текст, введенный в редакторе.
        /// </summary>
        [Browsable(false)]
        public virtual string EditorRTF
        {
            get { return richTextBox.Rtf; }
            set
            {
                var zoom = richTextBox.ZoomFactor;
                richTextBox.Rtf = value;
                richTextBox.ZoomFactor = zoom;
            }
        }

        /// <summary>
        /// Текст, введенный в редакторе.
        /// </summary>
        [DefaultValue("")]
        [Category("Appearance")]
        [Browsable(true)]
        public virtual string EditorText
        {
            get { return richTextBox.Text; }
            set
            {
                var zoom = richTextBox.ZoomFactor;
                richTextBox.Text = value;
                richTextBox.ZoomFactor = zoom;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor.
        /// </summary>
        public RTFEditor()
        {
            InitializeComponent();

            CopyFormatStateChanged += OnCopyFormatStateChanged;

            InitializeSymbolsToInsert();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Creates menu for inserting symbols.
        /// </summary>
        private void InitializeSymbolsToInsert()
        {
            var symbolsManager = new SymbolsManager(richTextBox);
            symbolsManager.CreateSymbolsMenu(bSymbols);
        }

        /// <summary>
        /// Sets state of controls.
        /// </summary>
        protected virtual void SetControlsState()
        {
            bPrint.Enabled = true;
            bCopy.Enabled = (richTextBox.SelectedText.Length > 0);
            bCut.Enabled = (richTextBox.SelectedText.Length > 0);
            bPaste.Enabled = (Clipboard.ContainsText());

            bAlignLeft.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Left);
            bAlignCenter.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Center);
            bAlignRight.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Right);

            Font selFont = richTextBox.SelectionFont;
            if (selFont != null)
            {
                bBold.Checked = selFont.Bold;
                bUnderline.Checked = selFont.Underline;
                bItalic.Checked = selFont.Italic;

                cbFontSize.Text = selFont.Size.ToString(CultureInfo.InvariantCulture);
                cbFontFamily.SelectedItem = selFont.FontFamily.Name;
            }

            bSuperScript.Checked = richTextBox.SelectionCharOffset > 0;
            bSubScript.Checked = richTextBox.SelectionCharOffset < 0;

            bBullets.Checked = richTextBox.SelectionBullet;

            bUndo.Enabled = richTextBox.CanUndo;
            bRedo.Enabled = richTextBox.CanRedo;

            bWordWrap.Checked = richTextBox.WordWrap;

            cbScale.Text = (richTextBox.ZoomFactor * 100.0f).ToString("0.##") + @"%";
        }

        #region Методы работы с цветами
        /// <summary>
        /// Изменяет выбранный цвет фона.
        /// </summary>
        private void ChangeBackgroundColor()
        {
            try
            {
                using (Graphics g = Graphics.FromImage(bBackColor.Image))
                {
                    using (Brush br = new SolidBrush(m_BackgroundColor))
                    {
                        g.FillRectangle(br, 3, 15, 16, 4);
                    }
                }
                bBackColor.Invalidate();
            }
            catch { }
        }

        /// <summary>
        /// Изменяет выбранный цвет текста.
        /// </summary>
        private void ChangeTextColor()
        {
            try
            {
                using (Graphics g = Graphics.FromImage(bTextColor.Image))
                {
                    Brush br = new SolidBrush(m_TextColor);
                    g.FillRectangle(br, 2, 15, 16, 4);
                }
                bTextColor.Invalidate();
            }
            catch { }
        }
        #endregion

        #region Методы работы со шрифтами
        /// <summary>
        /// Устанавливает размер шрифта.
        /// </summary>
        /// <param name="size">Размер шрифта.</param>
        protected virtual void SetFontSize(float size)
        {
            Font selFont = richTextBox.SelectionFont;
            Font newFont = new Font(selFont.FontFamily, size, selFont.Style);
            richTextBox.SelectionFont = newFont;
        }

        /// <summary>
        /// Заполняет список доступных шрифтов.
        /// </summary>
        protected virtual void FillListOfFonts()
        {
            cbFontFamily.Items.Clear();
            foreach (FontFamily family in FontFamily.Families)
            {
                if (family.IsStyleAvailable(FontStyle.Regular))
                    cbFontFamily.Items.Add(family.Name);
            }
        }
        #endregion

        /// <summary>
        /// Sets default state of all controls.
        /// </summary>
        private void ResetControlState()
        {
            FillListOfFonts();
            ChangeBackgroundColor();
            ChangeTextColor();
            SetControlsState();
        }

        /// <summary>
        /// Handles changing of copy format state.
        /// </summary>
        private void OnCopyFormatStateChanged(object sender, BoolEventArgs e)
        {
            bCopyFormat.Checked = e.BoolValue;
        }

        /// <summary>
        /// Raises event of changing copy format state.
        /// </summary>
        /// <param name="boolValue">Is there a data for format copying.</param>
        protected virtual void RaiseCopyFormatChangedEvent(bool boolValue)
        {
            if (CopyFormatStateChanged != null)
            {
                BoolEventArgs e = new BoolEventArgs();
                e.BoolValue = boolValue;
                CopyFormatStateChanged(this, e);
            }
        }
        #endregion

        #region Event handlers
        /// <summary>
        /// Таймер контроля за Clipboard.
        /// </summary>
        private void OnTimer(object sender, EventArgs e)
        {
            bUndo.Enabled = richTextBox.CanUndo;
            bRedo.Enabled = richTextBox.CanRedo;
            bPaste.Enabled = (Clipboard.ContainsText());
        }

        /// <summary>
        /// Handles of this control loading.
        /// </summary>
        private void OnLoad(object sender, EventArgs e)
        {
            ResetControlState();
        }

        /// <summary>
        /// Handles text change.
        /// </summary>
        private void OnTextChanged(object sender, EventArgs e)
        {
            SetControlsState();
        }

        /// <summary>
        /// Контролирует изменение выделенного текста.
        /// </summary>
        private void OnSelectionChanged(object sender, EventArgs e)
        {
            SetControlsState();
        }

        /// <summary>
        /// Вырезает текст.
        /// </summary>
        private void OnCut(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        /// <summary>
        /// Копирует текст.
        /// </summary>
        private void OnCopy(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        /// <summary>
        /// Вставляет текст.
        /// </summary>
        private void OnPaste(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox.SelectedRtf
                    = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }

        /// <summary>
        /// Отменяет изменение.
        /// </summary>
        private void OnUndo(object sender, EventArgs e)
        {
            if (richTextBox.CanUndo)
                richTextBox.Undo();
            bUndo.Enabled = richTextBox.CanUndo;
        }

        /// <summary>
        /// Повторяет изменение.
        /// </summary>
        private void OnRedo(object sender, EventArgs e)
        {
            if (richTextBox.CanRedo)
                richTextBox.Redo();
            bRedo.Enabled = richTextBox.CanRedo;
        }

        /// <summary>
        /// Выравнивает параграф по левому краю.
        /// </summary>
        private void OnAlignLeft(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            bAlignLeft.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Left);
            bAlignCenter.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Center);
            bAlignRight.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Right);
        }

        /// <summary>
        /// Выравнивает параграф по центру.
        /// </summary>
        private void OnAlignCenter(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            bAlignLeft.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Left);
            bAlignCenter.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Center);
            bAlignRight.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Right);
        }

        /// <summary>
        /// Выравнивает параграф по правому краю.
        /// </summary>
        private void OnAlignRight(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            bAlignLeft.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Left);
            bAlignCenter.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Center);
            bAlignRight.Checked = (richTextBox.SelectionAlignment == HorizontalAlignment.Right);
        }

        /// <summary>
        /// Делает шрифт жирным.
        /// </summary>
        private void OnBold(object sender, EventArgs e)
        {
            Font selFont = richTextBox.SelectionFont;
            FontStyle style = selFont.Style;
            if (!selFont.Bold)
                style |= FontStyle.Bold;
            else
                style &= ~FontStyle.Bold;

            richTextBox.SelectionFont = new Font(selFont, style);
            bBold.Checked = richTextBox.SelectionFont.Bold;
        }

        /// <summary>
        /// Делает шрифт наклонным.
        /// </summary>
        private void OnItalic(object sender, EventArgs e)
        {
            Font selFont = richTextBox.SelectionFont;
            FontStyle style = selFont.Style;
            if (!selFont.Italic)
                style |= FontStyle.Italic;
            else
                style &= ~FontStyle.Italic;

            richTextBox.SelectionFont = new Font(selFont, style);
            bItalic.Checked = richTextBox.SelectionFont.Italic;
        }

        /// <summary>
        /// Делает шрифт подчеркнутым.
        /// </summary>
        private void OnUnderline(object sender, EventArgs e)
        {
            Font selFont = richTextBox.SelectionFont;
            FontStyle style = selFont.Style;
            if (!selFont.Underline)
                style |= FontStyle.Underline;
            else
                style &= ~FontStyle.Underline;

            richTextBox.SelectionFont = new Font(selFont, style);
            bUnderline.Checked = richTextBox.SelectionFont.Underline;
        }

        /// <summary>
        /// Переводит текст в верхний скрипт.
        /// </summary>
        private void OnSuperScript(object sender, EventArgs e)
        {
            if (richTextBox.SelectionCharOffset < 0)
            {
                OnSubScript(sender, e);
            }

            var selFont = richTextBox.SelectionFont;

            if (richTextBox.SelectionCharOffset > 0)
            {
                var newFont = new Font(selFont.FontFamily, (float)(selFont.Size * ScriptSizeChange), selFont.Style);

                richTextBox.SelectionCharOffset = 0;
                richTextBox.SelectionFont = newFont;
                bSuperScript.Checked = false;
            }
            else
            {
                var newFont = new Font(selFont.FontFamily, (float)(selFont.Size / ScriptSizeChange), selFont.Style);

                var offset = selFont.GetHeight();

                richTextBox.SelectionCharOffset = (int)(offset * 0.5);
                richTextBox.SelectionFont = newFont;
                bSuperScript.Checked = true;
            }
        }

        /// <summary>
        /// Переводит текст в нижний скрипт.
        /// </summary>
        private void OnSubScript(object sender, EventArgs e)
        {
            if (richTextBox.SelectionCharOffset > 0)
            {
                OnSuperScript(sender, e);
            }

            var selFont = richTextBox.SelectionFont;

            if (richTextBox.SelectionCharOffset < 0)
            {
                var newFont = new Font(selFont.FontFamily, (float)(selFont.Size * ScriptSizeChange), selFont.Style);

                richTextBox.SelectionCharOffset = 0;
                richTextBox.SelectionFont = newFont;
                bSubScript.Checked = false;
            }
            else
            {
                var newFont = new Font(selFont.FontFamily, (float)(selFont.Size / ScriptSizeChange), selFont.Style);

                var offset = newFont.GetHeight();

                richTextBox.SelectionCharOffset = (int)(-offset * 0.5);
                richTextBox.SelectionFont = newFont;
                bSubScript.Checked = true;
            }
        }

        /// <summary>
        /// Выбирает цвет фона.
        /// </summary>
        private void OnChooseBackgroundColor(object sender, EventArgs e)
        {
            colorDialog.Color = m_BackgroundColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                m_BackgroundColor = colorDialog.Color;
                ChangeBackgroundColor();
            }
        }

        /// <summary>
        /// Выбирает цвет текста.
        /// </summary>
        private void OnChooseTextColor(object sender, EventArgs e)
        {
            colorDialog.Color = m_TextColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                m_TextColor = colorDialog.Color;
                ChangeTextColor();
            }
        }

        /// <summary>
        /// Устанавливает цвет фона.
        /// </summary>
        private void OnSetBackColor(object sender, EventArgs e)
        {
            richTextBox.SelectionBackColor = m_BackgroundColor;
        }

        /// <summary>
        /// Устанавливает цвет текста.
        /// </summary>
        private void OnSetTextColor(object sender, EventArgs e)
        {
            richTextBox.SelectionColor = m_TextColor;
        }

        /// <summary>
        /// Изменяет размер шрифта.
        /// </summary>
        private void OnFontSizeChanged(object sender, EventArgs e)
        {
            float size;
            if (float.TryParse(cbFontSize.Text, out size))
            { SetFontSize(size); }
            richTextBox.Focus();
        }

        /// <summary>
        /// Обработчик нажатия на кнопки в списке размеров шрифтов.
        /// </summary>
        private void OnFontSizeKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { richTextBox.Focus(); }
            else
            { base.OnKeyUp(e); }
        }

        /// <summary>
        /// Обработчик изменения шрифта.
        /// </summary>
        private void OnFontChanged(object sender, EventArgs e)
        {
            string fontFamilyName = cbFontFamily.Text;
            if (string.IsNullOrEmpty(fontFamilyName))
                return;
            FontFamily fontFamily = new FontFamily(fontFamilyName);
            Font selFont = richTextBox.SelectionFont;
            Font newFont = new Font(fontFamily, selFont.Size, selFont.Style);
            richTextBox.SelectionFont = newFont;
            richTextBox.Focus();
        }

        /// <summary>
        /// Обработчик закрытия списка шрифтов.
        /// </summary>
        private void OnFontsListClosed(object sender, EventArgs e)
        {
            richTextBox.Focus();
        }

        /// <summary>
        /// Открывает диалог выбора шрифта.
        /// </summary>
        private void OnFontSelect(object sender, EventArgs e)
        {
            fontDialog.Font = richTextBox.SelectionFont;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;
                SetControlsState();
            }
        }

        /// <summary>
        /// Обработчик изменения масштаба.
        /// </summary>
        private void OnScaleChanged(object sender, EventArgs e)
        {
            Single scale;
            if (Single.TryParse(cbScale.Text.TrimEnd('%'), out scale))
            {
                scale /= 100.0f;
                richTextBox.ZoomFactor = scale;
            }
            richTextBox.Focus();
        }

        /// <summary>
        /// Обработчик нажатия на кнопки в списке масштабов.
        /// </summary>
        private void OnScaleKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { richTextBox.Focus(); }
            else
            { base.OnKeyUp(e); }
        }

        /// <summary>
        /// Изменяет состояние переноса слов.
        /// </summary>
        private void OnWordsWrapChanged(object sender, EventArgs e)
        {
            float scale = richTextBox.ZoomFactor;
            richTextBox.WordWrap = !richTextBox.WordWrap;
            bWordWrap.Checked = richTextBox.WordWrap;
            richTextBox.ZoomFactor = scale;
            SetControlsState();
        }

        /// <summary>
        /// Печатает текст.
        /// </summary>
        private void OnPrint(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Устанавливает стиль списка.
        /// </summary>
        private void OnBulletsList(object sender, EventArgs e)
        {
            richTextBox.SelectionBullet = !richTextBox.SelectionBullet;
            bBullets.Checked = richTextBox.SelectionBullet;
        }

        /// <summary>
        /// Поддерживает управляющие сочетания клавиш.
        /// </summary>
        private void OnEditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.B) && bBold.Enabled)
            {
                OnBold(this, EventArgs.Empty);
                return;
            }
            if (e.Control && (e.KeyCode == Keys.K) && bItalic.Enabled)
            {
                OnItalic(this, EventArgs.Empty);
                return;
            }
            if (e.Control && (e.KeyCode == Keys.U) && bUnderline.Enabled)
            {
                OnUnderline(this, EventArgs.Empty);
                return;
            }
            if (e.Control && (e.KeyCode == Keys.Oemplus) && bSubScript.Enabled)
            {
                if (e.Shift)
                {
                    OnSuperScript(this, EventArgs.Empty);
                }
                else
                {
                    OnSubScript(this, EventArgs.Empty);
                }
                e.Handled = true;
            }
            if (e.Control && (e.KeyCode == Keys.V))
            {
                OnPaste(this, EventArgs.Empty);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles copying of format.
        /// </summary>
        private void OnCopyFormat(object sender, EventArgs e)
        {
            if (!bCopyFormat.Checked)
            {
                // Store format.
                m_StoredFont = richTextBox.SelectionFont;
                m_StoredForeColor = richTextBox.SelectionColor;
                m_StoredBackColor = richTextBox.SelectionBackColor;
            }
            else
            {
                // Copy format.
                if (m_StoredFont != null)
                {
                    richTextBox.SelectionFont = m_StoredFont;
                    richTextBox.SelectionColor = m_StoredForeColor;
                    richTextBox.SelectionBackColor = m_StoredBackColor;
                }
                m_StoredFont = null;
            }

            bCopyFormat.Checked = !bCopyFormat.Checked;
            RaiseCopyFormatChangedEvent(bCopyFormat.Checked);
        }

        /// <summary>
        /// Handles clicking on link.
        /// </summary>
        private void OnLinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (e == null)
                return;
            if (string.IsNullOrEmpty(e.LinkText))
                return;

            try
            { Process.Start(e.LinkText); }
            catch
            { }
        }
        #endregion
    }
}
