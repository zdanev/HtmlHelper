namespace HtmlHelper
{
    public class Label : BodyElement
    {
        public Label(params BodyElement[] content) : base("label", content)
        {
        }
    }

    public static partial class FluentApi
    {
        public static Label Label(params BodyElement[] content) => new Label(content);

        public static Label LabelFor(string id, params BodyElement[] content) => new Label(content).Attr("for", id);
    }
}