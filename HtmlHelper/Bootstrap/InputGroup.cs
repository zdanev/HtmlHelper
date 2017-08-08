namespace HtmlHelper.Bootstrap
{
    public interface InputGroupElement : IBodyElement
    {  
    }

    public class InputGroup : Div, IButtonToolbarElement
    {
        public InputGroup(params InputGroupElement[] content) : base(content)
        {
            this.Class("input-group");            
        }
    }

    public class InputGroupAddOn : Span, InputGroupElement
    {
        public InputGroupAddOn(params BodyElement[] content) : base(content)
        {
            this.Class("input-group-addon");   
        }
    }

    public static partial class FluentApi
    {
        public static InputGroup InputGroup(params InputGroupElement[] content)
        {
            return new InputGroup(content);
        }

        public static InputGroupAddOn InputGroupAddOn(params BodyElement[] content)
        {
            return new InputGroupAddOn(content);
        }
    }
}