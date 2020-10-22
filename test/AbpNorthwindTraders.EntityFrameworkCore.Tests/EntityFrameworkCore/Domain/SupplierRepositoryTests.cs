using System;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace AbpNorthwindTraders.EntityFrameworkCore.Domain
{
    public class SupplierRepositoryTests : AbpNorthwindTradersEntityFrameworkCoreTestBase
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierRepositoryTests()
        {
            _supplierRepository = GetRequiredService<ISupplierRepository>();
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
