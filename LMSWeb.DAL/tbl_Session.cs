//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMSWeb.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Session
    {
        public int Id { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> LoggedInDateTime { get; set; }
        public Nullable<System.DateTime> LoggedOutDateTime { get; set; }
        public string IPAddress { get; set; }
    
        public virtual tbl_LMSUser tbl_LMSUser { get; set; }
    }
}
