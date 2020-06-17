using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL
{
    public class UserBl
    {
        public static bool LoginUser(string username, string password)
        {

            using (DAL.SchoolEntities DB = new DAL.SchoolEntities())
            {
                UserDTO newuser = new UserDTO();
                foreach (var item in DB.Users)
                {
                    if (item.UserName == username && item.UserPassword == password)
                        return true;
                }
                newuser.UserName = username;
                newuser.UserPassword = password;
                DB.Users.Add(UserDTO.UserConvertDAL(newuser));
                return false;

            }

        }
        public static void RegisterUser(UserDTO user)
        {
           var userDal= UserDTO.UserConvertDAL(user);
            using (DAL.SchoolEntities DB = new DAL.SchoolEntities())
            {
                 //var y = DB.Users.Where(t => t.UserPassword == user.UserPassword).ToList();
                //if(y!=null)
                //    DB.Users.Add(userDal);
                DB.Users.Add(userDal);
            }
        }
        public static List<User> GetAllUsers(int teacherid)
        {
            using (DAL.SchoolEntities DB = new DAL.SchoolEntities())
            {
                List<UserDTO> listUsers = new List<UserDTO>();
                //עוברים על טבלת קורסים ושולפים את הקורסים של המורה הנוחכי
                var e = DB.Courses.Where(t => t.IdTeacher == teacherid).ToList();
                //רצינו לשלוף את הקבוצות של אותו הקורס והכל בשביל שנוכל להגיע לתלמיד שנמצא ב groupforuser
                DB.Groups.Where(y => y.CodeCourse = e.CourseId);             
               //איך אנחנו ניגשות לתלמידים של אותו מורה בדרך ישרה יותר
               //תודה אין מילים נשמהההה!
            }
        }

    }
}
