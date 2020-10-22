using System;
using AbpNorthwindTraders.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpNorthwindTraders.Domain
{
    public class ProductRepository : EfCoreRepository<AbpNorthwindTradersDbContext, Product, int>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<AbpNorthwindTradersDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}