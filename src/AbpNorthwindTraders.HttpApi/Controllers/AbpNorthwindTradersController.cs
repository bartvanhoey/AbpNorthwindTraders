using AbpNorthwindTraders.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpNorthwindTraders.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpNorthwindTradersController : AbpController
    {
        protected AbpNorthwindTradersController()
        {
            LocalizationResource = typeof(AbpNorthwindTradersResource);
        }
    }
}