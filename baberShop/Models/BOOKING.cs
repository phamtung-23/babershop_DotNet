//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace baberShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOOKING
    {
        public int ID_BOOKING { get; set; }
        public Nullable<int> ID_USER { get; set; }
        public string NAME_BOOK { get; set; }
        public string PHONE_BOOK { get; set; }
        public Nullable<System.DateTime> DATE_BOOKING { get; set; }
        public Nullable<System.TimeSpan> TIME_BOOKING { get; set; }
        public string COMMENT { get; set; }
        public Nullable<int> TRANGTHAI { get; set; }
    
        public virtual ACCOUNT_USER ACCOUNT_USER { get; set; }
    }
}
