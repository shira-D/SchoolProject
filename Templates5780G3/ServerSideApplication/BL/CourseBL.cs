using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BL
{
    public class CourseBL
    {
        public static List<CourseDTO> GetAllCourse(int teacherid)
        {
            using (DAL.SchoolEntities DB = new DAL.SchoolEntities())
            {
                List<CourseDTO> listCourse = new List<CourseDTO>();
                var e = DB.Courses.Where(t => t.IdTeacher == teacherid);

                foreach (var item in e)
                {
                    listCourse.Add(CourseDTO.CourseConvertDTO(item));
                }
                return listCourse;
            }
        }

        public static bool createCourse(CourseDTO course)
        {
            var courseDal = CourseDTO.CourseConvertDAL(course);
            try
            {
                using (DAL.SchoolEntities DB = new DAL.SchoolEntities())
                {
                    DB.Courses.Add(courseDal);
                    DB.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        //public static void StudentDetiels(int teacherid)
        //{
        //    using (DAL.SchoolEntities DB = new DAL.SchoolEntities())
        //    {
        //        List<UserDTO> useres = new List<UserDTO>();
        //        var user=DB.Users.Where(s=>s.)
        //    }
        //    }
        //}
    }
}
