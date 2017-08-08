using System.Linq;
using static HtmlHelper.FluentApi;

namespace HtmlHelper.Bootstrap
{
    public interface IModalElement : IBodyElement
    {
    }

    public class Modal : Div
    {
        public Modal(params IModalElement[] elements) : base()
        {
            this.Class("modal");
            this.Class("fade"); 

            var modalDialog = Div().Class("modal-dialog").Attr("role", "document");
            var modalContent = Div().Class("modal-content");    

            this.Content.Add(modalDialog);
            modalDialog.Content.Add(modalContent);
            modalContent.Content.AddRange(elements); 
        }
    }

    public class SmallModal
    {

    }

    public class LargeModal
    {

    }

    public interface IModalHeaderElement : IBodyElement
    {
    }

    public class ModalHeader : Div, IModalElement
    {
        public ModalHeader(params IModalHeaderElement[] content) : base(content)
        {
            this.Class("modal-header");
        }
    }

    public class ModalBody : Div, IModalElement
    {
        public ModalBody(params BodyElement[] content) : base(content)
        {
            this.Class("modal-body");
        }
    }

    public class ModalFooter : Div, IModalElement
    {
        public ModalFooter(params BodyElement[] content) : base(content)
        {
            this.Class("modal-footer");
        }
    }

    public class ModalTitle : H5, IModalHeaderElement
    {
        public ModalTitle(params BodyElement[] content) : base(content)
        {
            this.Class("modal-title");
        }
    }

    public static partial class FluentApi
    {
        public static Modal Modal(params IModalElement[] elements) => new Modal(elements);

        public static ModalHeader ModalHeader(params IModalHeaderElement[] content) => new ModalHeader(content);

        public static ModalBody ModalBody(params BodyElement[] content) => new ModalBody(content);

        public static ModalFooter ModalFooter(params BodyElement[] content) => new ModalFooter(content);
        
        public static ModalTitle ModalTitle(params BodyElement[] content) => new ModalTitle(content);
    }
}