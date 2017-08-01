using static HtmlHelper.HtmlHelpers;

namespace HtmlHelper.Bootstrap
{
    public class BootstrapPage : HtmlPage
    {
        public BootstrapPage(string title, params IBodyElement[] content) : base(
            Html(
                Head(
                    Meta("charset", "utf-8"),
                    Meta("name", "viewport").Attr("content", "width=device-width, initial-scale=1, shrink-to-fit=no"),
                    Title(title)
                ), 
                Body(content)))
        {
        }
    }
}