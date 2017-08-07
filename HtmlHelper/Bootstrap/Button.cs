namespace HtmlHelper.Bootstrap
{
    public enum ButtonType
    {
        Default,
        Primary,
        Secondary,
        Success,
        Info,
        Warning,
        Danger,
        Link
    }


    public class Button : HtmlHelper.Button
    {
        public Button(ButtonType type, params BodyElement[] content) : base(content)
        {
            this.Class("btn");
            this.Class("btn-" + type.AsKebab());            
        }
    }

    public static partial class FluentApi
    {
        public static Button Button(ButtonType type, params BodyElement[] content)
        {
            return new Button(type, content);
        }        
    }
}