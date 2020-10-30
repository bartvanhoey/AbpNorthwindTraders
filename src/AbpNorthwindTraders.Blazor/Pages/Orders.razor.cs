using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AbpNorthwindTraders.Permissions;
using System.Collections.Generic;
using AbpNorthwindTraders.Domain;
using System;

namespace AbpNorthwindTraders.Blazor.Pages
{
  public partial class Orders
  {
    protected bool canCreateOrder;
    protected bool canUpdateOrder;
    protected bool canDeleteOrder;
    protected IReadOnlyList<CustomerLookupDto> customerList = Array.Empty<CustomerLookupDto>();

    protected override async Task OnInitializedAsync()
    {
      canCreateOrder = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Order.Create);
      canUpdateOrder = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Order.Update);
      canDeleteOrder = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Order.Delete);
      customerList = (await AppService.GetCustomerLookupAsync()).Items;
    }


  }
}