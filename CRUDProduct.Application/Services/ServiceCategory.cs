using CRUDProduct.Domain.Core.Interfaces.Repositories;
using CRUDProduct.Domain.Core.Interfaces.Services;
using CRUDProduct.Domain.Entities;

namespace CRUDProduct.Application.Services
{
    public class ServiceCategory : ServiceBase<Category>, IServiceCategory
    {
        private readonly IRepositoryCategory repositoryCategory;

        public ServiceCategory(IRepositoryCategory repositoryCategory)
            : base(repositoryCategory)
        {
            this.repositoryCategory = repositoryCategory;
        }
    }
}