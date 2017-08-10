using Xunit;
using HtmlHelper.Bootstrap;
using static HtmlHelper.FluentApi;
using static HtmlHelper.Bootstrap.FluentApi;

namespace HtmlHelper.Tests
{
    public class ModalTests
    {
        [Fact]
        public void ModalTest()
        {
            // arrange
            var modal = Modal(
                ModalHeader(
                    ModalTitle("Modal Title")
                ),
                ModalBody(
                    P("Modal Body Text")
                ),
                ModalFooter(
                    Button(ButtonType.Primary, "Save Changes"),
                    Button(ButtonType.Secondary, "Close").Attr("data-dismiss", "modal") // todo
                )
            );

            // act
            var html = modal.Render();

            // assert
            Assert.Equal(
                "<div class='modal fade'>" +
                    "<div class='modal-dialog' role='document'>" + 
                        "<div class='modal-content'>" + 
                            "<div class='modal-header'>" +
                                "<h5 class='modal-title'>Modal Title</h5>" +
                            "</div>" +
                            "<div class='modal-body'>" +
                                "<p>Modal Body Text</p>" +
                            "</div>" +
                            "<div class='modal-footer'>" +
                                "<button type='button' class='btn btn-primary'>Save Changes</button>" +
                                "<button type='button' class='btn btn-secondary' data-dismiss='modal'>Close</button>" +
                            "</div>" +
                        "</div>" +
                    "</div>" +
                "</div>",
                html);
        }

        [Fact]
        public void ButtonShowModalTest()
        {
            // arrange
            var button = new Button("Show Modal").OnClick(ShowModal("my-modal"));

            // act
            var html = button.Render();

            // assert
            Assert.Equal("<button type='button' onclick='$(\"#my-modal\").modal(\"show\")'>Show Modal</button>", html);
        }
    }
}