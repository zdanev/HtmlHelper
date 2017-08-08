namespace HtmlHelper
{
    public class Button : BodyElement
    {
        public Button(params BodyElement[] content) : base("button", content)
        {
            this.Attr("type", "button");
        }
    }

    public static partial class FluentApi
    {
        public static Button Button(params BodyElement[] content) => new Button(content);

        public static Button OnClick(this Button button, string onclick) => button.Attr("onclick", onclick);
    }    
}