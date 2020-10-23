using System.Threading.Tasks;
using AbpNorthwindTraders.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace AbpNorthwindTraders.Blazor.Pages
{
  public partial class Regions
  {

    protected bool canCreateRegion;
    protected bool canUpdateRegion;
    protected bool canDeleteRegion;

    protected override async Task OnInitializedAsync()
    {
      canCreateRegion = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Region.Create);
      canUpdateRegion = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Region.Update);
      canDeleteRegion = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Region.Delete);
    }


  }
}