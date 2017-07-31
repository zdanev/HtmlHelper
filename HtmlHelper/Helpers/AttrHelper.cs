namespace HtmlHelper
{
    public static partial class HtmlHelpers
    {
        public static Tag Attr(this Tag tag, params HtmlAttribute[] attrsibutes)
        {
            tag.Attributes.AddRange(attrsibutes);
            
            return tag;
        }        

        public static Tag Attr(this Tag tag, string name, string value)
        {
            tag.Attributes.Add(new HtmlAttribute(name, value));
            
            return tag;
        }        
    }
}