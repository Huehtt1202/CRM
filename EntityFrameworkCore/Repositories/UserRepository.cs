using Core.Entities;
using Core.IRepositories;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySqlX.XDevAPI.Relational;

namespace EntityFrameworkCore.Repositories
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        internal ApplicationDBContext _dbContext;
        public UserRepository(ApplicationDBContext User)
        {
            _dbContext = User;
        }
        
        public int Add(UserEntity user)
        {
            try
            {
               _dbContext.User_.Add(user);
                return Add(user);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(int id)
        {
            try
            {
                var result = _dbContext.User_.Find(id);
                _dbContext.User_.Remove(result);
                return Delete(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Dispose()
        {
            
        }

        public int FindById(int id)
        {
            _dbSet.Find(id);
            return FindById(id);
        }

        public List<UserEntity> GetAllUsers()
        {
            var list = new List<UserEntity>();
            try
            {
                list = _dbSet.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public void Save(UserEntity user)
        {
            var account = 0;
            try
            {
                _dbContext.User_.Add(user);
                account = _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(UserEntity user)
        {
            try
            {
                _dbSet.Attach(user);
                _dbContext.Entry(user).State = EntityState.Modified;
                return Update(user);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
