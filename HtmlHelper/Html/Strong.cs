using static HtmlHelper.Helpers;

namespace HtmlHelper
{
    public class Strong : BodyElement
    {
        public Strong(params BodyElement[] content) : base("strong", content)
        {
        }
    }
}