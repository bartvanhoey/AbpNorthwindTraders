using AbpNorthwindTraders.Domain;
using AbpNorthwindTraders.Domain.Dtos;
using AutoMapper;

namespace AbpNorthwindTraders
{
    public class AbpNorthwindTradersApplicationAutoMapperProfile : Profile
    {
        public AbpNorthwindTradersApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Region, RegionDto>();
            CreateMap<CreateRegionDto, Region>(MemberList.Source);
            CreateMap<UpdateRegionDto, Region>(MemberList.Source);
            CreateMap<Territory, TerritoryDto>();
            CreateMap<CreateTerritoryDto, Territory>(MemberList.Source);
            CreateMap<UpdateTerritoryDto, Territory>(MemberList.Source);
            CreateMap<Employee, EmployeeDto>();
            CreateMap<CreateEmployeeDto, Employee>(MemberList.Source);
            CreateMap<UpdateEmployeeDto, Employee>(MemberList.Source);
            CreateMap<Customer, CustomerDto>();
            CreateMap<CreateCustomerDto, Customer>(MemberList.Source);
            CreateMap<UpdateCustomerDto, Customer>(MemberList.Source);
            CreateMap<Supplier, SupplierDto>();
            CreateMap<CreateSupplierDto, Supplier>(MemberList.Source);
            CreateMap<UpdateSupplierDto, Supplier>(MemberList.Source);
            CreateMap<Category, CategoryDto>();
            CreateMap<CreateCategoryDto, Category>(MemberList.Source);
            CreateMap<UpdateCategoryDto, Category>(MemberList.Source);
            CreateMap<Product, ProductDto>();
            CreateMap<CreateProductDto, Product>(MemberList.Source);
            CreateMap<UpdateProductDto, Product>(MemberList.Source);
            CreateMap<Shipper, ShipperDto>();
            CreateMap<CreateShipperDto, Shipper>(MemberList.Source);
            CreateMap<UpdateShipperDto, Shipper>(MemberList.Source);
            CreateMap<Order, OrderDto>();
            CreateMap<CreateOrderDto, Order>(MemberList.Source);
            CreateMap<UpdateOrderDto, Order>(MemberList.Source);
        }
    }
}
