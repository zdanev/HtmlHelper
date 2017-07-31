using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlHelper
{
    public class Tag : IHtmlElement
    {
        public string Name { get; }

        public List<IHtmlElement>  Body { get; }

        public Tag()
        {
            Body = new List<IHtmlElement>();
        }

        public Tag(string name) : this()
        {
            Name = name;
        }

        public Tag(string name, params IHtmlElement[] body) : this(name)
        {
            Name = name;
            Body.AddRange(body);
        }

        public string Render()
        {
            if (!Body.Any())
            {
                return $"<{Name}/>";
            }
            else
            {
                var sb = new StringBuilder();

                sb.Append($"<{Name}>");

                foreach (var element in Body)
                {
                    sb.Append(element.Render());
                }

                sb.Append($"</{Name}>");

                return sb.ToString();
            }
        }
    }
}