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
                FluidContainer(
                    DismissibleAlert(AlertType.Success, "Success!")
                )
            );
            
            var html = page.Render();

            SaveToFile(".\\test.html", html);
        }

        private void SaveToFile(string fileName, string text)
        {
            using (var file = new StreamWriter(fileName))
            {
                file.Write(text);
            }
        }
    }
}