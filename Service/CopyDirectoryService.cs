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

        
        /// <summary>
        /// Set both to private to avoid them being overwritten by another class
        /// </summary>
        private string SourcePath { get; set; }

        private string TargetPath { get; set; }

        //we need to know the current Directory.
        private string CurrentDirectoryPath { get; set; }


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
        public Boolean StartCopy()
        {
            Boolean success = false;

            Array directories = Directory.GetDirectories(SourcePath);



            //return false by default
            return success;
        }

        /// <summary>
        /// Recursively loop over the directories and copy the files over. 
        /// If there a no more files or directories to loop return true.
        /// </summary>
        /// <param name="directoryPath"></param>
        private Boolean copyFilesToTartGet(string currentDirectoryPath)
        {
            try
            {
                //update what directory we are looking at
                CurrentDirectoryPath = currentDirectoryPath;
                foreach (string file in Directory.GetFiles(currentDirectoryPath))
                {
                    
                    //CopyCurrentFile(file);
                }

                foreach (string directory in Directory.GetDirectories(currentDirectoryPath))
                {

                    var string newTargetPath = directory.Replace(currentDirectoryPath, TargetPath);
                                        
                    //we've found another directory so call this function again to get the files.
                    copyFilesToTartGet(directory);
                }

                //once there are no directories to files to copy is should return true
                return true;

            }
            catch (System.Exception exception)
            {
                //TODO This requires a way to record errors or have a way to return this issue back to the UI
                return false;
            }

        }

        private void CopyCurrentFile (string filePath, string currentDirecorty)
        {
            
        }

    }
}
