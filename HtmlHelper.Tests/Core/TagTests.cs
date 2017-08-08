using Xunit;
using static HtmlHelper.FluentApi;

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
            var tag = Div("content");

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
            var tag = Div(Span("test"));

            // act
            var html = tag.Render();

            // assert
            Assert.Equal("<div><span>test</span></div>", html);
        }
    }
}