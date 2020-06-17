using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    class Answer_for_Test_DTO
    {
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public static Answer_for_Test_DTO Answer_For_Test_Convert_DTO(Answer_for_Test a)
        {
            return new Answer_for_Test_DTO
            {
                QuestionId=a.QuestionId,
                Answer=a.Answer.ToString(),               
            };
        }
    }
}
