using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace AbpNorthwindTraders.Domain
{
    public class RegionAppServiceTests : AbpNorthwindTradersApplicationTestBase
    {
        private readonly IRegionAppService _regionAppService;

        public RegionAppServiceTests()
        {
            _regionAppService = GetRequiredService<IRegionAppService>();
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
