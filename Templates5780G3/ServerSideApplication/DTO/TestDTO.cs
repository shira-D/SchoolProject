using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class TestDTO
    {
        public int TestId { get; set; }
        public Nullable<int> IdLesson { get; set; }
        public string TestName { get; set; }
        public string TestSub { get; set; }

        public static TestDTO TestConvertDTO(Test t)
        {
            return new TestDTO()
            {
               TestId=t.TestId,
               IdLesson=t.IdLesson,
               TestName=t.TestName,
               TestSub=t.TestSub
            };
        }
        public static Test TestConvertDAL(TestDTO t)
        {
            return new Test()
            {
                TestId = t.TestId,
                IdLesson = t.IdLesson,
                TestName = t.TestName,
                TestSub = t.TestSub
            };
        }
    }
}
