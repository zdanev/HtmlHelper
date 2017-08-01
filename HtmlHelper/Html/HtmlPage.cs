namespace HtmlHelper
{
    public class HtmlPage : Tag
    {
        public HtmlPage(Html html) : base("!DOCTYPE html", html)
        {
            DoNotClose = true;
        }
    }
}