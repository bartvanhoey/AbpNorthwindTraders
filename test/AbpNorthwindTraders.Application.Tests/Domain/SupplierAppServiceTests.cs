using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace AbpNorthwindTraders.Domain
{
    public class SupplierAppServiceTests : AbpNorthwindTradersApplicationTestBase
    {
        private readonly ISupplierAppService _supplierAppService;

        public SupplierAppServiceTests()
        {
            _supplierAppService = GetRequiredService<ISupplierAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
