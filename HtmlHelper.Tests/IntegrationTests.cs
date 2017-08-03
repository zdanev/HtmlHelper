using System.IO;
using HtmlHelper.Bootstrap;
using Xunit;
using static HtmlHelper.Helpers;
using static HtmlHelper.Bootstrap.Helpers;

namespace HtmlHelper.Tests
{
    public class IntegrationTests
    {
        [Fact]
        public void IntegrationTest()
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
                    )
                ),
                Footer(
                    Span("footer").Class("text-muted")
                )
            );
            
            // act
            var html = page.Render();

            // assert
            html.SaveToFile(".\\test.html");
        }
    }
}