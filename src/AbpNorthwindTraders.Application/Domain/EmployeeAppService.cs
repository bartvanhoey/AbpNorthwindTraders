using System;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AbpNorthwindTraders.Domain
{
    public class EmployeeAppService : CrudAppService<Employee, EmployeeDto, int, PagedAndSortedResultRequestDto, CreateEmployeeDto, UpdateEmployeeDto>,
        IEmployeeAppService
    {
        protected override string GetPolicyName { get; set; } = AbpNorthwindTradersPermissions.Employee.Default;
        protected override string GetListPolicyName { get; set; } = AbpNorthwindTradersPermissions.Employee.Default;
        protected override string CreatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Employee.Create;
        protected override string UpdatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Employee.Update;
        protected override string DeletePolicyName { get; set; } = AbpNorthwindTradersPermissions.Employee.Delete;

        private readonly IEmployeeRepository _repository;
        
        public EmployeeAppService(IEmployeeRepository repository) : base(repository)
        {
            _repository = repository;
        }

    public async Task<ListResultDto<EmployeeLookupDto>> GetEmployeeLookupAsync()
    {
        var employees = await _repository.GetListAsync();
        var map = ObjectMapper.Map<List<Employee>, List<EmployeeLookupDto>>(employees);
        return new ListResultDto<EmployeeLookupDto>(map);
    }

  }
}
