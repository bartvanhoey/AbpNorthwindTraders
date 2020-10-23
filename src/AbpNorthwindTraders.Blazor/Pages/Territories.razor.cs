using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain.Dtos;
using AbpNorthwindTraders.Permissions;
using Microsoft.AspNetCore.Authorization;

namespace AbpNorthwindTraders.Blazor.Pages
{
  public partial class Territories
  {
    protected IReadOnlyList<RegionLookupDto> regionList = Array.Empty<RegionLookupDto>();
    protected bool canCreateTerritory;
    protected bool canUpdateTerritory;
    protected bool canDeleteTerritory;


    protected override async Task OnInitializedAsync()
    {
      regionList = (await AppService.GetRegionLookupAsync()).Items;

      canCreateTerritory = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Territory.Create);
      canUpdateTerritory = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Territory.Update);
      canDeleteTerritory = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Territory.Delete);

  }

}
}