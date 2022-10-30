using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subsciber
    {
        private readonly string _name;
        public Subsciber(string name)
        {
            _name = name;
        }

        public void ItIsSubscriber(string fileName)
        {
            Console.WriteLine($"{_name} {fileName} was deleted");
        }
    }
}
