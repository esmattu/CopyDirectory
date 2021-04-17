
namespace CopyDirectory
{
    partial class CopyDirectory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CopyProgressLabel = new System.Windows.Forms.Label();
            this.SelectTargetDirectoryButton = new System.Windows.Forms.Button();
            this.SelectSourceDirectoryButton = new System.Windows.Forms.Button();
            this.FileCopyProgessBar = new System.Windows.Forms.ProgressBar();
            this.SourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TargetFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.StartCopyDirectory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StartCopyDirectory);
            this.panel1.Controls.Add(this.CopyProgressLabel);
            this.panel1.Controls.Add(this.SelectTargetDirectoryButton);
            this.panel1.Controls.Add(this.SelectSourceDirectoryButton);
            this.panel1.Controls.Add(this.FileCopyProgessBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 557);
            this.panel1.TabIndex = 0;
            // 
            // CopyProgressLabel
            // 
            this.CopyProgressLabel.AutoSize = true;
            this.CopyProgressLabel.Location = new System.Drawing.Point(12, 377);
            this.CopyProgressLabel.Name = "CopyProgressLabel";
            this.CopyProgressLabel.Size = new System.Drawing.Size(179, 21);
            this.CopyProgressLabel.TabIndex = 3;
            this.CopyProgressLabel.Text = "Copy Directory Progress";
            // 
            // SelectTargetDirectoryButton
            // 
            this.SelectTargetDirectoryButton.Location = new System.Drawing.Point(197, 244);
            this.SelectTargetDirectoryButton.Name = "SelectTargetDirectoryButton";
            this.SelectTargetDirectoryButton.Size = new System.Drawing.Size(184, 47);
            this.SelectTargetDirectoryButton.TabIndex = 2;
            this.SelectTargetDirectoryButton.Text = "Select Tartget Directory";
            this.SelectTargetDirectoryButton.UseVisualStyleBackColor = true;
            this.SelectTargetDirectoryButton.Click += new System.EventHandler(this.SelectTargetDirectoryButton_Click);
            // 
            // SelectSourceDirectoryButton
            // 
            this.SelectSourceDirectoryButton.Location = new System.Drawing.Point(12, 244);
            this.SelectSourceDirectoryButton.Name = "SelectSourceDirectoryButton";
            this.SelectSourceDirectoryButton.Size = new System.Drawing.Size(179, 47);
            this.SelectSourceDirectoryButton.TabIndex = 1;
            this.SelectSourceDirectoryButton.Text = "Select Source Directory";
            this.SelectSourceDirectoryButton.UseVisualStyleBackColor = true;
            this.SelectSourceDirectoryButton.Click += new System.EventHandler(this.SelectSourceDirectoryButton_Click);
            // 
            // FileCopyProgessBar
            // 
            this.FileCopyProgessBar.Location = new System.Drawing.Point(12, 328);
            this.FileCopyProgessBar.Name = "FileCopyProgessBar";
            this.FileCopyProgessBar.Size = new System.Drawing.Size(756, 46);
            this.FileCopyProgessBar.TabIndex = 0;
            // 
            // StartCopyDirectory
            // 
            this.StartCopyDirectory.Location = new System.Drawing.Point(577, 245);
            this.StartCopyDirectory.Name = "StartCopyDirectory";
            this.StartCopyDirectory.Size = new System.Drawing.Size(191, 46);
            this.StartCopyDirectory.TabIndex = 4;
            this.StartCopyDirectory.Text = "Start Copy Process";
            this.StartCopyDirectory.UseVisualStyleBackColor = true;
            this.StartCopyDirectory.Click += new System.EventHandler(this.StartCopyDirectory_Click);
            // 
            // CopyDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CopyDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopyDirectory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CopyProgressLabel;
        private System.Windows.Forms.Button SelectTargetDirectoryButton;
        private System.Windows.Forms.Button SelectSourceDirectoryButton;
        private System.Windows.Forms.ProgressBar FileCopyProgessBar;
        private System.Windows.Forms.FolderBrowserDialog SourceFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog TargetFolderBrowserDialog;
        private System.Windows.Forms.Button StartCopyDirectory;
    }
}

