using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlHelper
{
    public class Tag : IHtmlElement
    {
        public string Name { get; }

        public List<HtmlAttribute> Attributes { get; }

        public List<IHtmlElement> Content { get; }

        public bool DoNotCollapse { get; set;}

        public Tag()
        {
            Attributes = new List<HtmlAttribute>();
            Content = new List<IHtmlElement>();
            DoNotCollapse = false;
        }

        public Tag(string name, params IHtmlElement[] content) : this()
        {
            Name = name;
            Content.AddRange(content);
        }

        public string Render(StringBuilder sb = null)
        {
            var returnResult = sb == null;

            sb = sb ?? new StringBuilder();

            sb.Append($"<{Name}");

            foreach (var attr in Attributes)
            {
                sb.Append($" {attr.Name}=\"{attr.Value}\"");
            }

            if (Content.Any() || DoNotCollapse)
            {
                sb.Append($">");

                foreach (var element in Content)
                {
                    sb.Append(element.Render(sb));
                }

                sb.Append($"</{Name}>");
            }
            else
            {
                sb.Append($"/>");
            }

            return returnResult ? sb.ToString() : null;
        }
    }
}