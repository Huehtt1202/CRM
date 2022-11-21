using Core.Entities;
using EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        ///<summary>
        /// Dịch vụ lấy toàn bộ user
        /// </summary>

        /// <returns></returns>
        [System.Web.Http.HttpGet]
        public List<UserEntity> GetAllUser()
        {
            ApplicationDBContext _dbcontext = new ApplicationDBContext();
            return _dbcontext.User_.ToList();
        }
        ///summary>
        /// Dịch vụ lấy 1 user theo khóa chính nào đó
        /// </summary>


        /// <param UserId="id"></param>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        public UserEntity GetById(int id)
        {
            ApplicationDBContext _dbcontext = new ApplicationDBContext();
            return _dbcontext.User_.FirstOrDefault(x => x.Id == id);
        }

        ///<summary>
        /// Dịch vụ này để thêm mới 1 Food, các thông số gửi từ client lên
        /// </summary>

        [System.Web.Http.HttpPost]
        public bool InsertUser(string UerName, string UserPassword)
        {
            try
            {
                ApplicationDBContext _dbcontext = new ApplicationDBContext();
                UserEntity User = new UserEntity();
                User.UserName = UerName;
                User.UserPassword = UserPassword;
                _dbcontext.User_.Add(User);
                _dbcontext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [System.Web.Http.HttpPut]
        public bool UpdateUser(string Id, string UserName, string UserPassword)
        {
            try
            {
                ApplicationDBContext _dbcontext = new ApplicationDBContext();
                //lấy food tồn tại ra
                UserEntity User = _dbcontext.User_.FirstOrDefault(x => x.Id == Id);
                if (User == null) return false;//không tồn tại false
                User.UserName = UserName;
                User.UserPassword = UserPassword;
                _dbcontext.SaveChanges();//xác nhận chỉnh sửa
                return true;
            }
            catch
            {
                return false;
            }
        }
        [System.Web.Http.HttpDelete]
        public bool DeleteUser(int id)
        {
            ApplicationDBContext _dbcontext = new ApplicationDBContext();
            //lấy food tồn tại ra
            UserEntity User = _dbcontext.User_.FirstOrDefault(x => x.Id == id);
            if (User == null) return false;
            _dbcontext.SaveChanges();//xác nhận chỉnh sửa
            return true;
        }
    }
}
