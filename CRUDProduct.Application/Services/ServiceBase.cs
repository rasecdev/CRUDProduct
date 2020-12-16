using CRUDProduct.Domain.Core.Interfaces.Repositories;
using CRUDProduct.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUDProduct.Application.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public async Task Add(TEntity Object)
        {
            await repository.Add(Object);
        }

        public async Task Delete(TEntity Object)
        {
            await repository.Delete(Object);
        }

        public async Task<TEntity> GetEntityById(int Id)
        {
            return await repository.GetEntityById(Id);
        }

        public async Task<List<TEntity>> List()
        {
            return await repository.List();
        }

        public async Task Update(TEntity Object)
        {
            await repository.Update(Object);
        }
    }
}