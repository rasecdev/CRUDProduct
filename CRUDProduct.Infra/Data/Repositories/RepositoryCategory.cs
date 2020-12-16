using CRUDProduct.Domain.Core.Interfaces.Repositories;
using CRUDProduct.Domain.Entities;

namespace CRUDProduct.Infra.Data.Repositories
{
    public class RepositoryCategory : RepositoryBase<Category>, IRepositoryCategory
    {
    }
}