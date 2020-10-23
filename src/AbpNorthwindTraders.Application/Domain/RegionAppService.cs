using System;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
    public class RegionAppService : CrudAppService<Region, RegionDto, int, PagedAndSortedResultRequestDto, CreateRegionDto, UpdateRegionDto>,
        IRegionAppService
    {
        protected override string GetPolicyName { get; set; } = AbpNorthwindTradersPermissions.Region.Default;
        protected override string GetListPolicyName { get; set; } = AbpNorthwindTradersPermissions.Region.Default;
        protected override string CreatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Region.Create;
        protected override string UpdatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Region.Update;
        protected override string DeletePolicyName { get; set; } = AbpNorthwindTradersPermissions.Region.Delete;

        private readonly IRegionRepository _repository;
        
        public RegionAppService(IRegionRepository repository) : base(repository)
        {
            _repository = repository;

            	GetPolicyName = AbpNorthwindTradersPermissions.Region.Default;
                GetListPolicyName = AbpNorthwindTradersPermissions.Region.Default;
                CreatePolicyName = AbpNorthwindTradersPermissions.Region.Create;
                UpdatePolicyName = AbpNorthwindTradersPermissions.Region.Update;
                DeletePolicyName = AbpNorthwindTradersPermissions.Region.Delete;

        }
    }
}
