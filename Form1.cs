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

        private readonly BackgroundWorker backgroundWorkerCopyDirectory;
        private readonly CopyDirectoryService copyDirectory = new();


        public string SourceFolder { get; set; }
        public string TargetFolder { get; set; }
        public int SourceFileFolderCount { get; set; }


        public CopyDirectory()
        {
            InitializeComponent();
            copyDirectory.OnFileTransferProgressUpdate += CopyDirectory_OnFileTransferProgressUpdate;
            backgroundWorkerCopyDirectory = new();
            backgroundWorkerCopyDirectory.WorkerReportsProgress = true;
            backgroundWorkerCopyDirectory.DoWork += BackgroundWorkerCopyDirectory_DoWork; 
            backgroundWorkerCopyDirectory.RunWorkerCompleted += BackgroundWorkerCopyDirectory_RunWorkerCompleted;
        }

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

            //I have to get a count of how many files are there to transfer

            SourceFileFolderCount = Directory.GetFiles(SourceFolder, "*.*", SearchOption.AllDirectories).Length;
            //Clear UI
            ProgressPercentLabel.Text = "0%";
            FileTransferProgressBar.Value = 0;
            FileTransferProgressBar.Maximum = SourceFileFolderCount;
            FilesToCopyTextBox.Text = null;
            FilesCopiedTextBox.Text = null;

            SelectSourceDirectoryButton.Enabled = false;
            SelectTargetDirectoryButton.Enabled = false;
            backgroundWorkerCopyDirectory.RunWorkerAsync();

            while(backgroundWorkerCopyDirectory.IsBusy)
            {
                Application.DoEvents();
            }

        }
        


        private void CopyDirectory_OnFileTransferProgressUpdate(string sourceFile, string copiedFile, int scourceCount, int targetCount)
        {
            
            base.Invoke((Action)delegate {
                //copy the contents of the text boxes
                string currentToCopyTextBox = FilesToCopyTextBox.Text;
                string currentFilesCopiedTextBox = FilesCopiedTextBox.Text;

                FilesToCopyTextBox.Text = currentToCopyTextBox + sourceFile + Environment.NewLine;
                FilesCopiedTextBox.Text = currentFilesCopiedTextBox + copiedFile + Environment.NewLine;

                //calulate percentage, update percentage label

                
                FileTransferProgressBar.Value = targetCount;
                float currentPercentage =  targetCount / scourceCount * 100 ;
                ProgressPercentLabel.Text = currentPercentage + "%";
            });

        }

        private void BackgroundWorkerCopyDirectory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error == null)
            {
                MessageBox.Show("It worked");
            }
            else
            {
                MessageBox.Show("It fucking failed!!!!!");
            }

            SelectSourceDirectoryButton.Enabled = true;
            SelectTargetDirectoryButton.Enabled = true;
        }

        private void BackgroundWorkerCopyDirectory_DoWork(object sender, DoWorkEventArgs e)
        {
           
            try
            {
                copyDirectory.StartCopy(SourceFolder, TargetFolder);
            } 
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
