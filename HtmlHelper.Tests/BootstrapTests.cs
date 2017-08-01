using System;
using Xunit;
using HtmlHelper.Bootstrap;
using static HtmlHelper.HtmlHelpers;

namespace HtmlHelper.Tests
{
    public class BootstrapTests
    {
        [Fact]
        public void EmptyBootstrapPage()
        {
            // arrange 
            var page = new BootstrapPage("title");

            // act
            var html = page.Render();

            // assert
            Assert.NotNull(html);
        }

        [Fact]
        public void BootstrapAlert()
        {
            // arrange
            var tag = new Alert(AlertType.Success, _("alert"));

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<div class=\"alert alert-success\" role=\"alert\">alert</div>", html);
        }

        [Fact]
        public void BootstrapAlertWithLink()
        {
            // arrange
            var tag = new Alert(AlertType.Info, 
                Strong("Heads up!"),
                _(" This "),
                Anchor("#", "alert needs your attention"),
                _(", but it's not super important."));

            // act
            var html = tag.Render();

            // assert
            Assert.Equal(
                "<div class=\"alert alert-info\" role=\"alert\">" + 
                    "<strong>Heads up!</strong> This <a href=\"#\" class=\"alert-link\">alert needs your attention</a>, but it's not super important." + 
                "</div>", 
                html);
        }
    }
}