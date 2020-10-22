using System;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace AbpNorthwindTraders.EntityFrameworkCore.Domain
{
    public class ProductRepositoryTests : AbpNorthwindTradersEntityFrameworkCoreTestBase
    {
        private readonly IProductRepository _productRepository;

        public ProductRepositoryTests()
        {
            _productRepository = GetRequiredService<IProductRepository>();
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
