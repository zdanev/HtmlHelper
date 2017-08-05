using System.Linq;
using static HtmlHelper.FluentApi;

namespace HtmlHelper.Bootstrap
{
    public interface IModalElement : IBodyElement
    {
    }

    public class Modal : Div
    {
        public Modal(params IModalElement[] elements) 
            : base(Div(elements.Cast<BodyElement>().ToArray()).Class("modal-dialog").Attr("role", "document"))
        {
            this.Class("modal");
            this.Class("fade");            
        }
    }

    public class SmallModal
    {

    }

    public class LargeModal
    {

    }

    public class ModalHeader : Div
    {
        public ModalHeader(params BodyElement[] content)
        {
            this.Class("modal-header");
        }
    }

    public class ModalBody : Div
    {
        public ModalBody(params BodyElement[] content)
        {
            this.Class("modal-body");
        }
    }

    public class ModalFooter : Div
    {
        public ModalFooter(params BodyElement[] content)
        {
            this.Class("modal-footer");
        }
    }

    public static partial class FluentApi
    {
        public static Modal Modal(params IModalElement[] elements)
        {
            return new Modal(elements);
        }

        public static ModalHeader ModalHeader(params BodyElement[] content)
        {
            return new ModalHeader(content);
        }

        public static ModalBody ModalBody(params BodyElement[] content)
        {
            return new ModalBody(content);
        }

        public static ModalFooter ModalFooter(params BodyElement[] content)
        {
            return new ModalFooter(content);
        }
    }
}