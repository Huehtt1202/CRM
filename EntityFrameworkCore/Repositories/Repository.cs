using Core.IRepository;
using LibGit2Sharp;
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
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDBContext _dbContext;
        internal readonly IDbSet<T> _dbSet;
        public Repository()
        {
            _dbContext = new ApplicationDBContext();
            _dbSet = _dbContext.Set<T>();
        }
        
        public async Task<T> InsertAsync(T entity)
        {
            return _dbSet.Add(entity);
        }
        public void SaveChange()
        {
            _dbContext.SaveChanges();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }
        Task<bool> IRepository<T>.Delete(T id)
        {
            if (id == null) return null;
            return Delete(id) ;
        }

        private Task<bool> Delete(T id)
        {
            _dbContext.Entry(id).State = EntityState.Deleted;
            return Delete(id);
        }

        T IRepository<T>.FindByID(T id)
        {
            return _dbSet.Find(id);
        }

        T IRepository<T>.FindByName(T name)
        {
            return _dbSet.Find(name);
        }

        Task<T> IRepository<T>.FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IRepository<T>.GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        IQueryable<T> IRepository<T>.GetByWhere(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsNoTracking();
        }
    }
}
