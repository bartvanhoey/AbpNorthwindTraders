using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpNorthwindTraders.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpNorthwindTradersEntityFrameworkCoreModule)
        )]
    public class AbpNorthwindTradersEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpNorthwindTradersMigrationsDbContext>();
        }
    }
}
