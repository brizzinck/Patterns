using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverInterface
{
    public class Observer : IObserver<string>
    {
        private IDisposable _unsubscriber;
        public virtual void Subscribe(IObservable<string> provider)
        {
            if (provider == null)
            {
                _unsubscriber = provider.Subscribe(this);
            }
        }

        public void OnNext(string value)
        {
            Console.WriteLine($"{value} file was deleted"); 
        }
        public void OnError(Exception error)
        {
            Console.WriteLine("An error was occured: " + error.Message);
        }
        public void OnCompleted()
        {
            Unsubscriber();
        }
        public virtual void Unsubscriber()
        {
            _unsubscriber?.Dispose();
        }

    }
}
