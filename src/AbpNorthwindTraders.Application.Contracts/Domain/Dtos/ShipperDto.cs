using System;
using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain.Dtos
{
    [Serializable]
    public class ShipperDto : FullAuditedEntityDto<int>
    {
        public string CompanyName { get; set; }

        public string Phone { get; set; }


        public System.Guid? TenantId { get; set; }
    }
}