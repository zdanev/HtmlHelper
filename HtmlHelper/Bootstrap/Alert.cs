using System.Linq;

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

            content.Where(x => x is Anchor).ToList()
                .ForEach(x => ((Anchor)x).AddClass("alert-link"));
        }

        public Alert(AlertType type, bool dismissable, params BodyElement[] content) : this(type, content)
        {
            if (dismissable) 
            {
                AddClass("alert-dismissible");
                AddClass("fade");
                AddClass("show");

               // Content.Insert(0, Button)
            }
        }
    }
}