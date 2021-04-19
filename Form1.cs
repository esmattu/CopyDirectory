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

        private BackgroundWorker backgroundworkerCopyDirectory;
        
        
        public CopyDirectory()
        {
            InitializeComponent();
            backgroundworkerCopyDirectory = new BackgroundWorker();
            backgroundworkerCopyDirectory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCopyDirectory_DoWork);
            backgroundworkerCopyDirectory.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCopyDirectory_RunWorkerCompleted);


            
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

            //Clear UI
            ProgressPercentLabel.Text = "0%";
            FileTransferProgressBar.Value = 0;
            FilesToCopyTextBox.Text = null;
            FilesCopiedTextBox.Text = null;

            //run copyDirectory service as background task.



        }

        //update the text box with the new list of copied files and folders
        private void CopyDirectory_FileTransferEvent(object sender, Observer.FileTranserInfo e)
        {
            //copy the contents of the text boxes
            string currentToCopyTextBox = FilesToCopyTextBox.Text;
            string currentFilesCopiedTextBox = FilesCopiedTextBox.Text;

            FilesToCopyTextBox.Text = currentToCopyTextBox+ e.FileToCopy + Environment.NewLine;
            FilesCopiedTextBox.Text = currentFilesCopiedTextBox + e.FileCopied+ Environment.NewLine;

            //calulate percentage, update percentage label

            float currentPercentage = (e.SourceCount / e.CopiedCount) * 100 ;
            FileTransferProgressBar.Value = e.CopiedCount;
            
            ProgressPercentLabel.Text = currentPercentage+"%";
            
        }

        private void backgroundWorkerCopyDirectory_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyDirectoryService copyDirectory = new(SourceFolder, TargetFolder);
            copyDirectory.FileTransferEvent += CopyDirectory_FileTransferEvent;


            var result = copyDirectory.StartCopy();
        }


        private void backgroundWorkerCopyDirectory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
