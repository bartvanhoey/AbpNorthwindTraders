using AbpNorthwindTraders.Domain.Dtos;
using AutoMapper;

namespace AbpNorthwindTraders.Blazor
{
  public class AbpNorthwindTradersBlazorAutoMapperProfile : Profile
  {
    public AbpNorthwindTradersBlazorAutoMapperProfile()
    {
      //Define your AutoMapper configuration here for the Blazor project.

      CreateMap<RegionDto, UpdateRegionDto>();
      CreateMap<TerritoryDto, UpdateTerritoryDto>();
      CreateMap<EmployeeDto, UpdateEmployeeDto>();
      CreateMap<CustomerDto, UpdateCustomerDto>();
      CreateMap<SupplierDto, UpdateSupplierDto>();
      CreateMap<CategoryDto, UpdateCategoryDto>();
      CreateMap<ProductDto, UpdateProductDto>();
      CreateMap<ShipperDto, UpdateShipperDto>();
    }
  }
}
