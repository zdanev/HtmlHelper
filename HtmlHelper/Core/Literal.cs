using System;
using System.Text;

namespace HtmlHelper
{
    public class Literal : IHtmlElement
    {
        public string Value { get; }

        public Literal(string value)
        {
            Value = value;
        }

        public string Render(StringBuilder sb)
        {
            var returnResult = sb == null;

            sb = sb ?? new StringBuilder();

            sb.Append(Value);

            return returnResult ? sb.ToString() : null;
        }
    }
}