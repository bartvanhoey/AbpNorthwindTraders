using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace AbpNorthwindTraders.Domain
{
    public class Employee : FullAuditedEntity<int>, IMultiTenant
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        // public string ManagerName { get; set; }
        public string PhotoPath { get; set; }
        public Guid? TenantId { get; }
        public Employee Manager { get; set; }
        public ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
        public ICollection<Employee> DirectReports { get; private set; }
        public ICollection<Order> Orders { get; private set; }

        public Employee()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritory>();
            DirectReports = new HashSet<Employee>();
            Orders = new HashSet<Order>();
        }

        public Employee(
            int id, 
            string lastName, 
            string firstName, 
            string title, 
            string titleOfCourtesy, 
            DateTime? birthDate, 
            DateTime? hireDate, 
            string address, 
            string city, 
            string region, 
            string postalCode, 
            string country, 
            string homePhone, 
            string extension, 
            byte[] photo, 
            string notes, 
            int? reportsTo, 
            string photoPath, 
            Guid? tenantId, 
            Employee manager, 
            ICollection<EmployeeTerritory> employeeTerritories, 
            ICollection<Employee> directReports, 
            ICollection<Order> orders
        ) : base(id)
        {
            LastName = lastName;
            FirstName = firstName;
            Title = title;
            TitleOfCourtesy = titleOfCourtesy;
            BirthDate = birthDate;
            HireDate = hireDate;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            HomePhone = homePhone;
            Extension = extension;
            Photo = photo;
            Notes = notes;
            ReportsTo = reportsTo;
            PhotoPath = photoPath;
            TenantId = tenantId;
            Manager = manager;
            EmployeeTerritories = employeeTerritories;
            DirectReports = directReports;
            Orders = orders;
        }
    }
}
