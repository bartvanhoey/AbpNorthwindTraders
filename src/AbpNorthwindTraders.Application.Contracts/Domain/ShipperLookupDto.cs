using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain
{
  public class ShipperLookupDto : EntityDto<int>
  {
    public string CompanyName { get; set; }
  }
}