using System;
using Xunit;

namespace HtmlHelper.Tests
{
    public class Tests
    {
        [Fact]
        public void EmptyTag()
        {
            // arrange 
            var tag = new Tag("test");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<test/>", html);
        }

        [Fact]
        public void TagWithContent()
        {
            // arrange 
            var tag = new Tag("foo", new Literal("bar"));

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<foo>bar</foo>", html);
        }

        [Fact]
        public void NestedTags()
        {
            // arrange 
            var tag = new Tag("foo", 
                new Tag("bar"));

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<foo><bar/></foo>", html);
        }
    }
}