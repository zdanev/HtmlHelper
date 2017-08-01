using static HtmlHelper.HtmlHelpers;

namespace HtmlHelper
{
    public class Strong : BodyElement
    {
        public Strong(string content) : base("strong", _(content))
        {
        }
    }
}