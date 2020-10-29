using System;
using System.Linq;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

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
    private readonly ICategoryRepository _categoryRepository;
    private readonly ISupplierRepository _supplierRepository;

    public ProductAppService(IProductRepository repository, ICategoryRepository categoryRepository, ISupplierRepository supplierRepository) : base(repository)
    {
      _supplierRepository = supplierRepository;
      _repository = repository;
      _categoryRepository = categoryRepository;
    }

    public override async Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
      await CheckGetListPolicyAsync();

      var query = from product in Repository
                  join supplier in _supplierRepository on product.SupplierId equals supplier.Id
                  orderby input.Sorting
                  select new { product, supplier };

      query = query
          .Skip(input.SkipCount)
          .Take(input.MaxResultCount);

      var queryResult = await AsyncExecuter.ToListAsync(query);

      var productDtos = queryResult.Select(x =>
      { 
        var productDto = ObjectMapper.Map<Product, ProductDto>(x.product);
        productDto.SupplierName = x.supplier.CompanyName;
        return productDto;
      }).ToList();

      var totalCount = await Repository.GetCountAsync();

      return new PagedResultDto<ProductDto>(totalCount, productDtos);


    }





    public async Task<ListResultDto<CategoryLookupDto>> GetCategoryLookupAsync()
    {
      var categories = await _categoryRepository.GetListAsync();
      return new ListResultDto<CategoryLookupDto>(ObjectMapper.Map<List<Category>, List<CategoryLookupDto>>(categories));
    }

    public async Task<ListResultDto<SupplierLookupDto>> GetSupplierLookupAsync()
    {
      var suppliers = await _supplierRepository.GetListAsync();
      return new ListResultDto<SupplierLookupDto>(ObjectMapper.Map<List<Supplier>, List<SupplierLookupDto>>(suppliers));
    }

  }
}
