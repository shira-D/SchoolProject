using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;
using System.Web.Http.Cors;
using DAL;
namespace API.Controllers
{
   // [EnableCors(origins:"*",headers:"*",methods:"*")]
    [RoutePrefix("api/Teacher")]
    public class TeacherController : ApiController
    {
        [HttpGet]
        [Route("GetAllTeacher")]
        public  List<TeacherDTO> GetAllTeacher()
        {
            return TeacherBL.GetAllTeacher();
        }
        [HttpGet]
        [Route("LoginTeacher")]
        public bool LoginTeacher(string passward, string username)
        {
            return UserBl.LoginUser(passward, username);
        }
        [HttpPost]
        [Route("registerTeacher")]
        public void registerTeacher(Teacher  teacher)
        {
            TeacherBL.registerTeacher(teacher);
        }
    }
}
