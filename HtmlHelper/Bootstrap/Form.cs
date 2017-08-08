namespace HtmlHelper.Bootstrap
{
    public interface IFormGroupElement : IBodyElement
    {        
    }

    public class FormGroup : Div
    {
        public FormGroup(params IFormGroupElement[] content) : base(content)
        {
            this.Class("form-group");            
        }
    }

    public class FormControl : Input, IFormGroupElement, IInputGroupElement
    {
        public FormControl(InputType type, params BodyElement[] content) : base(type, content)
        {
            this.Class("form-control");
        }
    }

    public class FormLabel : Label, IFormGroupElement
    {
        public FormLabel(params BodyElement[] content) : base(content)
        {
        }
    }

    public static partial class FluentApi
    {
        public static FormGroup FormGroup(params IFormGroupElement[] content) => new FormGroup(content);

        public static FormControl FormControl(InputType type, params BodyElement[] content) => new FormControl(type, content);

        public static FormLabel FormLabel(params BodyElement[] content) => new FormLabel(content);

        public static FormLabel FormLabelFor(string id, params BodyElement[] content) => new FormLabel(content).Attr("for", id); 
    }
}