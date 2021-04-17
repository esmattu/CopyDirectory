namespace CopyDirectory.Observer

{
    public struct FileTranserInfo
    {

        private string fileCopied;
        private float percentageComplete;
        
        public FileTranserInfo(string fileCopied, float transferPercentage)
        {
            this.fileCopied = fileCopied;
            this.percentageComplete = transferPercentage;
        }

        public string FileCopied { get { return this.fileCopied; }  }
        public float PercentageCompleted { get { return this.percentageComplete; }  }
    }
}
