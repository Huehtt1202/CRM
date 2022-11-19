using Core.IRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Repositories
{
    public class Repository<T, U> : IRepository<T, U> where T : class
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IDbSet<T> _dbSet;
        public Repository()
        {
            _dbContext = new ApplicationDBContext();
            _dbSet = _dbContext.Set<T>();
        }
        public Task<bool> Delete(U id)
        {
            if (id == null) return null;

            //_dbSet.Remove();
            _dbContext.SaveChangesAsync();
            return Delete(id);
        }

        public Task<bool> DeleteAsync(IEnumerable<U> id)
        {
            //_dbSet.Remove(id);
            _dbContext.SaveChangesAsync();
            return DeleteAsync(id);
        }

        public T FindByID(U id)
        {
            return _dbSet.Find();
        }

        public T FindByName(U name)
        {
            return _dbSet.Find();
        }

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public async Task<T> InsertAsync(T entity)
        {
            _dbSet.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public Task<T> InsertRangAsync(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            _dbContext.SaveChanges();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public Task<T> UpdateRangAsync(IEnumerable<U> entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IRepository<T, U>.GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        IQueryable<T> IRepository<T, U>.GetByWhere(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsNoTracking();
        }
    }
}
