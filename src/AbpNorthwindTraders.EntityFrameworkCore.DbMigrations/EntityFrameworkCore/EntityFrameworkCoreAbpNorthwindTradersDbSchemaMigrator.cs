using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpNorthwindTraders.Data;
using Volo.Abp.DependencyInjection;

namespace AbpNorthwindTraders.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpNorthwindTradersDbSchemaMigrator
        : IAbpNorthwindTradersDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpNorthwindTradersDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpNorthwindTradersMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpNorthwindTradersMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}