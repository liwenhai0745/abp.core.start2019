using abp.core.start2019.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace abp.core.start2019
{
    [DependsOn(
        typeof(start2019DomainModule),
        typeof(AbpIdentityApplicationModule))]
    public class start2019ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<start2019PermissionDefinitionProvider>();
            });

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<start2019ApplicationAutoMapperProfile>();
            });
        }
    }
}
