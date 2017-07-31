using System.Collections.Generic;
using System.Text;

namespace HtmlHelper
{
    public interface IHtmlElement
    {
        string Name { get; }

        List<HtmlAttribute> Attributes { get; }

        List<IHtmlElement> Content { get; }

        string Render(StringBuilder sb = null);
    }
}