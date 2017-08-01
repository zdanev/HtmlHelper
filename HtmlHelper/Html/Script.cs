namespace HtmlHelper
{
    public class Script : HeadElement
    {
        public string Src { get; }

        public Script(string src) : base("script")
        {
            DoNotCollapse = true;
            Src = src;

            this.Attr("src", src);
        }
    }
}