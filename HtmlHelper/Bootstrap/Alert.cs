using System.Linq;
using static HtmlHelper.FluentApi;

namespace HtmlHelper.Bootstrap
{
    public enum AlertType
    {
        Success,
        Info,
        Warning,
        Danger
    }

    public class Alert : Div
    {
        public Alert(AlertType type, params BodyElement[] content) : base(content)
        {
            this.Class("alert");
            this.Class("alert-" + type.AsKebab());
            this.Attr("role", "alert");

            // add alert-link class to all links
            content.Where(x => x is Anchor).ToList()
                .ForEach(x => ((Anchor)x).Class("alert-link"));
        }
    }

    public class DismissibleAlert : Alert
    {
        public DismissibleAlert(AlertType type, params BodyElement[] content) : base(type, content)
        {
            this.Class("alert-dismissible");
            this.Class("fade");
            this.Class("show");

            Content.Insert(0, Button(Span("&times;").Attr("aria-hidden", "true"))
                .Class("close")
                .Attr("data-dismiss", "alert")
                .Attr("aria-label", "Close"));
        }
    }

    public static partial class FluentApi
    {
        public static Alert Alert(AlertType type, params BodyElement[] content)
        {
            return new Alert(type, content);
        }

        public static DismissibleAlert DismissibleAlert(AlertType type, params BodyElement[] content)
        {
            return new DismissibleAlert(type, content);
        }
    }
}