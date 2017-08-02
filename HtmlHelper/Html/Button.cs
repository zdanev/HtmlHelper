namespace HtmlHelper
{
    public class Button : BodyElement
    {
        public Button(params BodyElement[] content) : base("button", content)
        {
            Attr("type", "button");
        }
    }

    public static partial class Helpers
    {
        public static Button Button(params BodyElement[] content)
        {
            return new Button(content);
        }
    }    
}