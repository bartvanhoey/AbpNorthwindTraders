using System;
using System.Linq;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using System.Collections.Generic;

namespace AbpNorthwindTraders.Domain
{
  public class TerritoryAppService : CrudAppService<Territory, TerritoryDto, string, PagedAndSortedResultRequestDto, CreateTerritoryDto, UpdateTerritoryDto>,
      ITerritoryAppService
  {
    protected override string GetPolicyName { get; set; } = AbpNorthwindTradersPermissions.Territory.Default;
    protected override string GetListPolicyName { get; set; } = AbpNorthwindTradersPermissions.Territory.Default;
    protected override string CreatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Territory.Create;
    protected override string UpdatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Territory.Update;
    protected override string DeletePolicyName { get; set; } = AbpNorthwindTradersPermissions.Territory.Delete;

    private readonly ITerritoryRepository _repository;
    private readonly IRepository<Region, int> _regionRepository;

    public TerritoryAppService(ITerritoryRepository repository, IRepository<Region, int> regionRepository) : base(repository)
    {
      _repository = repository;
      _regionRepository = regionRepository;
    }

    public override async Task<TerritoryDto> GetAsync(string id)
    {
      await CheckGetPolicyAsync();

      //Prepare a query to join books and authors
      var query = from territory in Repository
                  join region in _regionRepository on territory.RegionId equals region.Id
                  where territory.Id == id
                  select new { territory, region };

      //Execute the query and get the territory with region
      var queryResult = await AsyncExecuter.FirstOrDefaultAsync(query);
      if (queryResult == null)
      {
        throw new Exception();
      }

      var territoryDto = ObjectMapper.Map<Territory, TerritoryDto>(queryResult.territory);
      territoryDto.RegionDescription = queryResult.region.RegionDescription;
      return territoryDto;
    }

    public override async Task<PagedResultDto<TerritoryDto>>
        GetListAsync(PagedAndSortedResultRequestDto input)
    {
      await CheckGetListPolicyAsync();

      //Prepare a query to join books and authors
      var query = from territory in Repository
                  join region in _regionRepository on territory.RegionId equals region.Id
                  orderby input.Sorting
                  select new { territory, region };

      query = query
          .Skip(input.SkipCount)
          .Take(input.MaxResultCount);

      //Execute the query and get a list
      var queryResult = await AsyncExecuter.ToListAsync(query);

      //Convert the query result to a list of TerritoryDto objects
      var TerritoryDtos = queryResult.Select(x =>
      {
        var TerritoryDto = ObjectMapper.Map<Territory, TerritoryDto>(x.territory);
        TerritoryDto.RegionDescription = x.region.RegionDescription;
        return TerritoryDto;
      }).ToList();

      //Get the total count with another query
      var totalCount = await Repository.GetCountAsync();

      return new PagedResultDto<TerritoryDto>(
          totalCount,
          TerritoryDtos
      );
    }

    public async Task<ListResultDto<RegionLookupDto>> GetRegionLookupAsync()
    {
      var regions = await _regionRepository.GetListAsync();
      return new ListResultDto<RegionLookupDto>(ObjectMapper.Map<List<Region>, List<RegionLookupDto>>(regions));
    }

  }
}
