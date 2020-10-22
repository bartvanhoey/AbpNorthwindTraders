using System;
using AbpNorthwindTraders.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpNorthwindTraders.Domain
{
    public interface ICategoryAppService :
        ICrudAppService< 
            CategoryDto, 
            int, 
            PagedAndSortedResultRequestDto,
            CreateCategoryDto,
            UpdateCategoryDto>
    {

    }
}