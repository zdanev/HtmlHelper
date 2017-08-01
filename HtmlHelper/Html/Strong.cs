using static HtmlHelper.Helpers;

namespace HtmlHelper
{
    public class Strong : BodyElement
    {
        public Strong(string content) : base("strong", _(content))
        {
        }
    }
}