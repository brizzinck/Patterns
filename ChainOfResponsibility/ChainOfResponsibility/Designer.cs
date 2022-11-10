using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Designer : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "Спроектировать дом")
                return "Проектировщик выполняет команду: " + command;
            return base.Execute(command);
        }
    }
}
