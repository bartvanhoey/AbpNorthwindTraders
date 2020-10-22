using System;
using AbpNorthwindTraders.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpNorthwindTraders.Domain
{
    public class SupplierRepository : EfCoreRepository<AbpNorthwindTradersDbContext, Supplier, int>, ISupplierRepository
    {
        public SupplierRepository(IDbContextProvider<AbpNorthwindTradersDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}