using static HtmlHelper.Helpers;

namespace HtmlHelper.Bootstrap
{
    public interface INavBarElement : IBodyElement
    {        
    }
    
    public class NavBar : BodyElement
    {
        public NavBar(params INavBarElement[] content) : base("nav", content)
        {
            AddClass("navbar"); 
            AddClass("navbar-toggleable-md"); 
            // AddClass("navbar-light"); 
            // AddClass("bg-faded");   
            AddClass("navbar-inverse");         
            AddClass("bg-inverse");            
        }
    }

    public class NavBarToggler : Button, INavBarElement
    {
        public NavBarToggler() : base(Span("").Class("navbar-toggler-icon"))
        {
            AddClass("navbar-toggler");
            AddClass("navbar-toggler-right");

            Attr("data-toggle", "collapse");
            Attr("data-target", "#navbarSupportedContent");
            Attr("aria-controls", "navbarSupportedContent");
            Attr("aria-expanded", "false");
            Attr("aria-label", "Toggle navigation");
        }
    }

    public class NavBarBrand : Anchor, INavBarElement
    {
        public NavBarBrand(string title, string href) : base(href, title)
        {
            AddClass("navbar-brand");
        }
    }

    public class NavBarItems : Div, INavBarElement
    {
        public NavBarItems(params NavBarItem[] items) : base(UL(items).Class("navbar-nav").Class("mr-auto"))
        {
            AddClass("collapse");
            AddClass("navbar-collapse");
            Attr("id", "navbarSupportedContent"); // todo: ...?!?            
        }
    }

    public class NavBarItem : ListItem
    {
        public NavBarItem(string title, string href, bool isActive = false)
            : base(Anchor(href, title).Class("nav-link"))
        {
            AddClass("nav-item");            

            if (isActive)
            {
                AddClass("active");
            }
        }
    }

    public static partial class Helpers
    {
        public static NavBar NavBar(params INavBarElement[] content)
        {
            return new NavBar(content);
        }

        public static NavBarToggler NavBarToggler()
        {
            return new NavBarToggler();
        }

        public static NavBarBrand NavBarBrand(string title, string href)
        {
            return new NavBarBrand(title, href);
        }

        public static NavBarItems NavBarItems(params NavBarItem[] items)
        {
            return new NavBarItems(items);
        }
        
        public static NavBarItem NavBarItem(string title, string href, bool isActive = false)
        {
            return new NavBarItem(title, href, isActive);
            
        }
    }
}