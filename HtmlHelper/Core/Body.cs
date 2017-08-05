namespace HtmlHelper
{
    public interface IBodyElement : IHtmlElement
    {
    }

    public abstract class BodyElement : Tag, IBodyElement
    {
        public BodyElement(string name, params IHtmlElement[] content) : base(name, content)
        {
        }

        public static implicit operator BodyElement(string value)
        {
            return new Literal(value);
        } 
    }
    
    public class Body : Tag
    {
        public Body(params IBodyElement[] content) : base("body", content)
        {
        }
    }

    public static partial class Helpers
    {
        public static Body Body(params IBodyElement[] content)
        {
            return new Body(content);
        }

        public static T Id<T>(this T bodyElement, string id) where T: BodyElement
        {
            bodyElement.Attr("id", id);
            return bodyElement;
        }        
    }    
}