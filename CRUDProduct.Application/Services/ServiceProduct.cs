using CRUDProduct.Domain.Core.Interfaces.Repositories;
using CRUDProduct.Domain.Core.Interfaces.Services;
using CRUDProduct.Domain.Entities;

namespace CRUDProduct.Application.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct)
            : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}