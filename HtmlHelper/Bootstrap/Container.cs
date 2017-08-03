namespace HtmlHelper.Bootstrap
{
    public class Container : Div
    {
        public Container(params BodyElement[] content) : base(content)
        {
            AddClass("container");
        }
    }

    public class FluidContainer : Div
    {
        public FluidContainer(params BodyElement[] content) : base(content)
        {
            AddClass("container-fluid");
        }
    }

    public static partial class Helpers
    {
        public static Container Container(params BodyElement[] content)
        {
            return new Container(content);
        }

        public static FluidContainer FluidContainer(params BodyElement[] content)
        {
            return new FluidContainer(content);
        }
    }
}