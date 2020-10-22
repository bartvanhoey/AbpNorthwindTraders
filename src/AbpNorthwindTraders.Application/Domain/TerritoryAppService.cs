using System;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

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
        
        public TerritoryAppService(ITerritoryRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
