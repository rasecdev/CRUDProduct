using AutoMapper;
using CRUDProduct.Application.Dtos;
using CRUDProduct.Domain.Entities;

namespace CRUDProduct.Application.Mappers
{
    public class ModelToDtoMappingCategory : Profile
    {
        public ModelToDtoMappingCategory()
        {
            CategoryDtoMap();
        }

        private void CategoryDtoMap()
        {
            CreateMap<Category, CategoryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Products, opt => opt.MapFrom(x => x.Products));
        }
    }
}