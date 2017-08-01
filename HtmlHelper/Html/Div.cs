namespace HtmlHelper
{
    public class Div : Tag, IBodyElement
    {
        public Div(params IBodyElement[] content) : base("div", content)
        {
        }
    }
}