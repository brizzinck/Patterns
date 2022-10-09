using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Template_method.Templates
{
    public class HtmlTemplate : StringTemplate
    {
        private readonly string _htmlPage = "!DOCTYPE html><html><body >(0)</body></html>";
        private readonly string _titel;
        public HtmlTemplate(string title)
        {
            _titel = title;
        }
        public override string GetFirstLine()
        {
            return $"ch1>{_titel}</h1>\n";
        }

        public override string GetLastLine()
        {
            return $"<p>{DateTime.UtcNow}</p>";
        }
        public override string EncodeString(string text)
        {
            return HttpUtility.HtmlEncode(string.Format(_htmlPage, $"<div>{text}</div>"));
        }
    }
}
