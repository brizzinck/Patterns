using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method.Templates
{
    public abstract class StringTemplate
    {
        public virtual string GetTemplate(string text)
        {
            return $"{EncodeString(GetFirstLine() + text + GetLastLine())}";
        }
        public abstract string GetFirstLine();
        public abstract string GetLastLine();
        public abstract string EncodeString(string text);

    }
}
