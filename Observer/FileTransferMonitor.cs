using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDirectory.Observer
{
    public class FileTransferMonitor: IObservable<FileTranserInfo>
    {


        List<IObserver<FileTranserInfo>> observers;


        public FileTransferMonitor()
        {
            observers = new List<IObserver<FileTranserInfo>>();
        }


        private class Unsubscriber : IDisposable
        {
            private List<IObserver<FileTranserInfo>> _observers;
            private IObserver<FileTranserInfo> _observer;

            public Unsubscriber(List<IObserver<FileTranserInfo>> observers, IObserver<FileTranserInfo> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (!(_observer == null)) _observers.Remove(_observer);
            }


        }
        public IDisposable Subscribe(IObserver<FileTranserInfo> observer)
        {
            if(!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }
        
    }
}
