namespace HtmlHelper
{
    public interface IBodyElement : IHtmlElement
    {
    }

    public class Body : Tag
    {
        public Body(params IBodyElement[] content) : base("body", content)
        {
        }
    }
}