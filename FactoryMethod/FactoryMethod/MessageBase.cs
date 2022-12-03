using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class MessangeBase : IMessage
    {
        public string Text { get; protected set; }

        public string Target { get; }

        public string Source { get; }
        public MessangeBase(string text, string target, string source)
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
            #endregion
            Text = text;
            Source = source;
            Target = target;
        }

        public abstract void Send();
    }
}
