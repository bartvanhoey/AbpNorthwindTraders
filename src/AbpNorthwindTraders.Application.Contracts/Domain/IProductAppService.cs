using System;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
    public interface IProductAppService :
        ICrudAppService< 
            ProductDto, 
            int, 
            PagedAndSortedResultRequestDto,
            CreateProductDto,
            UpdateProductDto>
    {
        Task<ListResultDto<CategoryLookupDto>> GetCategoryLookupAsync();
        Task<ListResultDto<SupplierLookupDto>> GetSupplierLookupAsync();
    }
}