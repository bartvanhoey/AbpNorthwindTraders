using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AbpNorthwindTraders.Domain
{
    public static class TerritoryEfCoreQueryableExtensions
    {
        public static IQueryable<Territory> IncludeDetails(this IQueryable<Territory> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}