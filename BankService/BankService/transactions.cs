//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankService
{
    using System;
    using System.Collections.Generic;



    public partial class transactions
    {
        public int id { get; set; }
        public int accId { get; set; }
        public System.DateTime transDate { get; set; }
        public decimal transAmount { get; set; }
    
        public virtual accounts accounts { get; set; }
    }
}
