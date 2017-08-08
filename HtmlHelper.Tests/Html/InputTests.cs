using Xunit;
using static HtmlHelper.FluentApi;

namespace HtmlHelper.Tests
{
    public class InputTests
    {
        [Fact]
        public void InputTest()
        {
            // arrange 
            var input = Input(InputType.Button, "click me");

            // act
            var html = input.Render();

            // assert
            Assert.Equal("<input type='button'>click me</input>", html);
        }

        [Fact]
        public void SelectTest()
        {
            // arrange
            var select = Select(
                Option("1"),
                Option("2"),
                Option("3")
            );

            // act
            var html = select.Render();

            // assert
            Assert.Equal(
                "<select>" + 
                    "<option>1</option>" +
                    "<option>2</option>" +
                    "<option>3</option>" +
                "</select>",
                html
            );  
        }

        [Fact]
        public void LabelForTest()
        {
            // arrange 
            var label = LabelFor("input1", "Input 1");

            // act
            var html = label.Render();

            // assert
            Assert.Equal("<label for='input1'>Input 1</label>", html);
        }
    }
}