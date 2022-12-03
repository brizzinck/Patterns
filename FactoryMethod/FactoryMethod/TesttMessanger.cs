using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TesttMessanger
    {
        public string UserName { get; }
        public string Password { get; }
        public bool Connected { get; }
        public TesttMessanger(string name, string password)
        {
            if (!(string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(password)))
            {
                UserName = name;
                Password = password;
                Connected = ConnertToTwitter();
            }
            else
            {
                Connected = false;
            }
        }
        public void SendMessage(string text, string source, string target)
        {
            #region Проверяем входные аргументы на корректность
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text), "Текст не может быть пустым");
            }
            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(text), "Имя отправителя не может быть пустым");
            }
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(text), "Имя получателя не может быть пустым");
            }
            if (text.Length > 140)
            {
                throw new ArgumentNullException("Текст сообщения не может быть больше 140 символов", nameof(text));
            }
            #endregion
            var message = new TestMessange(text, source, target);
            SendMessageToTwitter(message);
        }
        private void SendMessageToTwitter(TestMessange messange)
        {
            Console.WriteLine($"Твиттер: {messange.Text}");
        }
        private bool ConnertToTwitter()
        {
            Console.WriteLine($"Авторизация в Твиттере пользователя с именеи {UserName} и паролем {Password}");
            return true;
        }
    }
}
