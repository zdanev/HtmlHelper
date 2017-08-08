namespace HtmlHelper.Bootstrap
{
    public class ButtonGroup : Div
    {
        public ButtonGroup(params Button[] content) : base(content)
        {
            this.Class("btn-group");
            this.Attr("role", "group");            
        }
    }

    public static partial class FluentApi
    {
        public static ButtonGroup ButtonGroup(params Button[] content)
        {
            return new ButtonGroup(content);
        }
    }
}