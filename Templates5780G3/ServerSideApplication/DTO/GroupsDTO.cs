using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class GroupsDTO
    {


        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Nullable<System.TimeSpan> DateOpen { get; set; }
        public int CodeCourse { get; set; }
        public static GroupsDTO GroupsConvertDTO(Group l)
        {

            return new GroupsDTO()
            {
                GroupId = l.GroupId,
                GroupName = l.GroupName,
                CodeCourse = l.CodeCourse,
                DateOpen = l.DateOpen
            };
        }
        public static Group GroupsConvertDTO(GroupsDTO l)
        {

            return new Group()
            {
                GroupId = l.GroupId,
                GroupName = l.GroupName,
                CodeCourse = l.CodeCourse,
                DateOpen = l.DateOpen
            };
        }


    }
}