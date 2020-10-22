using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpNorthwindTraders.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpNorthwindTradersHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpNorthwindTradersConsoleApiClientModule : AbpModule
    {
        
    }
}
