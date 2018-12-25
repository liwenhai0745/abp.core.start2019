using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace abp.core.start2019.Branding
{
    [Dependency(ReplaceServices = true)]
    public class start2019BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "start2019";
    }
}
