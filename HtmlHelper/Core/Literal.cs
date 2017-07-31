using System;

namespace HtmlHelper
{
    public class Literal : IHtmlElement
    {
        public string Value { get; }

        public Literal(string value)
        {
            Value = value;
        }

        public string Render()
        {
            return Value;
        }
    }
}