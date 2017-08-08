namespace HtmlHelper
{
    public class Break : BodyElement
    {
        public Break() : base("br")
        {
        }
    }

    public class Line : BodyElement
    {
        public Line() : base("hr")
        {
        }
    }

    public static partial class FluentApi

    {
        public static Break BR() => new Break();

        public static Line HR() => new Line();
    } 
}