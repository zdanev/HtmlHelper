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
            Attr("role", "alert");
            AddClass("alert");
            AddClass("alert-" + type.ToString().ToLower());
        }
    }
}