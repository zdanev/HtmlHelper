using System;
using System.Linq;
using Xunit;
using static HtmlHelper.FluentApi;

namespace HtmlHelper.Tests
{
    public class HtmlTests
    {
        [Fact]
        public void LiteralTest()
        {
            Literal literal = "test";

            Assert.Equal(literal.Value, "test");

            var div = Div("test");

            Assert.Equal(((Literal)div.Content.First()).Value, "test");            
        }

        [Fact]
        public void EmptyHtml()
        {
            // arrange 
            var tag = new Html(
                new Head(),
                new Body()
            );

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<html><head/><body/></html>", html);
        }

        [Fact]
        public void EmptyHtmlWithShorthand()
        {
            // arrange 
            var tag = Html(
                Head(),
                Body()
            );

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<html><head/><body/></html>", html);
        }        

        [Fact]
        public void HeadWithTitle()
        {
            // arrange 
            var tag = Html(
                Head(
                    Title("my title")
                ),
                Body()
            );

            // act
            var html = tag.Render();

            // assert
            Assert.Equal(
                "<html>" + 
                    "<head>" + 
                        "<title>my title</title>" + 
                    "</head>" + 
                    "<body/>" + 
                "</html>", 
                html);
        }        

        [Fact]
        public void HeadWithStylesheet()
        {
            // arrange 
            var tag = Html(
                Head(
                    Title("my title"),
                    Link(LinkRel.Stylesheet, LinkType.Text_Css, "stylesheet.css"),
                    Script("script.js")                    
                ),
                Body(
                    Div().Class("container")
                )
            );

            // act
            var html = tag.Render();

            // assert
            Assert.Equal(
                "<html>" + 
                    "<head>" + 
                        "<title>my title</title>" + 
                        "<link rel='stylesheet' type='text/css' href='stylesheet.css'/>" + 
                        "<script src='script.js'></script>" +
                    "</head>" + 
                    "<body>" + 
                        "<div class='container'/>" + 
                    "</body>" + 
                "</html>", 
                html);
        }

        [Fact]
        public void HtmlWithDocType()
        {
            // arrange 
            var page = HtmlPage(
                Html(
                    Head(),
                    Body()
                )
            );

            // act
            var html = page.Render();

            // assert
            Assert.Equal("<!DOCTYPE html><html><head/><body/></html>", html);
        }        
    }
}