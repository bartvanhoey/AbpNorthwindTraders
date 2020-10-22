using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace AbpNorthwindTraders.Domain
{
    public class Supplier : FullAuditedEntity<int>, IMultiTenant
    {
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
        public string HomePage { get; set; }
        public Guid? TenantId { get; }
        public ICollection<Product> Products { get; private set; }

        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public Supplier(
            int id, 
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
            string homePage, 
            Guid? tenantId, 
            ICollection<Product> products
        ) : base(id)
        {
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
            HomePage = homePage;
            TenantId = tenantId;
            Products = products;
        }
    }
}
