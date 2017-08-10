using System.IO;
using HtmlHelper.Bootstrap;
using Xunit;
using static HtmlHelper.FluentApi;
using static HtmlHelper.Bootstrap.FluentApi;

namespace HtmlHelper.Tests
{
    public class DemoTests
    {
        [Fact]
        public void Demo1()
        {
            // arrange
            var page = new BootstrapPage("test",
                NavBar(
                    NavBarToggler(),
                    NavBarBrand("MyApp"),
                    NavBarItems(
                        NavBarItem("Menu 1", "#", true),
                        NavBarItem("Menu 2", "#"),
                        NavBarItem("Menu 3", "#")
                    )
                ),
                FluidGrid(
                    Row(
                        Cell(
                            DismissibleAlert(AlertType.Success, "Success!")
                        )
                    ),
                    Row(
                        Cell(
                            PrimaryButton("Show Modal").OnClick(ShowModal("my-modal"))
                        )
                    )
                ),
                Footer(
                    Span("footer").Class("text-muted")
                ),
                Modal(
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
                ).Id("my-modal")
            );
            
            // act
            var html = page.Render();

            // assert
            html.SaveToFile(".\\demo1.html");
        }
    }
}