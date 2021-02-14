using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.LinksSupport
{
    public partial class FileOperations : Form
    {
        /// <summary>
        /// Gets or sets attached file.
        /// </summary>
        public AttachedFile File { get; set; }

        /// <summary>
        /// Initializes the form.
        /// </summary>
        public FileOperations()
        {
            InitializeComponent();
        }

        private void OnSave(object sender, EventArgs e)
        {
            byte[] content = File.FileContent.Content;

            if ((content != null) && (content.Length > 0))
            {
                saveFileDialog.FileName = File.FileName;
                var extension = Path.GetExtension(File.FileName);
                saveFileDialog.DefaultExt = extension;
                saveFileDialog.Filter = extension + "|*" + extension;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(content, 0, content.Length);
                    }
                }
            }

            Close();

        }

        private void OnOpen(object sender, EventArgs e)
        {
            byte[] content = File.FileContent.Content;

            if ((content != null) && (content.Length > 0))
            {
                var fileName = Path.GetTempFileName();
                fileName = Path.ChangeExtension(fileName, Path.GetExtension(File.FileName));

                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(content, 0, content.Length);
                }

                var process = new Process();
                process.StartInfo = new ProcessStartInfo(fileName);
                process.EnableRaisingEvents = true;
                process.Exited += (s, a) =>
                {
                    try
                    {
                        System.IO.File.Delete(fileName);
                    }
                    catch
                    { }
                };
                process.Start();
            }

            Close();
        }
    }
}
