using System;
using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain.Dtos
{
    [Serializable]
    public class RegionDto : FullAuditedEntityDto<int>
    {
        public int Id { get; set; }

        public string RegionDescription { get; set; }
    }
}