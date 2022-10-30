using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ObserverEvent
{
    public class FileStatusEvent : IDisposable
    {
        public EventHandler<string> RemoveFiles;
        private readonly Timer _timer;
        private readonly DirMonitoring _dirMonitoring;
        public FileStatusEvent(string directory)
        {
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
                var handler = RemoveFiles;
                handler?.Invoke(this, fileName);
            }
        }
    }
}
