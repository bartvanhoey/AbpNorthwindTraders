using System;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
    public class CategoryAppService : CrudAppService<Category, CategoryDto, int, PagedAndSortedResultRequestDto, CreateCategoryDto, UpdateCategoryDto>,
        ICategoryAppService
    {
        protected override string GetPolicyName { get; set; } = AbpNorthwindTradersPermissions.Category.Default;
        protected override string GetListPolicyName { get; set; } = AbpNorthwindTradersPermissions.Category.Default;
        protected override string CreatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Category.Create;
        protected override string UpdatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Category.Update;
        protected override string DeletePolicyName { get; set; } = AbpNorthwindTradersPermissions.Category.Delete;

        private readonly ICategoryRepository _repository;
        
        public CategoryAppService(ICategoryRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
