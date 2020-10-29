using Volo.Abp.Application.Dtos;

namespace AbpNorthwindTraders.Domain.Dtos
{
  public class EmployeeLookupDto : EntityDto<int>
  {
    public string ManagerName { get; set; }
    public string EmployeeFullName { get; set; }
  }

}