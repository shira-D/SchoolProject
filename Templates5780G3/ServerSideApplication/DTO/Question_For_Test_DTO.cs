using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class Question_For_Test_DTO
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public Nullable<int> AnswerId { get; set; }
        public static Question_For_Test_DTO Question_For_Test_Convert_DTO(Question_For_Test q)
        {
            return new Question_For_Test_DTO
            {
                QuestionId=q.QuestionId,
                Question=q.Question,
                AnswerId=q.AnswerId,             
            };
        }
        public static Question_For_Test Question_For_Test_Convert_DAL(Question_For_Test_DTO q)
        {
            return new Question_For_Test 
            {
                QuestionId = q.QuestionId,
                Question = q.Question,
                AnswerId = q.AnswerId,
            };
        }
    }
}
