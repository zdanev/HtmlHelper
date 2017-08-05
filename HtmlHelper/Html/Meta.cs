namespace HtmlHelper
{
    public class Meta : HeadElement
    {
        public Meta(string name, string value) : base("meta")
        {
            this.Attr(name, value);
        }
    }

    public static partial class FluentApi
    {
        public static Meta Meta(string name, string value)
        {
            return new Meta(name, value);
        }
    }    
}