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

    public class ButtonToolbar : Div
    {
        public ButtonToolbar(params ButtonGroup[] content) : base(content)
        {
            this.Class("btn-toolbar");
            this.Attr("role", "toolbar");
        }
    }

    public static partial class FluentApi
    {
        public static ButtonGroup ButtonGroup(params Button[] content)
        {
            return new ButtonGroup(content);
        }

        public static ButtonToolbar ButtonToolbar(params ButtonGroup[] content)
        {
            return new ButtonToolbar(content);
        }
    }
}