using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class Massege_GroupDTO
    {
        public int MassegeId { get; set; }
        public Nullable<int> IdGroup { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<System.TimeSpan> MassegeTime { get; set; }

        public static Massege_GroupDTO Massege_GroupConvertDTO(Massege_Group m)
        {

            return new Massege_GroupDTO()
            {
                MassegeId = m.MassegeId,
                IdGroup = m.IdGroup,
                IdUser = m.IdUser,
                MassegeTime = m.MassegeTime
            };
        }
        public static Massege_Group Massege_GroupConvertDAL(Massege_GroupDTO m)
        {

            return new Massege_Group()
            {
                MassegeId = m.MassegeId,
                IdGroup = m.IdGroup,
                IdUser = m.IdUser,
                MassegeTime = m.MassegeTime
            };
        }
    }
}
    
