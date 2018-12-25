using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace abp.core.start2019
{
    public class start2019WebTestStartup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<start2019WebTestModule>(options =>
            {
                options.UseAutofac();
            });

            return services.BuildServiceProviderFromFactory();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}