//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace California_State_Polytechnic_University_Pomona.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public string Course_Name { get; set; }
        public int Course_Id { get; set; }
        public Nullable<int> FK_Dept_Id { get; set; }
        public Nullable<int> FK_Prof_Id { get; set; }
        public int Course_Credit { get; set; }
        public string Days___Times { get; set; }
        public string Room { get; set; }
    
        public virtual Enroll Enroll { get; set; }
        public virtual Department Department { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
