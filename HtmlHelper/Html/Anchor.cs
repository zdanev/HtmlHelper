using static HtmlHelper.Helpers;

namespace HtmlHelper
{
    public class Anchor  : BodyElement
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