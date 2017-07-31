namespace HtmlHelper
{
    public static class HtmlHelpers
    {
        public static Tag Tag(string name)
        {
            return new Tag(name);
        }

        public static Tag Tag(string name, params IHtmlElement[] body)
        {
            return new Tag(name, body);
        }

        public static Literal _(string value)
        {
            return new Literal(value);
        }
    }
}