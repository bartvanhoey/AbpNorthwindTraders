using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace AbpNorthwindTraders.Domain
{
   public class Category : FullAuditedEntity<int>, IMultiTenant
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public ICollection<Product> Products { get; private set; }
        public Guid? TenantId { get; }

        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
