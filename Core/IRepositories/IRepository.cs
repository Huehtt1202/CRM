using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepository
{
    public interface IRepository<T, U> where T : class
    {
        Task<T> InsertAsync(T entity);
        Task<T> InsertRangAsync(IEnumerable<T> entity);
        Task<T> UpdateAsync(T entity);
        Task<T> UpdateRangAsync(IEnumerable<U> entity);
        Task<bool> Delete(U id);
        Task<bool> DeleteAsync(IEnumerable<U> id);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression = null);
        void SaveChange();
        IQueryable<T> GetAll();
        IQueryable<T> GetByWhere(Expression<Func<T, bool>> predicate);
        T FindByID(U id);
        T FindByName(U name);
    }
}
