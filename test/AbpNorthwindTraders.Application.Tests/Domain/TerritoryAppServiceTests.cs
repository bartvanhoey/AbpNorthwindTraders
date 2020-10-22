using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace AbpNorthwindTraders.Domain
{
    public class TerritoryAppServiceTests : AbpNorthwindTradersApplicationTestBase
    {
        private readonly ITerritoryAppService _territoryAppService;

        public TerritoryAppServiceTests()
        {
            _territoryAppService = GetRequiredService<ITerritoryAppService>();
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
