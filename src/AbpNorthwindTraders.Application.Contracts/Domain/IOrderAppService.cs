using System;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
    public interface IOrderAppService :
        ICrudAppService< 
            OrderDto, 
            int, 
            PagedAndSortedResultRequestDto,
            CreateOrderDto,
            UpdateOrderDto>
    {
        Task<ListResultDto<EmployeeLookupDto>> GetEmployeeLookupAsync();
    }
}