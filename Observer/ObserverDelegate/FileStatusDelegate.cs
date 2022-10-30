using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Observer
{
    public class FileStatusDelegate : IDisposable
    {
        private readonly Action<string> _subscriber;
        private readonly Timer _timer;
        private readonly DirMonitoring _dirMonitoring;
        public FileStatusDelegate(string directory, Action<string> subscriber)
        {
            _subscriber = subscriber;
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
        private void ChechRemoval(Object source, ElapsedEventArgs e)
        {
            foreach (var fileName in _dirMonitoring.DeletedFiles())
            {
                _subscriber(fileName);
            }
        }
    }
}
