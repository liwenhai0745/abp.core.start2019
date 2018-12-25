using Volo.Abp;

namespace abp.core.start2019
{
    public abstract class start2019ApplicationTestBase : AbpIntegratedTest<start2019ApplicationTestModule>
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
