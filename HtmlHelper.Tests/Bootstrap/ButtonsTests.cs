using Xunit;
using HtmlHelper.Bootstrap;
using static HtmlHelper.Bootstrap.FluentApi;

namespace HtmlHelper.Tests
{
    public class ButtonsTests
    {
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