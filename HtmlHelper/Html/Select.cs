using static HtmlHelper.FluentApi;

namespace HtmlHelper
{
    public class Select : BodyElement
    {
        public Select(params Option[] content) : base("select", content)
        {
            
        }
    }

    public class Option : Tag
    {
        public Option(string text) : base("option", Literal(text))
        {            
        }

        public Option(string text, string value) : this(text)
        {
            this.Attr("value", value);            
        }
    }

    public static partial class FluentApi
    {
        public static Select Select(params Option[] content) => new Select(content);

        public static Option Option(string text) => new Option(text);

        public static Option Option(string text, string value) => new Option(text, value);
    }
}