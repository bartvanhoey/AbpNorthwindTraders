using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpNorthwindTraders.Data
{
    /* This is used if database provider does't define
     * IAbpNorthwindTradersDbSchemaMigrator implementation.
     */
    public class NullAbpNorthwindTradersDbSchemaMigrator : IAbpNorthwindTradersDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}