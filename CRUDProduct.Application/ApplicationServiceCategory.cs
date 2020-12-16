using AutoMapper;
using CRUDProduct.Application.Dtos;
using CRUDProduct.Application.Interfaces;
using CRUDProduct.Domain.Core.Interfaces.Services;
using CRUDProduct.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUDCategory.Application
{
    public class ApplicationServiceCategory : IApplicationServiceCategory
    {
        private readonly IServiceCategory serviceCategory;
        private readonly IMapper mapper;

        public ApplicationServiceCategory(IServiceCategory serviceCategory, IMapper mapper)
        {
            this.serviceCategory = serviceCategory;
            this.mapper = mapper;
        }

        public async Task Add(CategoryDto categoryDto)
        {
            var category = mapper.Map<Category>(categoryDto);
            await serviceCategory.Add(category);
        }

        public async Task Delete(CategoryDto categoryDto)
        {
            var category = mapper.Map<Category>(categoryDto);
            await serviceCategory.Delete(category);
        }

        public async Task<CategoryDto> GetEntityById(int Id)
        {
            var category = await serviceCategory.GetEntityById(Id);
            var categoryDto = mapper.Map<CategoryDto>(category);

            return categoryDto;
        }

        public async Task<IEnumerable<CategoryDto>> List()
        {
            var categories = await serviceCategory.List();
            var categoriesDto = mapper.Map<IEnumerable<CategoryDto>>(categories);

            return categoriesDto;
        }

        public async Task Update(CategoryDto categoryDto)
        {
            var category = mapper.Map<Category>(categoryDto);
            await serviceCategory.Update(category);
        }
    }
}