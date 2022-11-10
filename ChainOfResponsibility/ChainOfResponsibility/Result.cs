using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Command
    {
        public static void GiveCommand(IWorker worker, string command)
        {
            string str = worker.Execute(command);
            if (str == "")
                Console.WriteLine(command + " - никто не умеет делать");
            else
                Console.WriteLine(str);
        }
    }
}
