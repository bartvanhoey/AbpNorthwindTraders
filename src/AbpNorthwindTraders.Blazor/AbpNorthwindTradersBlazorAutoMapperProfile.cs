using AbpNorthwindTraders.Domain.Dtos;
using AutoMapper;

namespace AbpNorthwindTraders.Blazor
{
    public class AbpNorthwindTradersBlazorAutoMapperProfile : Profile
    {
        public AbpNorthwindTradersBlazorAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Blazor project.

            CreateMap<RegionDto, UpdateRegionDto>();
        }
    }
}
