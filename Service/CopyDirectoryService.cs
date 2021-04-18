using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CopyDirectory.Observer;

namespace CopyDirectory.Service
{
    class CopyDirectoryService
    {
        //Use the event handler to return the process of the file transfer progress
        public event EventHandler<FileTranserInfo> FileTransferEvent;

        /// <summary>
        /// Set both to private to avoid them being overwritten by another class
        /// </summary>
        private string SourcePath { get; set; }

        private string TargetPath { get; set; }

        public int SourceFileFolderCount { get; set; }

        /// <summary>
        /// Class constructor requires that sourcePath and targetPath has been added when the class object is created.
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="targetPath"></param>
        public CopyDirectoryService(string sourcePath, string targetPath)
        {
            SourcePath = sourcePath;
            TargetPath = targetPath;
        }
        /// <summary>
        /// This method will be used to the start the copy process
        /// </summary>
        /// <returns></returns>
        public bool StartCopy()
        {

            //Get get a count what is to be transffered.
            SourceFileFolderCount = Directory.GetFiles(SourcePath, "*.*", SearchOption.AllDirectories).Length;

            //Create an string of all the directories in the sourcePath.
            DirectoryInfo sourceDireactory = new(SourcePath);

            DirectoryInfo[] directories = sourceDireactory.GetDirectories();

            //Loop through the array passing the current folder being looked and the targetPath to be updated.
            foreach (DirectoryInfo folder in directories)
            {
                //call the recursive function to copy the files and create the folders.
                
                CopyFilesToTarget(folder.FullName, TargetPath);
                
            }

            //return false by default
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
                FileTranserInfo fileTranserInfo = new(filePath.FullName, tempPath, tartgetCount);
                FileTransferEvent?.Invoke(this, fileTranserInfo);
                
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
