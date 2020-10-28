using System.Threading.Tasks;
using AbpNorthwindTraders.Permissions;
using Microsoft.AspNetCore.Authorization;

namespace AbpNorthwindTraders.Blazor.Pages
{
  public partial class Categories
  {
    protected bool canCreateCategory;
    protected bool canUpdateCategory;
    protected bool canDeleteCategory;

    protected override async Task OnInitializedAsync()
    {
      canCreateCategory = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Category.Create);
      canUpdateCategory = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Category.Update);
      canDeleteCategory = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Category.Delete);
    }

  }
}