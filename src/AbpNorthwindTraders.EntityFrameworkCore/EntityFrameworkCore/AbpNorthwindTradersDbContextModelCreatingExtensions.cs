using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpNorthwindTraders.EntityFrameworkCore
{
    public static class AbpNorthwindTradersDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpNorthwindTraders(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpNorthwindTradersConsts.DbTablePrefix + "YourEntities", AbpNorthwindTradersConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}