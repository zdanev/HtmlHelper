namespace HtmlHelper
{
    public class UnorderedList : BodyElement
    {
        public UnorderedList(params ListItem[] items) : base("ul", items)
        {
        }
    }

    public class OrderedList : BodyElement
    {
        public OrderedList(params ListItem[] items) : base("ol", items)
        {            
        }
    }

    public class ListItem : BodyElement
    {
        public ListItem(params BodyElement[] content) : base("li", content)
        {            
        }
    }

    public static partial class Helpers
    {
        public static UnorderedList UL(params ListItem[] items)
        {
            return new UnorderedList(items);
        }

        public static OrderedList OL(params ListItem[] items)
        {
            return new OrderedList(items);
        }

        public static ListItem LI(params BodyElement[] content)
        {
            return new ListItem(content);
        }
    }
}