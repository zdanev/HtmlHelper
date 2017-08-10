using System.Linq;
using static HtmlHelper.FluentApi;

namespace HtmlHelper.Bootstrap
{
    public class BootstrapPage : HtmlPage
    {
        const string cssUrl = "https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css";
        const string cssHash = "sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ";
        const string jqueryUrl = "https://code.jquery.com/jquery-3.1.1.slim.min.js";
        const string jqueryHash = "sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n";
        const string tetherUrl = "https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js";
        const string tetherHash = "sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb";
        const string bootstrapUrl = "https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js";
        const string bootstrapHash = "sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn";

        public BootstrapPage(string title, params IBodyElement[] content) : base(
            Html(
                Head(
                    Meta("charset", "utf-8"),
                    Meta("name", "viewport").Attr("content", "width=device-width, initial-scale=1, shrink-to-fit=no"),
                    Link(LinkRel.Stylesheet, LinkType.Text_Css, cssUrl).Attr("integrity", cssHash).Attr("crossorigin", "anonymous"),
                    Title(title)
                ), 
                Body(content)))
        {
            Content.Add(ExtScript(jqueryUrl).Attr("integrity", jqueryHash).Attr("crossorigin", "anonymous"));
            Content.Add(ExtScript(tetherUrl).Attr("integrity", tetherHash).Attr("crossorigin", "anonymous"));
            Content.Add(ExtScript(bootstrapUrl).Attr("integrity", bootstrapHash).Attr("crossorigin", "anonymous"));
        }
    }

    public static partial class FluentApi
    {
        public static BootstrapPage BootstrapPage(string title, params IBodyElement[] content)
        {
            return new BootstrapPage(title, content);
        }
    }
}