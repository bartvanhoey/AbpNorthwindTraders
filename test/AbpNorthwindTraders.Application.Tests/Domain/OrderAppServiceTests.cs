using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace AbpNorthwindTraders.Domain
{
    public class OrderAppServiceTests : AbpNorthwindTradersApplicationTestBase
    {
        private readonly IOrderAppService _orderAppService;

        public OrderAppServiceTests()
        {
            _orderAppService = GetRequiredService<IOrderAppService>();
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
