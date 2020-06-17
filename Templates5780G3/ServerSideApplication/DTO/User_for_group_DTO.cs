using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class User_for_group_DTO
    {
        public int Id { get; set; }
        public int IdGroup { get; set; }
        public int IdUser { get; set; }
        public Nullable<System.DateTime> DateJoin { get; set; }

        public virtual Group Groups { get; set; }
        public virtual User Useres { get; set; }

        public static User_for_group_DTO user_For_Group_Convert_DTO(User_for_Group u)
        {
            return new User_for_group_DTO
            {
                Id=u.Id,
                IdGroup=u.IdGroup,
                IdUser=u.IdUser,
                DateJoin=u.DateJoin,
                Groups=u.Group,
                //Useres=u.use
            };
        }
        public static User_for_Group user_For_Group_Convert_DAL(User_for_group_DTO  u)
        {
            return new User_for_Group 
            {
                Id = u.Id,
                IdGroup = u.IdGroup,
                IdUser = u.IdUser,
                DateJoin = u.DateJoin,
                Group = u.Groups,
                //Usere = u.Useres
            };
        }

    }
}
