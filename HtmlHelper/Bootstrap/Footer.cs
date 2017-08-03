using static HtmlHelper.Bootstrap.Helpers;

namespace HtmlHelper.Bootstrap
{
    public class Footer : BodyElement
    {
        public Footer(params BodyElement[] content) : base("footer", Container(content))
        {
            AddClass("footer");
        }
    }

    public static partial class Helpers
    {
        public static Footer Footer(params BodyElement[] content)
        {
            return new Footer(content);
        }
    }
}