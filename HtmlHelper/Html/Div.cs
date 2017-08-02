namespace HtmlHelper
{
    public class Div : BodyElement
    {
        public Div(params IBodyElement[] content) : base("div", content)
        {
        }
    }

    public static partial class Helpers
    {
        public static Div Div(params BodyElement[] content)
        {
            return new Div(content);
        }
    }
}