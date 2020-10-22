using System;
using Volo.Abp.Domain.Repositories;

namespace AbpNorthwindTraders.Domain
{
    public interface IRegionRepository : IRepository<Region, int>
    {
    }
}