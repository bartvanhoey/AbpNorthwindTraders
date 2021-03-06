using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain.Dtos;
using AbpNorthwindTraders.Permissions;
using Microsoft.AspNetCore.Authorization;

namespace AbpNorthwindTraders.Blazor.Pages
{
  public partial class Employees
  {
    protected IReadOnlyList<EmployeeLookupDto> managerList = Array.Empty<EmployeeLookupDto>();
    protected bool canCreateEmployee;
    protected bool canUpdateEmployee;
    protected bool canDeleteEmployee;

    protected override async Task OnInitializedAsync()
    {
      canCreateEmployee = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Employee.Create);
      canUpdateEmployee = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Employee.Update);
      canDeleteEmployee = await AuthorizationService.IsGrantedAsync(AbpNorthwindTradersPermissions.Employee.Delete);
    
     managerList = (await AppService.GetEmployeeLookupAsync()).Items;

    }
  }
}