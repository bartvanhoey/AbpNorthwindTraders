using System;
using Volo.Abp.Domain.Repositories;

namespace AbpNorthwindTraders.Domain
{
    public interface IOrderRepository : IRepository<Order, int>
    {
    }
}