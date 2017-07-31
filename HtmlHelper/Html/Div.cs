namespace HtmlHelper
{
    public class Div : Tag
    {
        public Div(params IHtmlElement[] content) : base("div", content)
        {
        }
    }
}