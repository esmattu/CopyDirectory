
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
            this.FileTransferProgressBar = new System.Windows.Forms.ProgressBar();
            this.FilesCopiedLabel = new System.Windows.Forms.Label();
            this.FilesToCopyTextBox = new System.Windows.Forms.TextBox();
            this.FilesCopiedTextBox = new System.Windows.Forms.TextBox();
            this.StartCopyDirectory = new System.Windows.Forms.Button();
            this.SelectTargetDirectoryButton = new System.Windows.Forms.Button();
            this.SelectSourceDirectoryButton = new System.Windows.Forms.Button();
            this.SourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TargetFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ToCopyLabel = new System.Windows.Forms.Label();
            this.ProgressPercentLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProgressPercentLabel);
            this.panel1.Controls.Add(this.FileTransferProgressBar);
            this.panel1.Controls.Add(this.ToCopyLabel);
            this.panel1.Controls.Add(this.FilesCopiedLabel);
            this.panel1.Controls.Add(this.FilesToCopyTextBox);
            this.panel1.Controls.Add(this.FilesCopiedTextBox);
            this.panel1.Controls.Add(this.StartCopyDirectory);
            this.panel1.Controls.Add(this.SelectTargetDirectoryButton);
            this.panel1.Controls.Add(this.SelectSourceDirectoryButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 557);
            this.panel1.TabIndex = 0;
            // 
            // FileTransferProgressBar
            // 
            this.FileTransferProgressBar.Location = new System.Drawing.Point(12, 77);
            this.FileTransferProgressBar.Name = "FileTransferProgressBar";
            this.FileTransferProgressBar.Size = new System.Drawing.Size(756, 57);
            this.FileTransferProgressBar.TabIndex = 7;
            // 
            // FilesCopiedLabel
            // 
            this.FilesCopiedLabel.AutoSize = true;
            this.FilesCopiedLabel.Location = new System.Drawing.Point(373, 165);
            this.FilesCopiedLabel.Name = "FilesCopiedLabel";
            this.FilesCopiedLabel.Size = new System.Drawing.Size(94, 21);
            this.FilesCopiedLabel.TabIndex = 6;
            this.FilesCopiedLabel.Text = "Files Copied";
            // 
            // FilesToCopyTextBox
            // 
            this.FilesToCopyTextBox.Location = new System.Drawing.Point(12, 189);
            this.FilesToCopyTextBox.Multiline = true;
            this.FilesToCopyTextBox.Name = "FilesToCopyTextBox";
            this.FilesToCopyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FilesToCopyTextBox.Size = new System.Drawing.Size(341, 356);
            this.FilesToCopyTextBox.TabIndex = 5;
            // 
            // FilesCopiedTextBox
            // 
            this.FilesCopiedTextBox.Location = new System.Drawing.Point(373, 189);
            this.FilesCopiedTextBox.Multiline = true;
            this.FilesCopiedTextBox.Name = "FilesCopiedTextBox";
            this.FilesCopiedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FilesCopiedTextBox.Size = new System.Drawing.Size(395, 356);
            this.FilesCopiedTextBox.TabIndex = 5;
            // 
            // StartCopyDirectory
            // 
            this.StartCopyDirectory.Location = new System.Drawing.Point(577, 24);
            this.StartCopyDirectory.Name = "StartCopyDirectory";
            this.StartCopyDirectory.Size = new System.Drawing.Size(191, 46);
            this.StartCopyDirectory.TabIndex = 4;
            this.StartCopyDirectory.Text = "Start Copy Process";
            this.StartCopyDirectory.UseVisualStyleBackColor = true;
            this.StartCopyDirectory.Click += new System.EventHandler(this.StartCopyDirectory_Click);
            // 
            // SelectTargetDirectoryButton
            // 
            this.SelectTargetDirectoryButton.Location = new System.Drawing.Point(197, 24);
            this.SelectTargetDirectoryButton.Name = "SelectTargetDirectoryButton";
            this.SelectTargetDirectoryButton.Size = new System.Drawing.Size(184, 47);
            this.SelectTargetDirectoryButton.TabIndex = 2;
            this.SelectTargetDirectoryButton.Text = "Select Tartget Directory";
            this.SelectTargetDirectoryButton.UseVisualStyleBackColor = true;
            this.SelectTargetDirectoryButton.Click += new System.EventHandler(this.SelectTargetDirectoryButton_Click);
            // 
            // SelectSourceDirectoryButton
            // 
            this.SelectSourceDirectoryButton.Location = new System.Drawing.Point(12, 24);
            this.SelectSourceDirectoryButton.Name = "SelectSourceDirectoryButton";
            this.SelectSourceDirectoryButton.Size = new System.Drawing.Size(179, 47);
            this.SelectSourceDirectoryButton.TabIndex = 1;
            this.SelectSourceDirectoryButton.Text = "Select Source Directory";
            this.SelectSourceDirectoryButton.UseVisualStyleBackColor = true;
            this.SelectSourceDirectoryButton.Click += new System.EventHandler(this.SelectSourceDirectoryButton_Click);
            // 
            // ToCopyLabel
            // 
            this.ToCopyLabel.AutoSize = true;
            this.ToCopyLabel.Location = new System.Drawing.Point(12, 165);
            this.ToCopyLabel.Name = "ToCopyLabel";
            this.ToCopyLabel.Size = new System.Drawing.Size(65, 21);
            this.ToCopyLabel.TabIndex = 6;
            this.ToCopyLabel.Text = "To Copy";
            // 
            // ProgressPercentLabel
            // 
            this.ProgressPercentLabel.AutoSize = true;
            this.ProgressPercentLabel.Location = new System.Drawing.Point(400, 95);
            this.ProgressPercentLabel.Name = "ProgressPercentLabel";
            this.ProgressPercentLabel.Size = new System.Drawing.Size(32, 21);
            this.ProgressPercentLabel.TabIndex = 8;
            this.ProgressPercentLabel.Text = "0%";
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
        private System.Windows.Forms.Button SelectTargetDirectoryButton;
        private System.Windows.Forms.Button SelectSourceDirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog SourceFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog TargetFolderBrowserDialog;
        private System.Windows.Forms.Button StartCopyDirectory;
        private System.Windows.Forms.Label FilesCopiedLabel;
        private System.Windows.Forms.TextBox FilesCopiedTextBox;
        private System.Windows.Forms.ProgressBar FileTransferProgressBar;
        private System.Windows.Forms.TextBox FilesToCopyTextBox;
        private System.Windows.Forms.Label ProgressPercentLabel;
        private System.Windows.Forms.Label ToCopyLabel;
    }
}

