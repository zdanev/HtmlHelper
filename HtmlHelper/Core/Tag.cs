using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlHelper
{
    public class Tag : IHtmlElement
    {
        public string Name { get; }

        public List<IHtmlElement> Content { get; }

        public Tag()
        {
            Content = new List<IHtmlElement>();
        }

        // public Tag(string name) : this()
        // {
        //     Name = name;
        // }

        public Tag(string name, params IHtmlElement[] content) : this()
        {
            Name = name;
            Content.AddRange(content);
        }

        public string Render()
        {
            if (!Content.Any())
            {
                return $"<{Name}/>";
            }
            else
            {
                var sb = new StringBuilder();

                sb.Append($"<{Name}>");

                foreach (var element in Content)
                {
                    sb.Append(element.Render());
                }

                sb.Append($"</{Name}>");

                return sb.ToString();
            }
        }
    }
}