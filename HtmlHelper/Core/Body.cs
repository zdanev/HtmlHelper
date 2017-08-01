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
    }
    
    public class Body : Tag
    {
        public Body(params IBodyElement[] content) : base("body", content)
        {
        }
    }
}