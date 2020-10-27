using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;


namespace AbpNorthwindTraders.Domain
{
    public interface IEmployeeRepository : IRepository<Employee, int>
   {
        

    }
}