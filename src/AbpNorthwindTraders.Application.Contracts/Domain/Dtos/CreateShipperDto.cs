using System;
using System.ComponentModel;
namespace AbpNorthwindTraders.Domain.Dtos
{
    [Serializable]
    public class CreateShipperDto
    {
        public string CompanyName { get; set; }

        public string Phone { get; set; }

      

        public System.Guid? TenantId { get; set; }
    }
}