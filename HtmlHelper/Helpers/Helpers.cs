namespace HtmlHelper
{
    public static partial class Helpers
    {
        public static HtmlPage HtmlPage(Html html)
        {
            return new HtmlPage(html);
        }

        public static Html Html(Head head, Body body)
        {
            return new Html(head, body);
        }

        public static Head Head(params IHeadElement[] content)
        {
            return new Head(content);
        }

        public static Title Title(string title)
        {
            return new Title(title);
        }

        public static Body Body(params IBodyElement[] content)
        {
            return new Body(content);
        }

        public static Script Script(string src)
        {
            return new Script(src);
        }

        public static Link Link(LinkRel rel, LinkType type, string href) 
        {
            return new Link(rel, type, href);
        }

        public static Div Div(params BodyElement[] content)
        {
            return new Div(content);
        }

        public static Span Span(params BodyElement[] content)
        {
            return new Span(content);
        }

        public static Input Input(InputType type, string content)
        {
            return new Input(type, content);
        }

        public static Anchor Anchor(string href, string text)
        {
            return new Anchor(href, text);
        }

        public static Meta Meta(string name, string value)
        {
            return new Meta(name, value);
        }

        public static Strong Strong(string content)
        {
            return new Strong(content);
        }

        public static Button Button(params BodyElement[] content)
        {
            return new Button(content);
        }
    }
}