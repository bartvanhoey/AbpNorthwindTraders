using System.Threading.Tasks;

namespace AbpNorthwindTraders.Data
{
    public interface IAbpNorthwindTradersDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
