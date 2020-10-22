using System;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace AbpNorthwindTraders.EntityFrameworkCore.Domain
{
    public class TerritoryRepositoryTests : AbpNorthwindTradersEntityFrameworkCoreTestBase
    {
        private readonly ITerritoryRepository _territoryRepository;

        public TerritoryRepositoryTests()
        {
            _territoryRepository = GetRequiredService<ITerritoryRepository>();
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
