using static HtmlHelper.Helpers;

namespace HtmlHelper
{
    public class Strong : BodyElement
    {
        public Strong(params BodyElement[] content) : base("strong", content)
        {
        }
    }

    public static partial class Helpers
    {
        public static Strong Strong(string content)
        {
            return new Strong(content);
        }
    }    
}