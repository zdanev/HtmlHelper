using System;
using Xunit;

namespace HtmlHelper.Tests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            // arrange 
            var tag = new Tag("test");

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<test/>", html);
        }
    }
}