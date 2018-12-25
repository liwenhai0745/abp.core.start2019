using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using abp.core.start2019.Localization.start2019;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace abp.core.start2019.Pages
{
    public abstract class start2019PageBase : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<start2019Resource> L { get; set; }
    }
}
