using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Controller : IMediator
    {    
        private Designer _designer;
        private Director _director;
        public Controller(Designer designer, Director director)
        {
            _designer = designer;
            _director = director;
            _designer.SetMediator(this);
            _director.SetMediator(this);
        }
        public void Notify(Employee emp, string msg)
        {
            if (emp is Director director)
            {
                if (msg == "")
                    _designer.SetWork(false);
                else
                    _designer.SetWork(true);
            }
            if (emp is Designer designer)
            {
                if (msg == "Дизайнер проектирует...")
                    _director.GiveCommand("");
            }
        }
    }
}
