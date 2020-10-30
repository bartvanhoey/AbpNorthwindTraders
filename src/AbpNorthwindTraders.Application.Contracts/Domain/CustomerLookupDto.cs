using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain
{
  public class CustomerLookupDto  : EntityDto<string>
  {
    public string CustomerCompanyName { get; set; }
  }
}