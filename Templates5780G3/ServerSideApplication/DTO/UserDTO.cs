using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public System.DateTime UserBirthDate { get; set; }
        public bool Cover { get; set; }

        public static UserDTO UserConvertDTO(User u)
        {
            return new UserDTO
            {
                UserId=u.UserId,
                UserName=u.UserName,
                Name=u.Name,
                UserPassword=u.UserPassword,
                UserEmail=u.UserEmail,
                UserBirthDate=u.UserBirthDate,
                Cover=u.Cover,               
            };
        }
        public static User UserConvertDAL(UserDTO u)
        {
            return new User
            {
                UserId = u.UserId,
                UserName = u.UserName,
                Name = u.Name,
                UserPassword = u.UserPassword,
                UserEmail = u.UserEmail,
                UserBirthDate = u.UserBirthDate,
                Cover = u.Cover,
            };
        }
    }
}
