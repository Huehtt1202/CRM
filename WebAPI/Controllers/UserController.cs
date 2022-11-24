//using Core.Entities;
//using EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Security.Cryptography;
//using System.Text;
//using System.Web.Http;
//using System.Web.Mvc;
//using WebAPI.Models;
//using static System.Collections.Specialized.BitVector32;

//namespace WebAPI.Controllers
//{
//    public class UserController : ApiController
//    {
//        ///<summary>
//        /// Dịch vụ lấy toàn bộ user
//        /// </summary>

//        /// <returns></returns>
//        [System.Web.Http.HttpGet]
//        public List<UserEntity> GetAllUser()
//        {
//            ApplicationDBContext _dbcontext = new ApplicationDBContext();
//            return _dbcontext.User_.ToList();
//        }
//        ///summary>
//        /// Dịch vụ lấy 1 user theo khóa chính nào đó
//        /// </summary>


//        /// <param UserId="id"></param>
//        /// <returns></returns>
//        [System.Web.Http.HttpGet]
//        public UserEntity GetById(int id)
//        {
//            ApplicationDBContext _dbcontext = new ApplicationDBContext();
//            return _dbcontext.User_.FirstOrDefault();
//        }

//        ///<summary>
//        /// Dịch vụ này để thêm mới 1 Food, các thông số gửi từ client lên
//        /// </summary>

//        [System.Web.Http.HttpPost]
//        public bool InsertUser(string UerName, string UserPassword)
//        {
//            try
//            {
//                ApplicationDBContext _dbcontext = new ApplicationDBContext();
//                UserEntity User = new UserEntity();
//                User.UserName = UerName;
//                User.UserPassword = UserPassword;
//                _dbcontext.User_.Add(User);
//                _dbcontext.SaveChanges();
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }
//        [System.Web.Http.HttpPut]
//        public bool UpdateUser(string Id, string UserName, string UserPassword)
//        {
//            try
//            {
//                ApplicationDBContext _dbcontext = new ApplicationDBContext();
//                //lấy food tồn tại ra
//                UserEntity User = _dbcontext.User_.FirstOrDefault();
//                if (User == null) return false;//không tồn tại false
//                User.UserName = UserName;
//                User.UserPassword = UserPassword;
//                _dbcontext.SaveChanges();//xác nhận chỉnh sửa
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }
//        [System.Web.Http.HttpDelete]
//        public bool DeleteUser(int id)
//        {
//            ApplicationDBContext _dbcontext = new ApplicationDBContext();
//            //lấy food tồn tại ra
//            UserEntity User = _dbcontext.User_.FirstOrDefault();
//            if (User == null) return false;
//            _dbcontext.SaveChanges();//xác nhận chỉnh sửa
//            return true;
//        }
        
//        [System.Web.Http.HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Login(string username, string password)
//        {
//            ApplicationDBContext _db = new ApplicationDBContext();
//            if (ModelState.IsValid)
//            {
//                var f_password = GetMD5(password);
//                var data = _db.User_.Where(s => s.UserName.Equals(username) && s.UserPassword.Equals(f_password)).ToList();
//                if (data.Count() > 0)
//                {
//                    //add session
//                    Session["FullName"] = data.FirstOrDefault().FirstName + " " + data.FirstOrDefault().LastName;
//                    Session["Email"] = data.FirstOrDefault().Email;
//                    Session["idUser"] = data.FirstOrDefault().idUser;
//                    return RedirectToAction("Index");
//                }
//                else
//                {
//                    ViewBag.error = "Login failed";
//                    return RedirectToAction("Login");
//                }
//            }
//            return View();
//        }
//        //create a string MD5
//        public static string GetMD5(string str)
//        {
//            MD5 md5 = new MD5CryptoServiceProvider();
//            byte[] fromData = Encoding.UTF8.GetBytes(str);
//            byte[] targetData = md5.ComputeHash(fromData);
//            string byte2String = null;

//            for (int i = 0; i < targetData.Length; i++)
//            {
//                byte2String += targetData[i].ToString("x2");

//            }
//            return byte2String;
//        }
//    }
//}
