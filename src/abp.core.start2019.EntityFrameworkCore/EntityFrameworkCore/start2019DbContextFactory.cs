using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace abp.core.start2019.EntityFrameworkCore
{
    public class start2019DbContextFactory : IDesignTimeDbContextFactory<start2019DbContext>
    {
        public start2019DbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<start2019DbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"))
                ;
                

            return new start2019DbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../abp.core.start2019.Web/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
