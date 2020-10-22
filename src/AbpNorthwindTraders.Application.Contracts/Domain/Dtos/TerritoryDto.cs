using System;
using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain.Dtos
{
    [Serializable]
    public class TerritoryDto : FullAuditedEntityDto<string>
    {
        public string Id { get; set; }

        public string TerritoryDescription { get; set; }

        public int RegionId { get; set; }

    }
}