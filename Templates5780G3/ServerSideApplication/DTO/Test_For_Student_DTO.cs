using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class Test_For_Student_DTO
    {
        public int Test_For_Student_Id { get; set; }
        public Nullable<int> IdTest { get; set; }
        public Nullable<int> CodeUser { get; set; }
        public Nullable<int> Mark { get; set; }
        public Nullable<System.TimeSpan> Time_Test { get; set; }

        public static Test_For_Student_DTO Test_For_Student_Convert_DTO(Test_For_Student t)
        {
            return new Test_For_Student_DTO
            {
                Test_For_Student_Id=t.Test_For_Student_Id,
                IdTest=t.IdTest,
                CodeUser=t.CodeUser,
                Mark=t.Mark,
                Time_Test=t.Time_Test              
            };
        }
        public static Test_For_Student Test_For_Student_Convert_DAL(Test_For_Student_DTO t)
        {
            return new Test_For_Student 
            {
                Test_For_Student_Id = t.Test_For_Student_Id,
                IdTest = t.IdTest,
                CodeUser = t.CodeUser,
                Mark = t.Mark,
                Time_Test = t.Time_Test
            };
        }
    }
}
