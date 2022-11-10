using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Carpenters : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "Класть кирпич")
                return "Плотник выполняет команду: " + command;
            return base.Execute(command);
        }
    }
}
