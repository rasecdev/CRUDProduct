using AutoMapper;
using CRUDProduct.Application.Dtos;
using CRUDProduct.Domain.Entities;

namespace CRUDProduct.Application.Mappers
{
    public class ModelToDtoMappingProduct : Profile
    {
        public ModelToDtoMappingProduct()
        {
            ContaDtoMap();
        }

        private void ContaDtoMap()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(x => x.Description))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(x => x.Price));
        }
    }
}