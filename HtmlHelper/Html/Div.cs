namespace HtmlHelper
{
    public class Div : Tag, IBodyElement
    {
        public Div(params IHtmlElement[] content) : base("div", content)
        {
        }
    }
}