using static HtmlHelper.FluentApi;

namespace HtmlHelper
{
    public class Anchor  : BodyElement
    {
        public string Href { get; }

        public Anchor(string href, params BodyElement[] content) : base("a", content)
        {
            Href = href;

            this.Attr("href", href);
        }
    }

    public static partial class FluentApi
    {
        public static Anchor Anchor(string href, string text)
        {
            return new Anchor(href, text);
        }
    }    
}