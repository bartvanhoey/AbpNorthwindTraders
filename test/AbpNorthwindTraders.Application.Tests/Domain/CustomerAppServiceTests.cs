using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace AbpNorthwindTraders.Domain
{
    public class CustomerAppServiceTests : AbpNorthwindTradersApplicationTestBase
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerAppServiceTests()
        {
            _customerAppService = GetRequiredService<ICustomerAppService>();
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
