using FileStoring.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace FileStoring.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FileStoringEntityFrameworkCoreModule),
        typeof(FileStoringApplicationContractsModule)
        )]
    public class FileStoringDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
