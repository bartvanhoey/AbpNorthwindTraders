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

      if (await context.IsGrantedAsync(AbpNorthwindTradersPermissions.Employee.Default))
      {
        var employeesMenu = new ApplicationMenuItem("EmployeesMenu", l["Menu:Employee"], url: "/employees");
        northwindTradersMenu.AddItem(employeesMenu);
      }
      
      if (await context.IsGrantedAsync(AbpNorthwindTradersPermissions.Customer.Default))
      {
        var customersMenu = new ApplicationMenuItem("CustomersMenu", l["Menu:Customer"], url: "/customers");
        northwindTradersMenu.AddItem(customersMenu);
      }

      if (await context.IsGrantedAsync(AbpNorthwindTradersPermissions.Supplier.Default))
      {
        var suppliersMenu = new ApplicationMenuItem("SuppliersMenu", l["Menu:Supplier"], url: "/suppliers");
        northwindTradersMenu.AddItem(suppliersMenu);
      }

      if (await context.IsGrantedAsync(AbpNorthwindTradersPermissions.Category.Default))
      {
        var categoriesMenu = new ApplicationMenuItem("CategoriesMenu", l["Menu:Category"], url: "/categories");
        northwindTradersMenu.AddItem(categoriesMenu);
      }

      if (await context.IsGrantedAsync(AbpNorthwindTradersPermissions.Product.Default))
      {
        var productsMenu = new ApplicationMenuItem("ProductsMenu", l["Menu:Product"], url: "/products");
        northwindTradersMenu.AddItem(productsMenu);
      }

      context.Menu.AddItem(northwindTradersMenu);


    }
  }
}
