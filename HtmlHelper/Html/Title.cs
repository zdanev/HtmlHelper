using static HtmlHelper.HtmlHelpers;

namespace HtmlHelper
{
    public class Title : Tag, IHeadElement
    {
        public string Value { get; }

        public Title(string title) : base("title", _(title))
        {
            Value = title; 
        }
    }
}