using System;

namespace HtmlHelper
{
    public class Tag
    {
        public string Name { get; }

        public string Body { get; }

        public Tag(string name)
        {
            Name = name;
        }
        public Tag(string name, string body)
        {
            Name = name;
            Body = body;
        }

        public string Render()
        {
            if (string.IsNullOrEmpty(Body))
            {
                return $"<{Name}/>";
            }
            else
            {
                return $"<{Name}>{Body}</{Name}>";
            }
        }
    }
}