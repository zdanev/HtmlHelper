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
        public void NotEmptyTag()
        {
            // arrange 
            var tag = new Tag("foo", "bar");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<foo>bar</foo>", html);
        }
    }
}