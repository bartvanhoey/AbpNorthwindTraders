using System.Collections.Generic;

namespace AbpNorthwindTraders.Domain.DataSeeder.Data
{
  public static class RegionData
  {

    public static List<Region> GetRegions()
    {
      var regions = new List<Region>();
      regions.AddRange(new[]
      {
                new Region {Id = 1, RegionDescription = "Eastern"},
                new Region {Id = 2, RegionDescription = "Western"},
                new Region {Id = 3, RegionDescription = "Northern"},
                new Region {Id = 4, RegionDescription = "Southern"}
            });

      return regions;
    }
  }
}