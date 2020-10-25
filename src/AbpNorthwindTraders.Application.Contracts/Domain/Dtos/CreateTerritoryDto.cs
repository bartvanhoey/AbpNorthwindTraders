using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AbpNorthwindTraders.Domain.Dtos
{
  [Serializable]
  public class CreateTerritoryDto
  {
    [Required]
    public string Id { get; set; }

    [Required]
    public string TerritoryDescription { get; set; }

    [Required]
    public int RegionId { get; set; }


  }
}