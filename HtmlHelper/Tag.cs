using System;

namespace HtmlHelper
{
    public class Tag
    {
        public string Name { get; }

        public Tag(string name)
        {
            Name = name;
        }

        public string Render()
        {
            return $"<{Name}/>";
        }
    }
}