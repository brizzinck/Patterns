using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method.Templates
{
    public class SecretDocumentTemplate : StringTemplate
    {
        public override string GetFirstLine()
        {
            return "TOP SECRET\r\n"; 
        }

        public override string GetLastLine()
        {
            return $"\r\nDate: {DateTime.UtcNow}";
        }
        public override string EncodeString(string text)
        {
            var plainText = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(plainText);
        }
        public string DecodeString(string text)
        {
            var base64AncodeBytes = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(base64AncodeBytes);
        }
    }
}
