//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KungFuPanda
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblParent
    {
        public int PARENT_ID { get; set; }
        public string PARENT_FNAME { get; set; }
        public string PARENT_MNAME { get; set; }
        public string PARENT_LNAME { get; set; }
        public Nullable<bool> PARENT_GENDER { get; set; }
        public string PARENT_MNUM { get; set; }
        public string PARENT_EMAIL { get; set; }
        public Nullable<bool> PARENT_IS_STUDENT { get; set; }
        public Nullable<bool> PARENT_STATUS { get; set; }
        public Nullable<int> PARENT_CREATED_BY { get; set; }
        public Nullable<System.DateTime> PARENT_CREATED_DATE { get; set; }
        public Nullable<int> PARENT_MODIFY_BY { get; set; }
        public Nullable<System.DateTime> PARENT_MODIFIED_DATE { get; set; }
        public Nullable<int> STU_ID { get; set; }
    
        public virtual tblStudent tblStudent { get; set; }
    }
}
