using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> InsertAsync(T entity);
        //Task<T> InsertRangAsync(IEnumerable<T> entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> Delete(T id);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression = null);
        void SaveChange();
        IQueryable<T> GetAll();
        IQueryable<T> GetByWhere(Expression<Func<T, bool>> predicate);
        T FindByID(T id);
        T FindByName(T name);
    }
}
