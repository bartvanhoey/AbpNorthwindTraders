using System;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
    public class CustomerAppService : CrudAppService<Customer, CustomerDto, string, PagedAndSortedResultRequestDto, CreateCustomerDto, UpdateCustomerDto>,
        ICustomerAppService
    {
        protected override string GetPolicyName { get; set; } = AbpNorthwindTradersPermissions.Customer.Default;
        protected override string GetListPolicyName { get; set; } = AbpNorthwindTradersPermissions.Customer.Default;
        protected override string CreatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Customer.Create;
        protected override string UpdatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Customer.Update;
        protected override string DeletePolicyName { get; set; } = AbpNorthwindTradersPermissions.Customer.Delete;

        private readonly ICustomerRepository _repository;
        
        public CustomerAppService(ICustomerRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
