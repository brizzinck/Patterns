using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TwitterMessage : MessangeBase
    {
        public TwitterMessage(string text, string source, string target) : base(text, source, target) 
        { 
            if (text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
            Send();
        }
        public override void Send()
        {
            Console.WriteLine($"Твиттер: Твит от @{Source} для @{Target}: {Text}");
        }
    }
}
