using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class LessonDTO
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string Describe { get; set; }
        public Nullable<System.TimeSpan> LessonTime { get; set; }
        public string LessonSub { get; set; }
        public int IdCourse { get; set; }
        public string Link { get; set; }

        public static LessonDTO LessonConvertDTO(Lesson l)
        {
          
            return new LessonDTO()
            {
                LessonId=l.LessonId,
                LessonName=l.LessonName,
                Describe=l.Describe,
                LessonSub=l.LessonSub,
                IdCourse=l.IdCourse,
                Link=l.Link
            };
        }
        public static Lesson LessonConvertDAL(LessonDTO l)
        {
            return new Lesson()
            {
                LessonId = l.LessonId,
                LessonName = l.LessonName,
                Describe = l.Describe,
                LessonSub = l.LessonSub,
                IdCourse = l.IdCourse,
                Link = l.Link

            };
        }
    }
}

