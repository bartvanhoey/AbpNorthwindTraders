using System;
using Volo.Abp.Domain.Repositories;

namespace AbpNorthwindTraders.Domain
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
    }
}