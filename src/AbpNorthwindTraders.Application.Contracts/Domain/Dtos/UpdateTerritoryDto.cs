using System;
using System.ComponentModel;

namespace AbpNorthwindTraders.Domain.Dtos
{
  [Serializable]
  public class UpdateTerritoryDto
  {
    public string Id { get; set; }

    public string TerritoryDescription { get; set; }

    public int RegionId { get; set; }
  }
}