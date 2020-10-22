using System;
using Volo.Abp.Domain.Repositories;

namespace AbpNorthwindTraders.Domain
{
    public interface ITerritoryRepository : IRepository<Territory, string>
    {
    }
}