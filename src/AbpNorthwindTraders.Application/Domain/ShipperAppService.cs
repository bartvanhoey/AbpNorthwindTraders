using System;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
    public class ShipperAppService : CrudAppService<Shipper, ShipperDto, int, PagedAndSortedResultRequestDto, CreateShipperDto, UpdateShipperDto>,
        IShipperAppService
    {
        protected override string GetPolicyName { get; set; } = AbpNorthwindTradersPermissions.Shipper.Default;
        protected override string GetListPolicyName { get; set; } = AbpNorthwindTradersPermissions.Shipper.Default;
        protected override string CreatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Shipper.Create;
        protected override string UpdatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Shipper.Update;
        protected override string DeletePolicyName { get; set; } = AbpNorthwindTradersPermissions.Shipper.Delete;

        private readonly IShipperRepository _repository;
        
        public ShipperAppService(IShipperRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
