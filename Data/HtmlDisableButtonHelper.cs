using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace authb2cweb.TagHelpers
{
    public static class HtmlExtensions
    {
        public static IHtmlContent DisabledIf(this IHtmlHelper htmlHelper,
                                              bool condition)
        => new HtmlString(condition ? "disabled=\"disabled\"" : "");
    }
}