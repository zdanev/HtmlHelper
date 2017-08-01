using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlHelper
{
    public abstract class Tag : IHtmlElement
    {
        public string Name { get; }

        public List<HtmlAttribute> Attributes { get; }

        public List<IHtmlElement> Content { get; }

        public bool DoNotCollapse { get; set; } // i.e. <script></script>

        public bool DoNotClose { get; set; } // i.e. <!DOCTYPE html> 

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

                if (!DoNotClose)
                {
                    sb.Append($"</{Name}>");
                }
            }
            else
            {
                if (DoNotClose)
                {
                    sb.Append($">");
                }
                else
                {
                    sb.Append($"/>");
                }
            }

            return returnResult ? sb.ToString() : null;
        }

        public Tag Attr(string name, string value)
        {
            var attr = Attributes.SingleOrDefault(x => x.Name == name);
            if (attr == null)
            {
                Attributes.Add(new HtmlAttribute(name, value));
            }
            else
            {
                attr.Value = value;
            }
            return this;
        }

        public void AddClass(string @class)
        {
            var classAttr = Attributes.SingleOrDefault(x => x.Name == "class");
            if (classAttr == null)
            {
                Attr("class", @class);
            }
            else
            {
                Attr("class", classAttr.Value + " " + @class);
            }

        }      
    }
}