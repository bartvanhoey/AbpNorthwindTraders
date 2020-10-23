using System;
using System.ComponentModel;

namespace AbpNorthwindTraders.Domain.Dtos
{
    [Serializable]
    public class UpdateRegionDto
    {
        public string RegionDescription { get; set; }
    }
}