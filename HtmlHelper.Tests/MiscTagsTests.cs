using System;
using Xunit;
using static HtmlHelper.FluentApi;

namespace HtmlHelper.Tests
{
    public class MiscTagTests
    {
         [Fact]
        public void InputTypeTest()
        {
            // arrange 
            var input = Input(InputType.Button, "click me");

            // act
            var html = input.Render();

            // assert
            Assert.Equal("<input type='button'>click me</input>", html);
        }
        
        [Fact]
        public void AnchorTest()
        {
            // arrange 
            var anchor = Anchor("http://google.com/", "google");

            // act
            var html = anchor.Render();

            // assert
            Assert.Equal("<a href='http://google.com/'>google</a>", html);            
        }

        [Fact]
        public void ScriptSrcTest()
        {
            // arrange
            var script = Script("my-script.js");

            // act
            var html = script.Render();

            // assert
            Assert.Equal("<script src='my-script.js'></script>", html);            
        }

        [Fact]
        public void LinkTest()
        {
            // arrange
            var link = Link(LinkRel.Stylesheet, LinkType.Text_Css, "stylesheet.css");

            // act
            var html = link.Render();

            // assert
            Assert.Equal("<link rel='stylesheet' type='text/css' href='stylesheet.css'/>", html);            
        }        

        [Fact]
        public void MetaTest()
        {
            // arrange
            var meta = Meta("charset", "utf-8");

            // act
            var html = meta.Render();

            // assert
            Assert.Equal("<meta charset='utf-8'/>", html);            
        }    

        [Fact]
        public void StrongTest()
        {
            // arrange
            var strong = Strong("test");

            // act
            var html = strong.Render();

            // assert
            Assert.Equal("<strong>test</strong>", html);            
        }      

        [Fact]
        public void ButtonTest()
        {
            // arrange
            var button = Button("Click me!");

            // act
            var html = button.Render();

            // assert
            Assert.Equal("<button type='button'>Click me!</button>", html);            
        }

        [Fact]
        public void HeadingTest()
        {
            // arrange
            var h4 = H4("test");

            // act
            var html = h4.Render();

            // assert
            Assert.Equal("<h4>test</h4>", html);
        }
        
        [Fact]
        public void UnorderedListTest()
        {
            // arrange
            var ul = UL(
                LI("item1"),
                LI("item2"),
                LI("item3")
            );

            // act
            var html = ul.Render();

            // assert
            Assert.Equal(
                "<ul>" +
                    "<li>item1</li>" +
                    "<li>item2</li>" +
                    "<li>item3</li>" +
                "</ul>",
                html);
        }

        [Fact]
        public void TableTest()
        {
            // arrange
            var table = Table(
                TR(
                    TD(),
                    TD()
                ),
                TR(
                    TD(),
                    TD()
                )
            );

            // act
            var html = table.Render();

            // assert
            Assert.Equal(
                "<table>" + 
                    "<tr>" +
                        "<td/>" + 
                        "<td/>" +
                    "</tr>" +
                    "<tr>" +
                        "<td/>" + 
                        "<td/>" +
                    "</tr>" +
                "</table>",
                html);
        }

        [Fact]
        public void ParagraphTest()
        {
            // arrange
            var p = P("text");
        
            // act
            var html = p.Render();
        
            // assert
            Assert.Equal("<p>text</p>", html);
        }

        [Fact]
        public void ButtonWithIdAndClick()
        {
            // arrange
            var button = Button("Click Me").Id("my-button").OnClick("buttonClicked();");

            // act
            var html = button.Render();

            // assert
            Assert.Equal("<button type='button' id='my-button' onclick='buttonClicked();'>Click Me</button>", html);
        }
    }
}