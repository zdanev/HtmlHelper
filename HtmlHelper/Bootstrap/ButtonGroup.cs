namespace HtmlHelper.Bootstrap
{
    public interface IButtonToolbarElement : IBodyElement
    {
    }

    public class ButtonGroup : Div, IButtonToolbarElement
    {
        public ButtonGroup(params Button[] content) : base(content)
        {
            this.Class("btn-group");
            this.Attr("role", "group");            
        }
    }

    public class ButtonToolbar : Div
    {
        public ButtonToolbar(params IButtonToolbarElement[] content) : base(content)
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

        public static ButtonToolbar ButtonToolbar(params IButtonToolbarElement[] content)
        {
            return new ButtonToolbar(content);
        }
    }
}