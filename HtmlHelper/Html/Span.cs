namespace HtmlHelper
{
    public class Span : Tag, IBodyElement
    {
        public Span(params IHtmlElement[] content) : base("span", content)
        {
        }        
    }
}