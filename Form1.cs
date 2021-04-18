using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyDirectory.Service;
using System.IO;

namespace CopyDirectory
{


    public partial class CopyDirectory : Form
    {
        public CopyDirectory()
        {
            InitializeComponent();
            
        }

        public string SourceFolder { get; set; }
        public string TargetFolder { get; set; }
        public int SourceFileFolderCount { get; set; }


        private void SelectSourceDirectoryButton_Click(object sender, EventArgs e)
        {
            if (SourceFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SourceFolder = SourceFolderBrowserDialog.SelectedPath;
            }
        }

        private void SelectTargetDirectoryButton_Click(object sender, EventArgs e)
        {
            if (TargetFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TargetFolder = TargetFolderBrowserDialog.SelectedPath;
            }
        }

        private void StartCopyDirectory_Click(object sender, EventArgs e)
        {

            int sourceCount = Directory.GetFiles(SourceFolder, "*.*", SearchOption.AllDirectories).Length;
            SourceFileFolderCount = sourceCount;
            FileTransferProgressBar.Maximum = sourceCount;

            CopyDirectoryService copyDirectory = new(SourceFolder, TargetFolder);
            copyDirectory.FileTransferEvent += CopyDirectory_FileTransferEvent;

            var result = copyDirectory.StartCopy();

        }

        //update the text box with the new list of copied files and folders
        private void CopyDirectory_FileTransferEvent(object sender, Observer.FileTranserInfo e)
        {
            //copy the contents of the text boxes
            string currentToCopyTextBox = FilesToCopyTextBox.Text;
            string currentFilesCopiedTextBox = FilesCopiedTextBox.Text;
                        
            FilesCopiedTextBox.Text = currentToCopyTextBox + Environment.NewLine;
            FilesCopiedTextBox.Text = currentFilesCopiedTextBox + Environment.NewLine;

            //calulate percentage, update percentage label

            int currentPercentage = (SourceFileFolderCount / 100) * e.CopiedCount;
            FileTransferProgressBar.Value = e.CopiedCount;

        }





    }
}
