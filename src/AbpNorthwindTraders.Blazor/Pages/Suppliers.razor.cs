using System.Threading.Tasks;
using AbpNorthwindTraders.Permissions;
using Microsoft.AspNetCore.Authorization;

namespace AbpNorthwindTraders.Blazor.Pages
{
  public partial class Suppliers
  {
    protected bool canCreateSupplier;
    protected bool canUpdateSupplier;
    protected bool canDeleteSupplier;

    protected override async Task OnInitializedAsync()
    {

      canCreateSupplier = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Supplier.Create);
      canUpdateSupplier = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Supplier.Update);
      canDeleteSupplier = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Supplier.Delete);
    }
  }
}