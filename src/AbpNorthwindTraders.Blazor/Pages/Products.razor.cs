using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AbpNorthwindTraders.Permissions;
using System.Collections.Generic;
using AbpNorthwindTraders.Domain;
using System;

namespace AbpNorthwindTraders.Blazor.Pages
{
  public partial class Products
  {

    protected IReadOnlyList<CategoryLookupDto> categoryList = Array.Empty<CategoryLookupDto>();

    protected IReadOnlyList<SupplierLookupDto> supplierList = Array.Empty<SupplierLookupDto>();

    protected bool canCreateProduct;
    protected bool canUpdateProduct;
    protected bool canDeleteProduct;

    protected override async Task OnInitializedAsync()
    {
      canCreateProduct = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Product.Create);
      canUpdateProduct = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Product.Update);
      canDeleteProduct = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Product.Delete);

      categoryList = (await AppService.GetCategoryLookupAsync()).Items;
      supplierList = (await AppService.GetSupplierLookupAsync()).Items;

    }
  }

}