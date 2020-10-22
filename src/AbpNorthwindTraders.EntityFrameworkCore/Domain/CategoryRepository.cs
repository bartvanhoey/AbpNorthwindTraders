using System;
using AbpNorthwindTraders.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpNorthwindTraders.Domain
{
    public class CategoryRepository : EfCoreRepository<AbpNorthwindTradersDbContext, Category, int>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<AbpNorthwindTradersDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}