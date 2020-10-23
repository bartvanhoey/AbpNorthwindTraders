using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain.Dtos
{
    [Serializable]
    public class RegionDto : FullAuditedEntityDto<int>
    {
        [Required] 
        public string RegionDescription { get; set; }
    }
}