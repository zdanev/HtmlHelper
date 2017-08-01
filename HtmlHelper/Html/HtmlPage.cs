namespace HtmlHelper
{
    public class HtmlPage : Tag
    {
        public Html Html { get; }

        public HtmlPage(Html html) : base("!DOCTYPE html", html)
        {
            Html = html;
            DoNotClose = true;
        }
    }
}