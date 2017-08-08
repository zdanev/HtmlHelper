namespace HtmlHelper
{
    public class Paragrapth : BodyElement
    {
        public Paragrapth(params BodyElement[] content) : base("p", content)
        {            
        }
    }

    public static partial class FluentApi
    {
        public static Paragrapth P(params BodyElement[] content) => new Paragrapth(content);
    }
}