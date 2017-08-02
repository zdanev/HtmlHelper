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
            AddClass("alert");
            AddClass("alert-" + type.ToString().ToLower());
            Attr("role", "alert");

            // add alert-link class to all links
            content.Where(x => x is Anchor).ToList()
                .ForEach(x => ((Anchor)x).AddClass("alert-link"));
        }
    }

    public class DismissibleAlert : Alert
    {
        public DismissibleAlert(AlertType type, params BodyElement[] content) : base(type, content)
        {
                AddClass("alert-dismissible");
                AddClass("fade");
                AddClass("show");

                var closeButton = Button(Span("&times;").Attr("aria-hidden", "true"));
                closeButton.AddClass("close");
                closeButton.Attr("data-dismiss", "alert");
                closeButton.Attr("aria-label", "Close");

                Content.Insert(0, closeButton);
        }
    }
}