using System;
using AbpNorthwindTraders.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpNorthwindTraders.Domain
{
    public class EmployeeRepository : EfCoreRepository<AbpNorthwindTradersDbContext, Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(IDbContextProvider<AbpNorthwindTradersDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}