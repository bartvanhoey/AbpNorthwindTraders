using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace AbpNorthwindTraders.Domain
{
    public class EmployeeTerritory : FullAuditedEntity, IMultiTenant
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }
        public Employee Employee { get; set; }
        public Territory Territory { get; set; }
        public Guid? TenantId { get; }

        public override object[] GetKeys()
        {
            return new object[] {EmployeeId, TerritoryId};
        }

    }
}