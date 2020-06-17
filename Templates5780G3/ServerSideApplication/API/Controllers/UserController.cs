using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BL;
using DAL;

namespace API.Controllers
{
    [RoutePrefix("api/User1")]
      
    public class UserController
    {
    
            [HttpGet]
            [Route("LoginUser/{username}/{password}")]
            public  bool LoginUser(string passward, string username)
            {
                return UserBl.LoginUser(username,passward);
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