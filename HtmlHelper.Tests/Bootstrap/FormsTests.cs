using Xunit;
using static HtmlHelper.FluentApi;
using static HtmlHelper.Bootstrap.FluentApi;

namespace HtmlHelper.Bootstrap
{
    public class FormsTests
    {
        [Fact]
        public void FormGroupTest()
        {
            // arrange
            var formGroup = FormGroup(
                FormLabelFor("firstName", "First Name"),
                FormControl(InputType.Text).Id("firstName")
            );

            // act
            var html = formGroup.Render();

            // assert
            Assert.Equal(
                "<div class='form-group'>" + 
                    "<label for='firstName'>First Name</label>" + 
                    "<input type='text' class='form-control' id='firstName'/>" +
                "</div>",
                html);
        }
    }
}