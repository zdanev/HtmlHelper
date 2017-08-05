﻿using System;
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
        }

        public Tag(string name, params IHtmlElement[] content) : this()
        {
            Name = name;
            Content.AddRange(content);
        }

        public virtual string Render(StringBuilder sb = null)
        {
            var returnResult = sb == null;

            sb = sb ?? new StringBuilder();

            sb.Append($"<{Name}");

            foreach (var attr in Attributes)
            {
                sb.Append($" {attr.Name}='{attr.Value}'");
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
    }

    public static partial class FluentApi
    {
        public static T Attr<T>(this T tag, string name, string value) where T: Tag
        {
            var attr = tag.Attributes.SingleOrDefault(x => x.Name == name);
            if (attr == null)
            {
                tag.Attributes.Add(new HtmlAttribute(name, value));
            }
            else
            {
                attr.Value = value;
            }

            return tag;
        }

        public static T Class<T>(this T tag, string @class) where T: Tag
        {
            var classAttr = tag.Attributes.SingleOrDefault(x => x.Name == "class");
            if (classAttr == null)
            {
                tag.Attr("class", @class);
            }
            else
            {
                tag.Attr("class", classAttr.Value + " " + @class);
            }

            return tag;
        }      
    }
}