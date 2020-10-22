using Volo.Abp.Modularity;

namespace AbpNorthwindTraders
{
    [DependsOn(
        typeof(AbpNorthwindTradersApplicationModule),
        typeof(AbpNorthwindTradersDomainTestModule)
        )]
    public class AbpNorthwindTradersApplicationTestModule : AbpModule
    {

    }
}