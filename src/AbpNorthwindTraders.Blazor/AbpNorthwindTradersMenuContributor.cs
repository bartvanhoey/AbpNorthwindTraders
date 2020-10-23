using AbpNorthwindTraders.Permissions;
using System.Threading.Tasks;
using AbpNorthwindTraders.Localization;
using Volo.Abp.UI.Navigation;

namespace AbpNorthwindTraders.Blazor
{
  public class AbpNorthwindTradersMenuContributor : IMenuContributor
  {
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
      if (context.Menu.DisplayName != StandardMenus.Main)
      {
        return;
      }

      var l = context.GetLocalizer<AbpNorthwindTradersResource>();

      // context.Menu.Items.Insert(
      //     0,
      //     new ApplicationMenuItem(
      //         "AbpNorthwindTraders.Home",
      //         l["Menu:Home"],
      //         "/",
      //         icon: "fas fa-home"
      //     )
      // );

      var northwindTradersMenu = new ApplicationMenuItem("NorthwindTraders", l["Menu:NorthwindTraders"], icon: "fas fa-truck");

      if (await context.IsGrantedAsync(AbpNorthwindTradersPermissions.Region.Default))
      {
        var regionsMenu = new ApplicationMenuItem("RegionsMenu", l["Menu:Regions"], url: "/regions");
        northwindTradersMenu.AddItem(regionsMenu);
      }

      if (await context.IsGrantedAsync(AbpNorthwindTradersPermissions.Territory.Default))
      {
        var territoriesMenu = new ApplicationMenuItem("TerritoriesMenu", l["Menu:Territory"], url: "/territories");
        northwindTradersMenu.AddItem(territoriesMenu);
      }

      context.Menu.AddItem(northwindTradersMenu);


    }
  }
}
