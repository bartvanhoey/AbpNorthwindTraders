using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace AbpNorthwindTraders.Domain
{
  public class Territory : FullAuditedEntity<string>, IMultiTenant
  {
    public new string Id { get; set; }
    public string TerritoryDescription { get; set; }
    public int RegionId { get; set; }
    public Region Region { get; set; }
    public ICollection<EmployeeTerritory> EmployeeTerritories { get; private set; }
    public Guid? TenantId { get; }
    public Territory()
    {
      EmployeeTerritories = new HashSet<EmployeeTerritory>();
    }
  }
}
