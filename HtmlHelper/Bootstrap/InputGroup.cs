namespace HtmlHelper.Bootstrap
{
    public interface IInputGroupElement : IBodyElement
    {  
    }

    public class InputGroup : Div, IButtonToolbarElement
    {
        public InputGroup(params IInputGroupElement[] content) : base(content)
        {
            this.Class("input-group");            
        }
    }

    public class InputGroupAddOn : Span, IInputGroupElement
    {
        public InputGroupAddOn(params BodyElement[] content) : base(content)
        {
            this.Class("input-group-addon");   
        }
    }

    public static partial class FluentApi
    {
        public static InputGroup InputGroup(params IInputGroupElement[] content) => new InputGroup(content);

        public static InputGroupAddOn InputGroupAddOn(params BodyElement[] content)  => new InputGroupAddOn(content);
    }
}