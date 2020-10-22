using System;
using Volo.Abp.Domain.Repositories;

namespace AbpNorthwindTraders.Domain
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}