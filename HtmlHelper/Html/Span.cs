namespace HtmlHelper
{
    public class Span : Tag, IBodyElement
    {
        public Span(params IBodyElement[] content) : base("span", content)
        {
        }        
    }
}