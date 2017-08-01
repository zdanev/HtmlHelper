namespace HtmlHelper
{
    public class Meta : Tag
    {
        public Meta(string name, string value) : base("meta")
        {
            this.Attr(name, value);
        }
    }
}