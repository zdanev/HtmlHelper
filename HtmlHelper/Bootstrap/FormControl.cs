namespace HtmlHelper.Bootstrap
{
    public class FormControl : Input, InputGroupElement
    {
        public FormControl(InputType type, params BodyElement[] content) : base(type, content)
        {
            this.Class("form-control");
        }
    }

    public static partial class FluentApi
    {
        public static FormControl FormControl(InputType type, params BodyElement[] content)
        {
            return new FormControl(type, content);
        }
    }
}