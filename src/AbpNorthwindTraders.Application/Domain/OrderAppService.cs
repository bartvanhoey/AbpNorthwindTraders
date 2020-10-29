using System;
using System.Linq;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AbpNorthwindTraders.Domain
{
  public class OrderAppService : CrudAppService<Order, OrderDto, int, PagedAndSortedResultRequestDto, CreateOrderDto, UpdateOrderDto>,
      IOrderAppService
  {
    protected override string GetPolicyName { get; set; } = AbpNorthwindTradersPermissions.Order.Default;
    protected override string GetListPolicyName { get; set; } = AbpNorthwindTradersPermissions.Order.Default;
    protected override string CreatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Order.Create;
    protected override string UpdatePolicyName { get; set; } = AbpNorthwindTradersPermissions.Order.Update;
    protected override string DeletePolicyName { get; set; } = AbpNorthwindTradersPermissions.Order.Delete;
    private readonly IOrderRepository _repository;
    private readonly IEmployeeRepository _employeeRepository;

    public OrderAppService(IOrderRepository repository, IEmployeeRepository employeeRepository) : base(repository)
    {
      _repository = repository;
      _employeeRepository = employeeRepository;
    }

    public override async Task<PagedResultDto<OrderDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
      await CheckGetListPolicyAsync();

      var query = from order in Repository
                  join employee in _employeeRepository on order.EmployeeId equals employee.Id
                  orderby input.Sorting
                  select new { order, employee };

      query = query
          .Skip(input.SkipCount)
          .Take(input.MaxResultCount);

      var queryResult = await AsyncExecuter.ToListAsync(query);

      var orderDtos = queryResult.Select(x => {
          var orderDto = ObjectMapper.Map<Order, OrderDto>(x.order);
          orderDto.EmployeeFullName = x.employee.FirstName + " " + x.employee.LastName;
          return orderDto;
      }).ToList();

      var totalCount = await Repository.GetCountAsync();

      return new PagedResultDto<OrderDto>(totalCount, orderDtos);
    }


    public async Task<ListResultDto<EmployeeLookupDto>> GetEmployeeLookupAsync()
    {
      var employees = await _employeeRepository.GetListAsync();
      return new ListResultDto<EmployeeLookupDto>(ObjectMapper.Map<List<Employee>, List<EmployeeLookupDto>>(employees));
    }

  }
}
