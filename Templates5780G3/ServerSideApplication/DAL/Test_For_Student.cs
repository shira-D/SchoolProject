//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Test_For_Student
    {
        public int Test_For_Student_Id { get; set; }
        public Nullable<int> IdTest { get; set; }
        public Nullable<int> CodeUser { get; set; }
        public Nullable<int> Mark { get; set; }
        public Nullable<System.TimeSpan> Time_Test { get; set; }
        public Nullable<decimal> During_Test { get; set; }
        public Nullable<System.DateTime> Date_Test { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual Test Test { get; set; }
        public virtual User User { get; set; }
    }
}
