using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI.Models;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        private List<UserModel> AllUser()
        {
            List<UserModel> list = new List<UserModel>();
            for (int i = 1; i < 6; i++)   // Tạo ra 6 User
            {
                UserModel u = new UserModel()   // Tạo ra user mới
                {
                    UserName = $"user {i}",
                    UserPassword = $"password {i}",
                };
                list.Add(u);   // Thêm vào danh sách User
            }
            return list;
        }

        [HttpGet] // Cho phép truy cập với phương thức là GET
        public HttpResponseMessage GetAllUser()
        {
            var list = AllUser();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }

}
