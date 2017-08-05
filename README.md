# HtmlHelper
A set of c# classes to generate "correct" html, css, bootstap, etc.

``` c#
using static HtmlHelper.FluentApi;

var button = Button("Click Me").Id("my-button").OnClick("buttonClicked();");

Assert.Equal(
    "<button type='button' id='my-button' onclick='buttonClicked();'>Click Me</button>", 
    button.Render());
```