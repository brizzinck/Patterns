using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ObserverInterface
{
    public class FileStatusEventObservable : IObservable<string>, IDisposable
    {
        public List<IObserver<string>> _observers;
        private readonly Timer _timer;
        private readonly DirMonitoring _dirMonitoring;
        public FileStatusEventObservable(string directory)
        {
            _observers = new List<IObserver<string>>();
            _dirMonitoring = new DirMonitoring(directory);

            if (_dirMonitoring.StartMonitor())
            {
                _timer = new Timer(1000);
                _timer.Elapsed += ChechRemoval;
                _timer.Start();
            }
            else
            {
                Console.WriteLine("Specified direcory does not exist");
                Dispose();
            }
        }
        public void Dispose()
        {
            _timer.Dispose();
        }
        public IDisposable Subcribe(IObserver<string> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber(_observers, observer);
        }
        private void ChechRemoval(Object source, ElapsedEventArgs e)
        {
            foreach (var fileName in _dirMonitoring.DeletedFiles())
            {
                foreach (var observer in _observers)
                {
                    observer.OnNext(fileName);
                }
            }
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            throw new NotImplementedException();
        }
    }
}
