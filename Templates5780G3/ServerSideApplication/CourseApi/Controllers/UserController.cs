using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CourseApi.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("LoginUser/{username}/{password}")]
        public bool LoginUser(string passward, string username)
        {
            return UserBl.LoginUser(username, passward);
        }
        [HttpGet]
        [Route("get")]
        public bool Login()
        {
            return true;
        }
        [HttpPost]
        [Route("RegisterUser")]
        public void RegisterUser(UserDTO user)
        {
            UserBl.RegisterUser(user);
        }
    }
}
