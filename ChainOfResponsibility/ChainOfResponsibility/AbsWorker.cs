using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class AbsWorker : IWorker
    {
        private IWorker _nextWorker;
        public AbsWorker() => _nextWorker = null;
        public IWorker SetNextWorker(IWorker worker)
        {
            _nextWorker = worker;
            return worker;
        }
        public virtual string Execute(string command)
        {
            if (_nextWorker != null) 
                return _nextWorker.Execute(command);
            return string.Empty;
        }
    }
}
