using Xunit;
using HtmlHelper.Bootstrap;
using static HtmlHelper.Bootstrap.FluentApi;

namespace HtmlHelper.Tests
{
    public class DropdownTests
    {
        [Fact]
        public void DropdownTest()
        {
            // arrange
            var dropdown = Dropdown(
                Button(ButtonType.Default, "Options"),
                DropdownMenu(
                    DropdownHeader("Header"),
                    DropdownItem("#", "item 1"),
                    DropdownItem("#", "item 2"),
                    DropdownDivider(),
                    DropdownItem("#", "item 3")
                )
            );

            // act
            var html = dropdown.Render();

            // assert
            Assert.Equal(
                "<div class='dropdown'>" +
                    "<button type='button' class='btn btn-default'>Options</button>" +
                    "<div class='dropdown-menu'>" +
                        "<h6 class='dropdown-header'>Header</h6>" +
                        "<a href='#' class='dropdown-item'>item 1</a>" +
                        "<a href='#' class='dropdown-item'>item 2</a>" +
                        "<div class='dropdown-divider'/>" +
                        "<a href='#' class='dropdown-item'>item 3</a>" +
                    "</div>" +
                "</div>",
                html
            );  
        }
    }
}