using System;
using Xunit;
using static HtmlHelper.HtmlHelpers;

namespace HtmlHelper.Tests
{
    public class TagTests
    {
        [Fact]
        public void EmptyTag()
        {
            // arrange 
            var tag = new Div();

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<div/>", html);
        }

        [Fact]
        public void TagWithContent()
        {
            // arrange 
            var tag = Div(_("content"));

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<div>content</div>", html);
        }

        [Fact]
        public void NestedTags()
        {
            // arrange 
            var tag = new Div(
                new Span());

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<div><span/></div>", html);
        }

        [Fact]
        public void Shorthand()
        {
            // arrange 
            var tag = Div(Span(_("qqq")));

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<div><span>qqq</span></div>", html);
        }
    }
}