using abp.core.start2019.Localization.start2019;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace abp.core.start2019.Pages
{
    public abstract class start2019PageModelBase : AbpPageModel
    {
        protected start2019PageModelBase()
        {
            LocalizationResourceType = typeof(start2019Resource);
        }
    }
}