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

            CopyDirectoryService copyDirectory = new(SourceFolder, TargetFolder);
            copyDirectory.FileTransferEvent += CopyDirectory_FileTransferEvent;

            var result = copyDirectory.StartCopy();




        }

        //update the text box with the new list of copied files and folders
        private void CopyDirectory_FileTransferEvent(object sender, string[] e)
        {   
            //clear the current text box and the new files
            FilesCopiedTextBox.Text = null;

            foreach(string line in e)
            {
                FilesCopiedTextBox.Text += line + Environment.NewLine;
            }

            FilesCopiedTextBox.Text += "All Files transffered!" + Environment.NewLine;
        }
    }
}
