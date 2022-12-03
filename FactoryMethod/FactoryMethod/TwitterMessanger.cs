using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TwitterMessanger : MessangerBase
    {
        public TwitterMessanger(string name, string password) : base(name, password)
        {
        }

        public override bool Authorize()
        {
            Console.WriteLine($"Авторизация в Twitter пользователя  с именем {UserName} и паролем {Password}");
            return true;
        }

        public override IMessage CreatMessage(string text, string source, string targer)
        {
            var message = new TwitterMessage(text, source, targer);
            return message;
        }
    }
}
