using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDirectory.Observer
{
    class FileTransferReporter : IObserver<FileTranserInfo>
    {
        private IDisposable unsubscriber;
        private bool first = true;
        private FileTranserInfo last;




        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(FileTranserInfo value)
        {
            throw new NotImplementedException();
        }

        public virtual void Subscribe(IObservable<FileTranserInfo> provider)
        {
            unsubscriber = provider.Subscribe(this);   
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

    }
}
