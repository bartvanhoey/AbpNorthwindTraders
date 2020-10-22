using System.Threading.Tasks;
using AbpNorthwindTraders.Localization;
using Volo.Abp.UI.Navigation;

namespace AbpNorthwindTraders.Blazor
{
    public class AbpNorthwindTradersMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<AbpNorthwindTradersResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "AbpNorthwindTraders.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
