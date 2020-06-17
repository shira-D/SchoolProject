using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;
using CourseApi.Models;

namespace CourseApi.Controllers
{
    [RoutePrefix("api/Teacher")]
    public class TeacherController : ApiController
    {
        [HttpPost]
        [Route("RegisterTeacher")]
        public bool RegisterUser(TeacherDTO teacher)
        {
           return TeacherBL.RegisterTeacher(teacher);
        }
        [HttpPost]
        [Route("LoginTeacher")]
        public TeacherDTO LoginTeacher(Login login)
        {
            return TeacherBL.LoginTeacher(login.UserName, login.Password);
        }
        [HttpGet]
        [Route("GetAllTeacher")]
        public List<TeacherDTO> GetAllTeacher()
        {

            return TeacherBL.GetAllTeacher();
        }
    }
}
