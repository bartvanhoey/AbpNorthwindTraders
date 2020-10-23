using AbpNorthwindTraders.Domain.Dtos;
using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace AbpNorthwindTraders.Domain
{
    public class RegionAppService_Tests : AbpNorthwindTradersApplicationTestBase
    {
        private readonly IRegionAppService _regionAppService;

        public RegionAppService_Tests()
        {
            _regionAppService = GetRequiredService<IRegionAppService>();
        }

        // [Fact]
        // public async Task Should_Get_A_List_Of_Regions()
        // {
        //     var result = await _regionAppService.GetListAsync(new PagedAndSortedResultRequestDto());

        //     result.TotalCount.ShouldBeGreaterThan(0);
        //     result.Items.ShouldContain(r => r.RegionDescription == "Southern");
        // }

        // [Fact]
        // public async Task Should_Create_A_Valid_Region()
        // {
        //     var result = await _regionAppService.CreateAsync(new CreateRegionDto
        //         {
        //             RegionDescription = "My new region"
        //         }
        //     );            

        //     result.Id.ShouldBeGreaterThan(1);
        //     result.RegionDescription.ShouldBe("My new region");

        // }
    }
}
