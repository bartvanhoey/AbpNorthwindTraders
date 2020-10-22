using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace AbpNorthwindTraders.Domain
{
  public class Customer : FullAuditedEntity<string>, IMultiTenant
  {
    public new string Id { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public ICollection<Order> Orders { get; private set; }
    public Guid? TenantId { get; }

    public Customer() { }


    public Customer(
        string id,
        string companyName,
        string contactName,
        string contactTitle,
        string address,
        string city,
        string region,
        string postalCode,
        string country,
        string phone,
        string fax,
        ICollection<Order> orders,
        Guid? tenantId
    ) : base(id)
    {
      Id = id;
      CompanyName = companyName;
      ContactName = contactName;
      ContactTitle = contactTitle;
      Address = address;
      City = city;
      Region = region;
      PostalCode = postalCode;
      Country = country;
      Phone = phone;
      Fax = fax;
      Orders = orders;
      TenantId = tenantId;
    }
  }
}
