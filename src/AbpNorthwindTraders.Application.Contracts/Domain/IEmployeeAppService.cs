using System;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
  public interface IEmployeeAppService :
      ICrudAppService<
          EmployeeDto,
          int,
          PagedAndSortedResultRequestDto,
          CreateEmployeeDto,
          UpdateEmployeeDto>
  {
    Task<ListResultDto<EmployeeLookupDto>> GetEmployeeLookupAsync();
  }
}