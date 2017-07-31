namespace HtmlHelper
{
    public class Span : Tag
    {
        public Span(params IHtmlElement[] content) : base("span", content)
        {
        }        
    }
}