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

        [Fact]
        public void SuccessButtonTest()
        {
            // arrange
            var button = Button(ButtonType.Success, "Success!");

            // act
            var html = button.Render();

            // assert
            Assert.Equal("<button type='button' class='btn btn-success'>Success!</button>", html);
        }     

        [Fact]
        public void LargeDangerButtonTest()
        {
            // arrange
            var button = Button(ButtonType.Danger, ButtonSize.Large, "Danger!");

            // act
            var html = button.Render();

            // assert
            Assert.Equal("<button type='button' class='btn btn-danger btn-lg'>Danger!</button>", html);
        }     

        [Fact]
        public void OutlineButtonTest()
        {
            // arrange
            var button = OutlineButton(ButtonType.Primary, "Click me!");

            // act
            var html = button.Render();

            // assert
            Assert.Equal("<button type='button' class='btn btn-outline-primary'>Click me!</button>", html);
        }

        [Fact]
        public void SmallOutlineButtonTest()
        {
            // arrange
            var button = OutlineButton(ButtonType.Info, ButtonSize.Small, "Click for more info!");

            // act
            var html = button.Render();

            // assert
            Assert.Equal("<button type='button' class='btn btn-outline-info btn-sm'>Click for more info!</button>", html);
        }     

        [Fact]
        public void BlockButtonTest()
        {
            // arrange
            var button = BlockButton(ButtonType.Default, "Block Level Button");

            // act
            var html = button.Render();

            // assert
            Assert.Equal("<button type='button' class='btn btn-default btn-block'>Block Level Button</button>", html);
        }    

        [Fact]
        public void ButtonGroupTest()
        {
            // arrange
            var group = ButtonGroup(
                Button(ButtonType.Default, "Button 1"),
                Button(ButtonType.Default, "Button 2"),
                Button(ButtonType.Default, "Button 3"));

            // act
            var html = group.Render();

            // assert
            Assert.Equal(
                "<div class='btn-group' role='group'>" + 
                    "<button type='button' class='btn btn-default'>Button 1</button>" +
                    "<button type='button' class='btn btn-default'>Button 2</button>" +
                    "<button type='button' class='btn btn-default'>Button 3</button>" +
                "</div>",
                html);
        }

        [Fact]
        public void ButtonToolbarTest()
        {
            // arrange
            var toolbar = ButtonToolbar(
                ButtonGroup(
                    Button(ButtonType.Default, "1"),
                    Button(ButtonType.Default, "2"),
                    Button(ButtonType.Default, "3")
                ),
                ButtonGroup(
                    Button(ButtonType.Default, "4"),
                    Button(ButtonType.Default, "5")
                ),
                ButtonGroup(
                    Button(ButtonType.Default, "6")
                )
            );

            // act
            var html = toolbar.Render();

            // assert
            Assert.Equal(
                "<div class='btn-toolbar' role='toolbar'>" + 
                    "<div class='btn-group' role='group'>" + 
                        "<button type='button' class='btn btn-default'>1</button>" +
                        "<button type='button' class='btn btn-default'>2</button>" +
                        "<button type='button' class='btn btn-default'>3</button>" +
                    "</div>" +
                    "<div class='btn-group' role='group'>" + 
                        "<button type='button' class='btn btn-default'>4</button>" +
                        "<button type='button' class='btn btn-default'>5</button>" +
                    "</div>" +
                    "<div class='btn-group' role='group'>" + 
                        "<button type='button' class='btn btn-default'>6</button>" +
                    "</div>" +
                "</div>",
                html);
        }

        [Fact]
        public void ButtonToolbarWithInputGroup()
        {
            // arrange
            var toolbar = ButtonToolbar(
                ButtonGroup(
                    Button(ButtonType.Default, "1"),
                    Button(ButtonType.Default, "2"),
                    Button(ButtonType.Default, "3")
                ),
                InputGroup(
                    InputGroupAddOn("@"),
                    FormControl(InputType.Text)
                )
            );

            // act
            var html = toolbar.Render();

            // assert
            Assert.Equal(
                "<div class='btn-toolbar' role='toolbar'>" + 
                    "<div class='btn-group' role='group'>" + 
                        "<button type='button' class='btn btn-default'>1</button>" +
                        "<button type='button' class='btn btn-default'>2</button>" +
                        "<button type='button' class='btn btn-default'>3</button>" +
                    "</div>" +
                    "<div class='input-group'>" +
                        "<span class='input-group-addon'>@</span>" +
                        "<input type='text' class='form-control'/>" +
                    "</div>" +
                "</div>",
                html);
        }            
    } 
}