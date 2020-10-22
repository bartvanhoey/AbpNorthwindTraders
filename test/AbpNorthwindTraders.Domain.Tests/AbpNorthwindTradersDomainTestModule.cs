using AbpNorthwindTraders.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpNorthwindTraders
{
    [DependsOn(
        typeof(AbpNorthwindTradersEntityFrameworkCoreTestModule)
        )]
    public class AbpNorthwindTradersDomainTestModule : AbpModule
    {

    }
}