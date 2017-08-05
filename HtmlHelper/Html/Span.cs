namespace HtmlHelper
{
    public class Span : BodyElement
    {
        public Span(params IBodyElement[] content) : base("span", content)
        {
        }        
    }

    public static partial class FluentApi
    {        public static Span Span(params BodyElement[] content)
        {
            return new Span(content);
        }
    }    
}