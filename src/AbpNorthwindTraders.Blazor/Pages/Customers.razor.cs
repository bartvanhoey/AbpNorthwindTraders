using System.Threading.Tasks;
using AbpNorthwindTraders.Permissions;
using Microsoft.AspNetCore.Authorization;

namespace AbpNorthwindTraders.Blazor.Pages
{
  public partial class Customers
  {
    protected bool canCreateCustomer;
    protected bool canUpdateCustomer;
    protected bool canDeleteCustomer;

    protected override async Task OnInitializedAsync()
    {

      canCreateCustomer = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Customer.Create);
      canUpdateCustomer = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Customer.Update);
      canDeleteCustomer = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Customer.Delete);
    }
  }
}