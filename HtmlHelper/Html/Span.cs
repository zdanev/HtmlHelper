namespace HtmlHelper
{
    public class Span : BodyElement
    {
        public Span(params IBodyElement[] content) : base("span", content)
        {
        }        
    }
}