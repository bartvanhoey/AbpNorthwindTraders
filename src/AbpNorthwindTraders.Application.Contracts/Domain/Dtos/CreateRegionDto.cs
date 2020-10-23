using System;
using System.ComponentModel;
namespace AbpNorthwindTraders.Domain.Dtos
{
    [Serializable]
    public class CreateRegionDto
    {
        
        public string RegionDescription { get; set; }
    }
}