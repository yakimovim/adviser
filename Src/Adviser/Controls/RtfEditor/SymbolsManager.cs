using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EdlinSoftware.Controls.WinForms
{
    internal class SymbolsManager
    {
        private readonly static char[] MathSymbols = { '\x00B1', '\x00D7', '\x00F7', '\x2200', '\x2202', '\x2203', '\x2205', '\x2206', 
            '\x2208', '\x2209', '\x220F', '\x2211', '\x2219', '\x221A', '\x221E', '\x2229', '\x222B', '\x2248', '\x2260', '\x2264', 
            '\x2265', '\x2282', '\x2286', '\x22A2', '\x22A5' };
        private readonly static char[] LowerGreekSymbols = Enumerable.Range(0, 25).Select(i => (char)((int)('\x03B1') + i)).ToArray();
        private readonly static char[] UpperGreekSymbols = Enumerable.Range(0, 25).Select(i => (char)((int)('\x0391') + i)).ToArray();

        private readonly RichTextBox _richTextBox;
        private bool _hasUnicodeFont;
        private FontFamily _unicodeFont;

        [DebuggerStepThrough]
        public SymbolsManager(RichTextBox richTextBox)
        {
            if (richTextBox == null) throw new ArgumentNullException("richTextBox");
            _richTextBox = richTextBox;

            SetUnicodeFont();
        }

        private void SetUnicodeFont()
        {
            var unicodeFonts = FontFamily.Families
                .Where(f => f.Name.IndexOf("Unicode", StringComparison.InvariantCultureIgnoreCase) >= 0)
                .ToList();

            _hasUnicodeFont = unicodeFonts.Any();
            _unicodeFont = unicodeFonts.FirstOrDefault(f => f.Name.Equals("Arial Unicode MS", StringComparison.InvariantCultureIgnoreCase))
                ?? unicodeFonts[0];
        }

        public void CreateSymbolsMenu(ToolStripDropDownButton symbolsItem)
        {
            AddMenu(symbolsItem, "Math symbols...", MathSymbols);
            AddMenu(symbolsItem, "Lower Greek symbols...", LowerGreekSymbols);
            AddMenu(symbolsItem, "Upper Greek symbols...", UpperGreekSymbols);
        }

        private void AddMenu(ToolStripDropDownButton symbolsItem, string title, IEnumerable<char> symbols)
        {
            var dropDown = new ToolStripDropDownButton(title);
            var emSize = dropDown.Font.Size;

            foreach (var symbol in symbols)
            {
                var textOfSymbol = new string(symbol, 1);
                var item = new ToolStripMenuItem(textOfSymbol) 
                {
                    Font = new Font(_unicodeFont, emSize)
                };
                item.Click += (sender, args) => InsertSymbol(textOfSymbol);
                dropDown.DropDownItems.Add(item);
            }

            symbolsItem.DropDownItems.Add(dropDown);
        }

        private void InsertSymbol(string textOfSymbol)
        {
            Font selFont = _richTextBox.SelectionFont;
            Font newFont = new Font(_unicodeFont, selFont.Size, selFont.Style);
            _richTextBox.SelectionFont = newFont;
            _richTextBox.SelectedText = textOfSymbol;
            _richTextBox.SelectionFont = selFont;
            _richTextBox.SelectedText = string.Empty;
        }
    }
}
