using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepositories
{
    public interface IRepository<T, U>
    {
        Task<T> GetAsync(T entity);
        Task<T> InsertAsync(T entity);
        Task<T> InsertRangAsync(IEnumerable<T> entity);
        Task<T> UpdateAsync(T entity);
        Task<T> UpdateRangAsync(IEnumerable<U> entity);
        Task<bool> Delete(U id);
        Task<bool> DeleteAsync(IEnumerable<U> id);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression = null);
        void SaveChange();

    }
}
