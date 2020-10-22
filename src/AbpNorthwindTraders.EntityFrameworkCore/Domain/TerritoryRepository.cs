using System;
using AbpNorthwindTraders.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpNorthwindTraders.Domain
{
    public class TerritoryRepository : EfCoreRepository<AbpNorthwindTradersDbContext, Territory, string>, ITerritoryRepository
    {
        public TerritoryRepository(IDbContextProvider<AbpNorthwindTradersDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}