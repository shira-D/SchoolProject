using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL
{
   public  class TeacherBL
    {
        public static List<TeacherDTO> GetAllTeacher()
        {
            using (DAL.SchoolEntities DB = new DAL.SchoolEntities())
            {
                List<TeacherDTO> t = new List<TeacherDTO>();

                foreach (var item in DB.Teachers)
                {
                    t.Add(TeacherDTO.TeacherConvertDTO(item));
                }
                return t;
            }
        }
        
        public static bool RegisterTeacher(TeacherDTO teacher)
            {
            try
            {
                var teacherDal = TeacherDTO.TeacherConvertDAL(teacher);
                using (DAL.SchoolEntities DB = new DAL.SchoolEntities())
                {
                    //TeacherDTO myteacher = new TeacherDTO();
                    //myteacher.TeacherId = teacher.TeacherId;
                    //myteacher.TeacherName = teacher.TeacherName;
                    //myteacher.TeacherEmail = teacher.TeacherEmail;
                    //myteacher.TeacherPhone = teacher.TeacherPhone;
                    //myteacher.TeacherAge = teacher.TeacherAge;
                    //myteacher.Describe = teacher.Describe;
                    //myteacher.Password = teacher.Password;
                    //myteacher.UserNmae = teacher.UserNmae;

                    DB.Teachers.Add(teacherDal);
                    DB.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
           
        }
        public static TeacherDTO LoginTeacher(string username, string password)
        {
            using (DAL.SchoolEntities DB = new DAL.SchoolEntities())
            {
                UserDTO newteacher = new UserDTO();

                // var a = DB.Teachers.FirstOrDefault(t => t.UserNmae == username && t.Password == password);

               var teacher= DB.Teachers.FirstOrDefault(p => p.Password == password && p.UserNmae == username);
                return TeacherDTO.TeacherConvertDTO(teacher);
            }

        }
    }
}
