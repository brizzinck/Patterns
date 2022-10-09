using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Template_method.Templates;

namespace Template_method.Extensions
{
    public static class HtmlTemplateExtensions
    {
        public static string DecodeString(this HtmlTemplate template, string text)
        {
            return HttpUtility.HtmlDecode(text);
        }
    }
}
