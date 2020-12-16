using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUDProduct.Application.Interfaces
{
    public interface IApplicationServiceBase<T> where T : class
    {
        Task Add(T Objeto);

        Task Update(T Objeto);

        Task Delete(T Objeto);

        Task<T> GetEntityById(int Id);

        Task<IEnumerable<T>> List();
    }
}