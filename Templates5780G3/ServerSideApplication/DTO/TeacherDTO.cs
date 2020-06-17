using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class TeacherDTO
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherPhone { get; set; }
        public Nullable<int> TeacherAge { get; set; }
        public string Describe { get; set; }
        public string Password { get; set; }
        public string UserNmae { get; set; }
        //
      public List<CourseDTO> Course { get; set; }

        public static TeacherDTO TeacherConvertDTO(Teacher t)
        {//
            if (t == null)
                return null;
            List<CourseDTO> course = new List<CourseDTO>();
            foreach (var item in t.Courses)
            {
                course.Add(CourseDTO.CourseConvertDTO(item));
            }
            return new TeacherDTO() 
            {
                TeacherId=t.TeacherId,
                TeacherName=t.TeacherName,
                TeacherEmail=t.TeacherEmail,
                TeacherPhone=t.TeacherPhone,
                TeacherAge=t.TeacherAge,
                Describe=t.Describe,
                Password=t.Password,
                UserNmae=t.UserNmae,
               Course=course

            };
        }
        public static Teacher TeacherConvertDAL(TeacherDTO t)
        {
            return new Teacher()
            {
                TeacherId = t.TeacherId,
                TeacherName = t.TeacherName,
                TeacherEmail = t.TeacherEmail,
                TeacherPhone = t.TeacherPhone,
                TeacherAge = t.TeacherAge,
                Describe = t.Describe,
                Password = t.Password,
                UserNmae = t.UserNmae

            };
        }
    }
}
