using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlHelper
{
    public class Literal : BodyElement
    {
        public string Value { get; }

        protected Literal() : base(null)
        {
        }

        public Literal(string value) : this()
        {
            Value = value;
        }

        public override string Render(StringBuilder sb = null)
        {
            var returnResult = sb == null;

            sb = sb ?? new StringBuilder();

            sb.Append(Value);

            return returnResult ? sb.ToString() : null;
        }
    }
}