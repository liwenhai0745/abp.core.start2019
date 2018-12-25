using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace abp.core.start2019.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class start2019DbContext : AbpDbContext<start2019DbContext>
    {
        public start2019DbContext(DbContextOptions<start2019DbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureIdentity();
            modelBuilder.ConfigurePermissionManagement();
            modelBuilder.ConfigureSettingManagement();
            modelBuilder.ConfigureBackgroundJobs();
            modelBuilder.ConfigureAuditLogging();
        }
    }
}
