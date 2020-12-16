using AutoMapper;
using CRUDProduct.Application.Dtos;
using CRUDProduct.Domain.Entities;

namespace CRUDProduct.Application.Mappers
{
    public class DtoToModelMappingProduct : Profile
    {
        public DtoToModelMappingProduct()
        {
            ContaMap();
        }

        private void ContaMap()
        {
            CreateMap<ProductDto, Product>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(x => x.Description))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(x => x.Price))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(x => x.CategoryId));
        }
    }
}