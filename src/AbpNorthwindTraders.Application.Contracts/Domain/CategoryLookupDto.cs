using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain
{
  public class CategoryLookupDto  : EntityDto<int>
  {
    public string CategoryName { get; set; }
  }
}