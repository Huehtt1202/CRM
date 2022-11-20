using Core.Entities;
using Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepositories
{
    public interface IUserRepository : IDisposable
    {
        List<UserEntity> GetAllUsers();
        int Add(UserEntity user);
        int Update(UserEntity user);
        int Delete(int id);
        int FindById(int id);
        void Save(UserEntity user);
    }
}
