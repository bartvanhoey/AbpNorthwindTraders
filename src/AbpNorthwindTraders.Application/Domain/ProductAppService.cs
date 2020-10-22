using System;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
    public class ProductAppService : CrudAppService<Product, ProductDto, int, PagedAndSortedResultRequestDto, CreateProductDto, UpdateProductDto>,
        IProductAppService
    {
        protected override string GetPolicyName { get; set; } = AbpNorthwindTradersPermissions.Product.Default;
        protected override string GetListPolicyName { get; set; } = AbpNorthwindTradersPermissions.Product.Default;
        protected override string CreatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Product.Create;
        protected override string UpdatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Product.Update;
        protected override string DeletePolicyName { get; set; } = AbpNorthwindTradersPermissions.Product.Delete;

        private readonly IProductRepository _repository;
        
        public ProductAppService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
