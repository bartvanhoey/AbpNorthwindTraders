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
    private readonly IShipperRepository _shipperRepository;
    private readonly ICustomerRepository _customerRepository;

    public OrderAppService(IOrderRepository repository, IEmployeeRepository employeeRepository, IShipperRepository shipperRepository, ICustomerRepository customerRepository) : base(repository)
    {
      _shipperRepository = shipperRepository;
      _customerRepository = customerRepository;
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

      var orderDtos = queryResult.Select(x =>
      {
        var orderDto = ObjectMapper.Map<Order, OrderDto>(x.order);
        orderDto.EmployeeFullName = x.employee.FirstName + " " + x.employee.LastName;
        orderDto.ShipperCompanyName = (_shipperRepository.GetAsync(x.order.ShipVia.Value).Result).CompanyName;

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

    public async Task<ListResultDto<ShipperLookupDto>> GetShipperLookupAsync()
    {
      var shippers = await _shipperRepository.GetListAsync();
      return new ListResultDto<ShipperLookupDto>(ObjectMapper.Map<List<Shipper>, List<ShipperLookupDto>>(shippers));
    }

    public async Task<ListResultDto<CustomerLookupDto>> GetCustomerLookupAsync()
    {
      var customers = await _customerRepository.GetListAsync();
      return new ListResultDto<CustomerLookupDto>(ObjectMapper.Map<List<Customer>, List<CustomerLookupDto>>(customers));
    }

  }
}
