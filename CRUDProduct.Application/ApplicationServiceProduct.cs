using AutoMapper;
using CRUDProduct.Application.Dtos;
using CRUDProduct.Application.Interfaces;
using CRUDProduct.Domain.Core.Interfaces.Services;
using CRUDProduct.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUDProduct.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapper mapper;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapper mapper)
        {
            this.serviceProduct = serviceProduct;
            this.mapper = mapper;
        }

        public async Task Add(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            await serviceProduct.Add(product);
        }

        public async Task Delete(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            await serviceProduct.Delete(product);
        }

        public async Task<ProductDto> GetEntityById(int Id)
        {
            var product = await serviceProduct.GetEntityById(Id);
            var productDto = mapper.Map<ProductDto>(product);

            return productDto;
        }

        public async Task<IEnumerable<ProductDto>> List()
        {
            var products = await serviceProduct.List();
            var productsDto = mapper.Map<IEnumerable<ProductDto>>(products);

            return productsDto;
        }

        public async Task Update(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            await serviceProduct.Update(product);
        }
    }
}