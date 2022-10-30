using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverInterface
{
    public class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<string>> _observers;
        private readonly IObserver<string> _observer;
        public Unsubscriber(List<IObserver<string>> observers, IObserver<string> subscriber)
        {
            _observers = observers;
            _observer = subscriber;
        }   
        public void Dispose()
        {
            if (_observers != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
