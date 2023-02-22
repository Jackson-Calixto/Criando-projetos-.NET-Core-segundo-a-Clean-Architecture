using AutoMapper;
using CleanArcMvc.Application.DTOs;
using CleanArcMvc.Application.Products.Commands;
using CleanArcMvc.Domain.Entities;

namespace CleanArcMvc.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>().ReverseMap();
            CreateMap<ProductDTO, ProductUpdateCommand>().ReverseMap();
        }
    }
}
