using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain
{
  public class SupplierLookupDto  : EntityDto<int>
  {
    public string CompanyName { get; set; }
  }
}