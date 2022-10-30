using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEvent
{
    public class Subscriber
    {
        private readonly string _name;
        public Subscriber(string name)
        {
            _name = name;
        }

        public void ItIsSubscriber(object sender, string fileName)
        {
            Console.WriteLine($"{_name} {fileName} was deleted");
        }
        public void ItISecondSubscriber(object sender, string fileName)
        {
            Console.WriteLine("---");
            Console.WriteLine($"{_name} {fileName} was deleted");
            Console.WriteLine("---");
        }
    }
}
