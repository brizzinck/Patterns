using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TestMessange
    {
        public string Text { get; }
        public string Target { get; }
        public string Source { get; }
        public TestMessange(string text, string target, string source)
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
            if (text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                text = text.Substring(0, 140);
            }
            Source = source;
            Target = target;
        }
    }
}
