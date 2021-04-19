using System.Collections.Generic;

namespace CopyDirectory.Observer

{
    public struct FileTranserInfo
    {

        private string _fileCopied;
        private string _fileToCopy;
        private int _copiedCount;
        private int _sourceCount;
                
        public FileTranserInfo(string fileToCopy, string fileCopied, int copiedCount, int sourceCount)
        {
            _fileCopied = fileCopied;
            _fileToCopy = fileToCopy;
            _copiedCount = copiedCount;
            _sourceCount = sourceCount;
        }

        public string FileCopied { get { return _fileCopied; } }
        public string FileToCopy { get { return _fileToCopy; } }
        public int CopiedCount{ get { return _copiedCount; } }
        public int SourceCount { get { return _sourceCount; } }
    }
}
