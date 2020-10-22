using AbpNorthwindTraders.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpNorthwindTraders.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpNorthwindTradersEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpNorthwindTradersApplicationContractsModule)
        )]
    public class AbpNorthwindTradersDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
