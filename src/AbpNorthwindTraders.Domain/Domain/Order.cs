using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace AbpNorthwindTraders.Domain
{
    public class Order: FullAuditedEntity<int>, IMultiTenant
    {
        public string CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Shipper Shipper { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; private set; }
        public Guid? TenantId { get; }

        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Order(
            int id, 
            string customerId, 
            int? employeeId, 
            DateTime? orderDate, 
            DateTime? requiredDate, 
            DateTime? shippedDate, 
            int? shipVia, 
            decimal? freight, 
            string shipName, 
            string shipAddress, 
            string shipCity, 
            string shipRegion, 
            string shipPostalCode, 
            string shipCountry, 
            Customer customer, 
            Employee employee, 
            Shipper shipper, 
            ICollection<OrderDetail> orderDetails, 
            Guid? tenantId
        ) : base(id)
        {
            CustomerId = customerId;
            EmployeeId = employeeId;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            ShipVia = shipVia;
            Freight = freight;
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipCity = shipCity;
            ShipRegion = shipRegion;
            ShipPostalCode = shipPostalCode;
            ShipCountry = shipCountry;
            Customer = customer;
            Employee = employee;
            Shipper = shipper;
            OrderDetails = orderDetails;
            TenantId = tenantId;
        }
    }
}
