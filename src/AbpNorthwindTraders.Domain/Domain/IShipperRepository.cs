using System;
using Volo.Abp.Domain.Repositories;

namespace AbpNorthwindTraders.Domain
{
    public interface IShipperRepository : IRepository<Shipper, int>
    {
    }
}