using System;
using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain.Dtos
{
    [Serializable]
    public class TerritoryDto : FullAuditedEntityDto<string>
    {
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
    }
}