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

        [Fact]
        public void ScriptSrcTest()
        {
            // arrange
            var tag = Script("my-script.js");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<script src=\"my-script.js\"></script>", html);            
        }

        [Fact]
        public void LinkTest()
        {
            // arrange
            var tag = Link(LinkRel.Stylesheet, LinkType.Text_Css, "stylesheet.css");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<link rel=\"stylesheet\" type=\"text/css\" href=\"stylesheet.css\"/>", html);            
        }        

        [Fact]
        public void MetaTest()
        {
            // arrange
            var tag = Meta("charset", "utf-8");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<meta charset=\"utf-8\"/>", html);            
        }        
    }
}