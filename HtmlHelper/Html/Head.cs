namespace HtmlHelper
{
    public class Head : Tag
    {
        public Head(params IHtmlElement[] content) : base("head", content)
        {
        }
    }
}