namespace HtmlHelper
{
    public class Button : BodyElement
    {
        public Button(params BodyElement[] content) : base("button", content)
        {
            Attr("type", "button");
        }
    }
}