using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace AbpNorthwindTraders.Domain
{
    public class ShipperAppServiceTests : AbpNorthwindTradersApplicationTestBase
    {
        private readonly IShipperAppService _shipperAppService;

        public ShipperAppServiceTests()
        {
            _shipperAppService = GetRequiredService<IShipperAppService>();
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
