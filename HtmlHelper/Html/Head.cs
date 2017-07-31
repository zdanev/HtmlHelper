namespace HtmlHelper
{
    public interface IHeadElement : IHtmlElement
    {
    }

    public class Head : Tag
    {
        public Head(params IHeadElement[] content) : base("head", content)
        {
        }
    }
}