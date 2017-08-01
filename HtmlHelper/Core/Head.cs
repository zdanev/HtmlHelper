namespace HtmlHelper
{
    public interface IHeadElement : IHtmlElement
    {
    }

    public abstract class HeadElement : Tag, IHeadElement
    {
        public HeadElement(string name, params IHtmlElement[] content) : base(name, content)
        {
        }

        public new HeadElement Attr(string name, string value)
        {
            Attributes.Add(new HtmlAttribute(name, value));
            
            return this;
        }      
    }

    public class Head : Tag
    {
        public Head(params IHeadElement[] content) : base("head", content)
        {
        }
    }
}