using System.IO;
using HtmlHelper.Bootstrap;
using Xunit;
using static HtmlHelper.Helpers;

namespace HtmlHelper.Tests
{
    public class IntegrationTests
    {
        [Fact]
        public void IntegrationTest()
        {
            var page = new BootstrapPage("test",
                new Alert(AlertType.Success, _("Success!")));
            
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