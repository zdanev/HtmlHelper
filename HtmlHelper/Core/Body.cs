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

        public new BodyElement Attr(string name, string value)
        {
            Attributes.Add(new HtmlAttribute(name, value));
            
            return this;
        }

        // public BodyElement Id(string id)
        // {
        //     Attr("id", id);
        //     return this;
        // }

        public BodyElement Class(string @class)
        {
            AddClass(@class);
            return this;
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

        // note: this is the pattern to folow...
        public static T Id<T>(this T bodyElement, string id) where T: BodyElement
        {
            bodyElement.Attr("id", id);
            return bodyElement;
        }        
    }    
}