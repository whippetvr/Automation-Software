//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lrt_Ilukste
{
    using System;
    using System.Collections.Generic;
    
    public partial class Events
    {
        public int EventID { get; set; }
        public Nullable<System.DateTime> DataTime { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Message { get; set; }
    
        public virtual Users Users { get; set; }
    }
}