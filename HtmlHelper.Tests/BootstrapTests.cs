using System;
using Xunit;
using HtmlHelper.Bootstrap;
using static HtmlHelper.FluentApi;
using static HtmlHelper.Bootstrap.FluentApi;

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
            Assert.Equal("<div class='alert alert-success' role='alert'>alert</div>", html);
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
                "<div class='alert alert-info' role='alert'>" + 
                    "<strong>Heads up!</strong> This <a href='#' class='alert-link'>alert needs your attention</a>, but it's not super important." + 
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
                "<div class='alert alert-warning alert-dismissible fade show' role='alert'>" + 
                    "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                        "<span aria-hidden='true'>&times;</span>" +
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
            Assert.Equal("<span class='badge badge-default'>99</span>", html);
        }

        [Fact]
        public void PillBadgeTest()
        {
            // arrange
            var tag = PillBadge("99");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<span class='badge badge-default badge-pill'>99</span>", html);
        }

        [Fact]
        public void NavBarTest()
        {
            // arrange
            var nav = NavBar(
                NavBarToggler(),
                NavBarLinkBrand("MyApp", "#"),
                NavBarItems(
                    NavBarItem("Item 1", "#", true),
                    NavBarItem("Item 2", "#"),
                    NavBarItem("Item 3", "#")
                )
            );

            // act
            var html = nav.Render();

            // assert
            Assert.Equal(
                "<nav class='navbar navbar-toggleable-md navbar-inverse bg-inverse'>" + 
                    "<button type='button' class='navbar-toggler navbar-toggler-right' data-toggle='collapse' data-target='#navbarSupportedContent' aria-controls='navbarSupportedContent' aria-expanded='false' aria-label='Toggle navigation'>" + 
                        "<span class='navbar-toggler-icon'></span>" + 
                    "</button>" + 
                    "<a href='#' class='navbar-brand'>MyApp</a>" + 
                    "<div class='collapse navbar-collapse' id='navbarSupportedContent'>" + 
                        "<ul class='navbar-nav mr-auto'>" + 
                            "<li class='nav-item active'><a href='#' class='nav-link'>Item 1</a></li>" + 
                            "<li class='nav-item'><a href='#' class='nav-link'>Item 2</a></li>" + 
                            "<li class='nav-item'><a href='#' class='nav-link'>Item 3</a></li>" + 
                        "</ul>" + 
                    "</div>" +
                "</nav>", 
                html);
        }

        [Fact]
        public void FooterTest()
        {
            // arrange
            var footer = Footer(Span("footer text"));
             
            // act
            var html = footer.Render();
 
            // assert
            Assert.Equal(
                "<footer class='footer'>" +
                    "<div class='container'>" +
                        "<span>footer text</span>" +
                    "</div>" +
                "</footer>",
                html);
        }        
    }
}