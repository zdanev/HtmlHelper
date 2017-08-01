using static HtmlHelper.HtmlHelpers;

namespace HtmlHelper.Bootstrap
{
    public class BootstrapPage : HtmlPage
    {
        public BootstrapPage(string title, params IBodyElement[] content) : base(
            Html(
                Head(
                    Title(title)
                ), 
                Body(content)))
        {
        }
    }
}