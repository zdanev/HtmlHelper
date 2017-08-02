using System;
using Xunit;
using HtmlHelper.Bootstrap;
using static HtmlHelper.Helpers;
using static HtmlHelper.Bootstrap.Helpers;

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
            var tag = new Alert(AlertType.Success, "alert");

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
                " This ",
                Anchor("#", "alert needs your attention"),
                ", but it's not super important.");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal(
                "<div class=\"alert alert-info\" role=\"alert\">" + 
                    "<strong>Heads up!</strong> This <a href=\"#\" class=\"alert-link\">alert needs your attention</a>, but it's not super important." + 
                "</div>", 
                html);
        }

        [Fact]
        public void BootstrapDismissableAlert()
        {
            // arrange
            var tag = new DismissibleAlert(AlertType.Warning,
                Strong("Holy guacamole!"),
                " You should check in on some of those fields below.");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal(
                "<div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">" + 
                    "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">" +
                        "<span aria-hidden=\"true\">&times;</span>" +
                    "</button>" +
                    "<strong>Holy guacamole!</strong> You should check in on some of those fields below." +
                "</div>", 
                html);
        }

        [Fact]
        public void BadgeTest()
        {
            // arrange
            var tag = Badge("99");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<span class=\"badge badge-default\">99</span>", html);
        }

        [Fact]
        public void PillBadgeTest()
        {
            // arrange
            var tag = PillBadge("99");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<span class=\"badge badge-default badge-pill\">99</span>", html);
        }
    }
}