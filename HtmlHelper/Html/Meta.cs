namespace HtmlHelper
{
    public class Meta : HeadElement
    {
        public Meta(string name, string value) : base("meta")
        {
            this.Attr(name, value);
        }
    }
}