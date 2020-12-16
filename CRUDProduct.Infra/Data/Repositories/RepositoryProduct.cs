using CRUDProduct.Domain.Core.Interfaces.Repositories;
using CRUDProduct.Domain.Entities;

namespace CRUDProduct.Infra.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
    }
}