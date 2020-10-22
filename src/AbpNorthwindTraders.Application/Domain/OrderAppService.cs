using System;
using AbpNorthwindTraders.Permissions;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

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
        
        public OrderAppService(IOrderRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
