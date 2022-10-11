using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Director : Employee
    {
        private string text;
        public Director(IMediator mediator = null) : base(mediator) { }
        public void GiveCommand(string txt)
        {
            text = txt;
            if (text == "")
                Console.WriteLine("->Директор знает, что дизайнер уже работает");
            else
                Console.WriteLine("->Директор дал команду: " + text);
            mediator.Notify(this, text);
        }
    }
}
