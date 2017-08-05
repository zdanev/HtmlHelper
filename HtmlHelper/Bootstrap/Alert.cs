using System.Linq;
using static HtmlHelper.Helpers;

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
            this.Class("alert-" + type.ToString().ToLower());
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

                var closeButton = Button(Span("&times;").Attr("aria-hidden", "true"));
                closeButton.Class("close");
                closeButton.Attr("data-dismiss", "alert");
                closeButton.Attr("aria-label", "Close");

                Content.Insert(0, closeButton);
        }
    }

    public static partial class Helpers
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