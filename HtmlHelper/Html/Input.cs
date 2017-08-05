namespace HtmlHelper
{
    public enum InputType
    {
        Button,

        Text,

        // todo...
    }

    public class Input : Tag, IBodyElement
    {
        public InputType Type { get; }

        public new string Content { get; }

        public Input(InputType type, string content) : base("input", new Literal(content))
        {
            this.Type = type;
            this.Content = content;

            this.Attr("type", type.AsKebab());
        }
    }

    public static partial class FluentApi
    {
        public static Input Input(InputType type, string content)
        {
            return new Input(type, content);
        }
    }    
}