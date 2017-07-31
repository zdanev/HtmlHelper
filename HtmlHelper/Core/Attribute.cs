namespace HtmlHelper
{
    public class HtmlAttribute
    {
        public string Name { get; }

        public string Value { get; }

        public HtmlAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}