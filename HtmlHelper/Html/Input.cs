namespace HtmlHelper
{
    public enum InputType
    {
        Button,
        
        Text,

        // todo...
    }

    public class Input : Tag
    {
        public InputType Type { get; }

        public string Content { get; }

        public Input(InputType type, string content) : base("input", new Literal(content))
        {
            this.Type = type;
            this.Content = content;

            this.Attr("type", type.ToString().ToLower());
        }
    }
}