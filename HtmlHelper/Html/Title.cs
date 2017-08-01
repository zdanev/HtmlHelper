using static HtmlHelper.Helpers;

namespace HtmlHelper
{
    public class Title : Tag, IHeadElement
    {
        public string Value { get; }

        public Title(string title) : base("title", new Literal(title))
        {
            Value = title; 
        }
    }
}