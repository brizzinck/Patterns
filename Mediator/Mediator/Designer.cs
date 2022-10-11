using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Designer : Employee
    {
        private bool _isWorking;
        public Designer(IMediator mediator = null) : base(mediator) { }
        public void ExecuteWork()
        {
            Console.WriteLine("<-Дизайнер в работе");
            mediator.Notify(this, "Дизайнер проектирует...");
        }
        public void SetWork(bool state)
        {
            _isWorking = state;
            if (state)
                Console.WriteLine("<-Дизайнер освобожден от работы");
            else
                Console.WriteLine("<-Дизайнер занят");
        }
    }
} 
