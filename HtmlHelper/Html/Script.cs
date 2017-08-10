namespace HtmlHelper
{
    public interface IScriptElement : IHtmlElement
    {        
    }

    public class Script : Tag, IHeadElement, IBodyElement
    {
        public Script(params IScriptElement[] content) : base("script", content)
        {            
        }
    }

    public class ExtScript : Script
    {
        public string Src { get; }

        public ExtScript(string src)
        {
            DoNotCollapse = true;
            Src = src;

            this.Attr("src", src);
        }
    }

    public static partial class FluentApi
    {
        public static ExtScript ExtScript(string src) => new ExtScript(src);

        public static Script Script(params IScriptElement[] content) => new Script(content);
    }    
}