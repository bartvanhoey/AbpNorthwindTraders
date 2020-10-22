using System;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace AbpNorthwindTraders.EntityFrameworkCore.Domain
{
    public class ShipperRepositoryTests : AbpNorthwindTradersEntityFrameworkCoreTestBase
    {
        private readonly IShipperRepository _shipperRepository;

        public ShipperRepositoryTests()
        {
            _shipperRepository = GetRequiredService<IShipperRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
