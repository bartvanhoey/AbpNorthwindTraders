using System;
using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain.Dtos
{
    [Serializable]
    public class RegionDto : FullAuditedEntityDto<int>
    {
        public string RegionDescription { get; set; }
    }
}