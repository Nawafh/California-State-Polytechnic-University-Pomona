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
    
    public partial class Enroll
    {
        public Nullable<int> FK_Student_ID { get; set; }
        public int FK_Course_ID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}