using System;
using Volo.Abp.Domain.Repositories;

namespace AbpNorthwindTraders.Domain
{
    public interface ICustomerRepository : IRepository<Customer, string>
    {
    }
}