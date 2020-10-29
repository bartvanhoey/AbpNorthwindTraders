using Microsoft.AspNetCore.Authorization;
using AbpNorthwindTraders.Permissions;
using System.Threading.Tasks;

namespace AbpNorthwindTraders.Blazor.Pages
{
  public partial class Shippers
  {
    protected bool canCreateShipper;
    protected bool canUpdateShipper;
    protected bool canDeleteShipper;

    protected override async Task OnInitializedAsync()
    {
      canCreateShipper = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Shipper.Create);
      canUpdateShipper = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Shipper.Update);
      canDeleteShipper = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Shipper.Delete);
    }

  }
}