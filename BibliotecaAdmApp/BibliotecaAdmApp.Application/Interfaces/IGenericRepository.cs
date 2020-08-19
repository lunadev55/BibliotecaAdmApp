using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAdmApp.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> FindAll();
        Task<int> Delete(int id);

        Task<int> Update(T entity);

        Task<int> Add(T entity);
    }
}
