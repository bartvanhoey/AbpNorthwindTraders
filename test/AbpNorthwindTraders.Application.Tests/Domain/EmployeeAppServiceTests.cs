using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace AbpNorthwindTraders.Domain
{
    public class EmployeeAppServiceTests : AbpNorthwindTradersApplicationTestBase
    {
        private readonly IEmployeeAppService _employeeAppService;

        public EmployeeAppServiceTests()
        {
            _employeeAppService = GetRequiredService<IEmployeeAppService>();
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
