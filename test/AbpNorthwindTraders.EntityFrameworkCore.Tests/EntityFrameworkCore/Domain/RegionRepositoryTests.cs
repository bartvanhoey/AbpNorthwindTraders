using System;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace AbpNorthwindTraders.EntityFrameworkCore.Domain
{
    public class RegionRepositoryTests : AbpNorthwindTradersEntityFrameworkCoreTestBase
    {
        private readonly IRegionRepository _regionRepository;

        public RegionRepositoryTests()
        {
            _regionRepository = GetRequiredService<IRegionRepository>();
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
