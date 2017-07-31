namespace HtmlHelper
{
    public static class HtmlHelpers
    {
        public static Tag Tag(string name)
        {
            return new Tag(name);
        }

        public static Tag Tag(string name, params IHtmlElement[] content)
        {
            return new Tag(name, content);
        }

        public static Literal _(string value)
        {
            return new Literal(value);
        }

        public static Html Html(Head head, Body body)
        {
            return new Html(head, body);
        }

        public static Head Head(params IHtmlElement[] content)
        {
            return new Head(content);
        }

        public static Body Body(params IHtmlElement[] content)
        {
            return new Body(content);
        }
    }
}