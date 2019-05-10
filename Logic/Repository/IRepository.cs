using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    interface IRepository<T> where T: class
    {
        Task<bool> Add(T entity);
        Task<bool> Delete(int Id);

        Task<bool> Save(T entity);

        Task<IEnumerable<T>> Get(int Id);

        Task<IEnumerable<T>> GetAll();

    }
}
