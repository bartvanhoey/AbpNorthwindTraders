using System;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
  public interface ITerritoryAppService :
      ICrudAppService<
          TerritoryDto,
          string,
          PagedAndSortedResultRequestDto,
          CreateTerritoryDto,
          UpdateTerritoryDto>
  {
    Task<ListResultDto<RegionLookupDto>> GetRegionLookupAsync();
  }
}