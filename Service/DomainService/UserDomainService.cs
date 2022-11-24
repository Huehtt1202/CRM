using Core.Entities;
using Core.IRepositories;
using EntityFrameworkCore;
using EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Service.DomainService
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository _rep;
        private readonly ApplicationDBContext _dbcontext;
        public UserDomainService(IUserRepository rep)
        {
            _rep = rep;
        }

        public int EditPassword(string password)
        {
            try
            {
                UserEntity user = _dbcontext.User_.FirstOrDefault();
                if(user == null) return 0;
                user.UserPassword = password;
                return 1;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string GetMD5(string password)
        {
            try
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fromData = Encoding.UTF8.GetBytes(password);
                byte[] targetData = md5.ComputeHash(fromData);
                string byte2String = null;

                for (int i = 0; i < targetData.Length; i++)
                {
                    byte2String += targetData[i].ToString("x2");

                }
                return byte2String;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetPassword()
        {
            try
            {
            UserEntity user = _dbcontext.User_.FirstOrDefault();
            user.UserPassword = "123123";
            return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool SignIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public string ValudationPassword(string password)
        {
            throw new NotImplementedException();
        }
        public bool InsertUser(string UerName, string UserPassword)
        {
            try
            {
                UserEntity user = _dbcontext.User_.FirstOrDefault();
                user.UserName = UerName;
                user.UserPassword = UserPassword;
                _dbcontext.User_.Add(user);
                _dbcontext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
