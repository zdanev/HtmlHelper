using static HtmlHelper.FluentApi;

namespace HtmlHelper
{
    public class Style : HeadElement
    {
        public Style(string inlineStyle) : base("style", Literal(inlineStyle))
        {            
        }
    }

    public static partial class FluentApi
    {
        public static Style Style(string inlineStyle) => new Style(inlineStyle);
    }
}