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
        }
    }
}