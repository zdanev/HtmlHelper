namespace HtmlHelper
{
    public class Body : Tag
    {
        public Body(params IHtmlElement[] content) : base("body", content)
        {
        }
    }
}