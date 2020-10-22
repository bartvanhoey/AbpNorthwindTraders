using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace AbpNorthwindTraders.Domain
{
     public class Shipper : FullAuditedEntity<int>, IMultiTenant
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public ICollection<Order> Orders { get; private set; }
        public System.Guid? TenantId { get; }

        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public Shipper(
            int id, 
            string companyName, 
            string phone, 
            ICollection<Order> orders, 
            System.Guid? tenantId
        ) : base(id)
        {
            CompanyName = companyName;
            Phone = phone;
            Orders = orders;
            TenantId = tenantId;
        }
    }
}
