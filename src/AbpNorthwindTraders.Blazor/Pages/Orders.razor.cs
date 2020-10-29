using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AbpNorthwindTraders.Permissions;


namespace AbpNorthwindTraders.Blazor.Pages
{
  public partial class Orders
  {
    protected bool canCreateOrder;
    protected bool canUpdateOrder;
    protected bool canDeleteOrder;

    protected override async Task OnInitializedAsync()
    {
      canCreateOrder = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Order.Create);
      canUpdateOrder = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Order.Update);
      canDeleteOrder = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Order.Delete);
    }

  }
}