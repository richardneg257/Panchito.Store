using AutoMapper;
using Panchito.Store.Application.Dtos;
using Panchito.Store.Entity;

namespace Panchito.Store.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}
