using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyDirectory.Service
{
    class CopyDirectoryService
    {
        //Use the event handler to return the process of the file transfer progress
        public delegate void FileTransferProgressUpdate(string sourceFile, string copiedFile, int scourceCount, int targetCount);
        public event FileTransferProgressUpdate OnFileTransferProgressUpdate;

        /// <summary>
        /// Set both to private to avoid them being overwritten by another class
        /// </summary>
        private string SourcePath { get; set; }

        private string TargetPath { get; set; }

        public int SourceFileFolderCount { get; set; }

        public CopyDirectoryService()
        {
            //Nothing required
        }

        /// <summary>
        /// This method will be used to the start the copy process
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="targetPath"></param>
        /// <returns></returns>
        public bool StartCopy(string sourcePath, string targetPath)
        {

            SourcePath = sourcePath;
            TargetPath = targetPath;

            SourceFileFolderCount = Directory.GetFiles(SourcePath, "*.*", SearchOption.AllDirectories).Length;

            CopyFilesToTarget(SourcePath, TargetPath);
            
            return true;
        }

        /// <summary>
        /// Recursively loop over the directories and copy the files over. 
        /// If there a no more files or directories to loop return true.
        /// </summary>
        /// <param name="directoryPath"></param>
        private bool CopyFilesToTarget(string currentDirectoryPath, string targetPath)
        {

            //update what directory we are looking at and the deatils for that folder
            DirectoryInfo currentDirectory = new(currentDirectoryPath);

            //Get all the subDirectories, if any in the current Directory as array of DirectoryInfo
            DirectoryInfo[] subDirectories = currentDirectory.GetDirectories();

            //Create the targetPath directory, it doesn't exisit. The method won't overwrite if it does. 
            Directory.CreateDirectory(targetPath);
            
            //Get all the files in that folder as FileInfo array to loop through
            FileInfo[] folderFiles = currentDirectory.GetFiles();
            foreach (FileInfo filePath in folderFiles)
            {
                //merge the currentDirectry and the file current file name.
                string tempPath = Path.Combine(targetPath, filePath.Name);

                //File has been set allow the overwritting of files, it causing the app to crash.
                filePath.CopyTo(tempPath, true);

                //update the UI with the file that has been transferred.
                int tartgetCount = Directory.GetFiles(TargetPath, "*.*", SearchOption.AllDirectories).Length;
                OnFileTransferProgressUpdate(filePath.FullName, tempPath, SourceFileFolderCount, tartgetCount);
                
            }

            //Try loop through any directories in the current folder.
            foreach (DirectoryInfo folder in subDirectories)
            {

                //we found a new folder, we need to update the targetPath with new folder name so it can be created.
                string tempPath = Path.Combine(targetPath, folder.Name);
                CopyFilesToTarget(folder.FullName, tempPath);
            }

            //once there are no directories to files to copy is should return true
            return true;

        }



    }
}
