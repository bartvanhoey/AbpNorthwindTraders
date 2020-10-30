using System;
using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain.Dtos
{
  [Serializable]
  public class OrderDto : FullAuditedEntityDto<int>
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

    public string EmployeeFullName { get; set; }

    public string ShipperCompanyName { get; set; }
  }
}