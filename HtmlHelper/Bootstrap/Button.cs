namespace HtmlHelper.Bootstrap
{
    public enum ButtonType
    {
        Default,
        Primary,
        Secondary,
        Success,
        Info,
        Warning,
        Danger,
        Link
    }

    public enum ButtonSize
    {
        Large,
        Small
    }

    public class Button : HtmlHelper.Button, IDropdownElement
    {
        public Button(ButtonType type, params BodyElement[] content) : base(content)
        {
            this.Class("btn");
            this.Class("btn-" + type.AsKebab());            
        }

        public Button(ButtonType type, ButtonSize size, params BodyElement[] content) : base(content)
        {
            this.Class("btn");
            this.Class("btn-" + type.AsKebab());

            switch (size)
            {
                case ButtonSize.Small:
                    this.Class("btn-sm");
                    break;
                case ButtonSize.Large:
                    this.Class("btn-lg");
                    break;
            }    
        }
    }

    public class BlockButton : Button
    {
        public BlockButton(ButtonType type, params BodyElement[] content) : base (type, content)
        {
            this.Class("btn-block");            
        }

        public BlockButton(ButtonType type, ButtonSize size, params BodyElement[] content) : base (type, size, content)
        {
            this.Class("btn-block");            
        }
    }

    public class OutlineButton : HtmlHelper.Button
    {
        public OutlineButton(ButtonType type, params BodyElement[] content) : base(content)
        {
            this.Class("btn");
            this.Class("btn-outline-" + type.AsKebab());            
        }

        public OutlineButton(ButtonType type, ButtonSize size, params BodyElement[] content) : base(content)
        {
            this.Class("btn");
            this.Class("btn-outline-" + type.AsKebab());            

            switch (size)
            {
                case ButtonSize.Small:
                    this.Class("btn-sm");
                    break;
                case ButtonSize.Large:
                    this.Class("btn-lg");
                    break;
            }    
        }
    }
    
    public static partial class FluentApi
    {
        public static Button Button(ButtonType type, params BodyElement[] content)
        {
            return new Button(type, content);
        } 
               
        public static Button Button(ButtonType type, ButtonSize size, params BodyElement[] content)
        {
            return new Button(type, size, content);
        } 
               
        public static BlockButton BlockButton(ButtonType type, ButtonSize size, params BodyElement[] content)
        {
            return new BlockButton(type, size, content);
        } 
               
        public static BlockButton BlockButton(ButtonType type, params BodyElement[] content)
        {
            return new BlockButton(type, content);
        } 
               
        public static OutlineButton OutlineButton(ButtonType type, params BodyElement[] content)
        {
            return new OutlineButton(type, content);
        }        
               
        public static OutlineButton OutlineButton(ButtonType type, ButtonSize size, params BodyElement[] content)
        {
            return new OutlineButton(type, size, content);
        }        
    }
}