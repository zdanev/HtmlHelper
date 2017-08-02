namespace HtmlHelper
{
    public class Span : BodyElement
    {
        public Span(params IBodyElement[] content) : base("span", content)
        {
        }        
    }

    public static partial class Helpers
    {        public static Span Span(params BodyElement[] content)
        {
            return new Span(content);
        }
    }    
}