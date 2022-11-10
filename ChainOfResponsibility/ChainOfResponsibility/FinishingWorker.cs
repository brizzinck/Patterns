using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class FinishingWorker : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "Клеить обои")
                return "Рабочий внутренней отделки выполнил команду: " + command;
            return base.Execute(command);
        }
    }
}
