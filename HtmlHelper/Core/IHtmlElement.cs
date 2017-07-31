using System.Text;

namespace HtmlHelper
{
    public interface IHtmlElement
    {
        string Render(StringBuilder sb = null);
    }
}