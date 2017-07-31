using System;
using Xunit;
using static HtmlHelper.HtmlHelpers;

namespace HtmlHelper.Tests
{
    public class HtmlTests
    {
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
    }
}