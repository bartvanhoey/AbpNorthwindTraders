using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace AbpNorthwindTraders.Domain
{
    public class CategoryAppServiceTests : AbpNorthwindTradersApplicationTestBase
    {
        private readonly ICategoryAppService _categoryAppService;

        public CategoryAppServiceTests()
        {
            _categoryAppService = GetRequiredService<ICategoryAppService>();
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
