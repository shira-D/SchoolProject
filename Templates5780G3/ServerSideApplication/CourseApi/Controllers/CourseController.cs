using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DTO;
namespace CourseApi.Controllers
{
    [RoutePrefix("api/course")]
    public class CourseController : ApiController
    {
        [HttpGet]
        [Route("getAllCourses/{teacherid}")]
        public List<CourseDTO> GetAllCourse(int teacherid)
        {
           return  CourseBL.GetAllCourse(teacherid);
        }
        [HttpPost]
        [Route("createCourse")]
        public bool createCourse(CourseDTO course)
        {
          return CourseBL.createCourse(course);
        }
    }
}
