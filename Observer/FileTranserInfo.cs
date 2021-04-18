using System.Collections.Generic;

namespace CopyDirectory.Observer

{
    public struct FileTranserInfo
    {

        private string _fileCopied;
        private string _fileToCopy;
        private int _copiedCount;
                
        public FileTranserInfo(string fileCopied, string fileToCopy, int copiedCount)
        {
            _fileCopied = fileCopied;
            _fileToCopy = fileToCopy;
            _copiedCount = copiedCount;
        }

        public string FileCopied { get { return _fileCopied; } }
        public string FileToCopy { get { return _fileToCopy; } }
        public int CopiedCount{ get { return _copiedCount; } }
    }
}
