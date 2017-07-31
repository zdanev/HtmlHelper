using static HtmlHelper.HtmlHelpers;

namespace HtmlHelper
{
    public class Anchor  : Tag, IBodyElement
    {
        public string Href { get; }

        public string Text { get; }

        public Anchor(string href, string text) : base ("a", _(text))
        {
            Href = href;
            Text = text;

            this.Attr("href", href);
        }
    }
}