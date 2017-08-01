using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlHelper
{
    public class Literal : IHtmlElement, IBodyElement
    {
        public string Value { get; }

        public string Name => null;

        public List<HtmlAttribute> Attributes { get; }

        public List<IHtmlElement> Content { get; }

        protected Literal()
        {
            Attributes = new List<HtmlAttribute>();
            Content = new List<IHtmlElement>();
        }

        public Literal(string value) : this()
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