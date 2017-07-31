using System;
using Xunit;
using static HtmlHelper.HtmlHelpers;

namespace HtmlHelper.Tests
{
    public class MiscTagTests
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
        
        [Fact]
        public void AnchorTest()
        {
            // arrange 
            var tag = Anchor("http://google.com/", "google");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<a href=\"http://google.com/\">google</a>", html);            
        }
    }
}