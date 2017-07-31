using System;
using Xunit;
using static HtmlHelper.HtmlHelpers;

namespace HtmlHelper.Tests
{
    public class InputTests
    {
        [Fact]
        public void InputTypeText()
        {
            // arrange 
            var tag = Input(InputType.Button, "click me");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<input type=\"button\">click me</input>", html);
        }
    }
}