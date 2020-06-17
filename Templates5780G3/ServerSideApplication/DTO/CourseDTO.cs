using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class CourseDTO
    {
        public int CourseId { get; set; }
        public Nullable<System.TimeSpan> CourseTime { get; set; }
        public string CourseName { get; set; }
        public string CourseDescribe { get; set; }
        public string Proffestion { get; set; }
        public Nullable<int> MinUseres { get; set; }
        public Nullable<int> MaxUseres { get; set; }
        public Nullable<int> IdTeacher { get; set; }
        public Nullable<int> CoursePrice { get; set; }

       // public TeacherDTO Teacher { get; set; }

        public static CourseDTO CourseConvertDTO(DAL.Course d)
        {
            return new CourseDTO()
            {
                CourseId = d.CourseId,
                CourseName = d.CourseName,
                CourseDescribe=d.CourseDescribe,
                Proffestion=d.Proffestion,
                MinUseres=d.MinUseres,
                MaxUseres=d.MaxUseres,
                IdTeacher=d.IdTeacher,
                CoursePrice=d.CoursePrice
              //  Teacher=TeacherDTO.TeacherConvertDTO(d.Teacher)
            };
        }
        public static Course CourseConvertDAL(CourseDTO d )
        {
            return new Course()
            {
                CourseId = d.CourseId,
                CourseName = d.CourseName,
                CourseDescribe = d.CourseDescribe,
                Proffestion = d.Proffestion,
                MinUseres = d.MinUseres,
                MaxUseres = d.MaxUseres,
                IdTeacher = d.IdTeacher,
                CoursePrice = d.CoursePrice
                //  Teacher=TeacherDTO.TeacherConvertDTO(d.Teacher)
            };
        }
    }
}
