using System;
using System.Collections.Generic;
using System.Text;
using AbpNorthwindTraders.Localization;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpNorthwindTradersAppService : ApplicationService
    {
        protected AbpNorthwindTradersAppService()
        {
            LocalizationResource = typeof(AbpNorthwindTradersResource);
        }
    }
}
