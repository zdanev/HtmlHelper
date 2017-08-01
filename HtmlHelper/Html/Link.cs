namespace HtmlHelper
{
    public enum LinkRel
    {
        Stylesheet
    }

    public enum LinkType 
    {
        Text_Css
    }

    public class Link : HeadElement
    {
        public LinkRel Rel { get; }

        public LinkType Type { get; }

        public string Href { get; }

        public Link(LinkRel rel, LinkType type, string href) : base("link")
        {
            Rel = rel;
            Type = type;
            Href = href;

            this.Attr("rel", rel.ToString().ToLower().Replace("_", "/"));
            this.Attr("type", type.ToString().ToLower().Replace("_", "/"));
            this.Attr("href", href);
        }
    }
}