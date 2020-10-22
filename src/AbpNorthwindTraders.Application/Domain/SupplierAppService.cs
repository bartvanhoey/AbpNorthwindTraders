using System;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
    public class SupplierAppService : CrudAppService<Supplier, SupplierDto, int, PagedAndSortedResultRequestDto, CreateSupplierDto, UpdateSupplierDto>,
        ISupplierAppService
    {
        protected override string GetPolicyName { get; set; } = AbpNorthwindTradersPermissions.Supplier.Default;
        protected override string GetListPolicyName { get; set; } = AbpNorthwindTradersPermissions.Supplier.Default;
        protected override string CreatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Supplier.Create;
        protected override string UpdatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Supplier.Update;
        protected override string DeletePolicyName { get; set; } = AbpNorthwindTradersPermissions.Supplier.Delete;

        private readonly ISupplierRepository _repository;
        
        public SupplierAppService(ISupplierRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
