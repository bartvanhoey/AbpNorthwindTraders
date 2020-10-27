using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain.Dtos
{
  public class RegionLookupDto  : EntityDto<int>
    {
        public string RegionDescription { get; set; }
    }
}