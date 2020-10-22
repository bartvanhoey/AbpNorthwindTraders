using System;
using System.ComponentModel;
namespace AbpNorthwindTraders.Domain.Dtos
{
    [Serializable]
    public class CreateRegionDto
    {
        public int Id { get; set; }

        public string RegionDescription { get; set; }


    }
}