//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecosave
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person_Table
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Parish { get; set; }
        public string Street { get; set; }
        public string ZIP_Code { get; set; }
        public string Occupation { get; set; }
        public string Telephone { get; set; }
        public Nullable<decimal> Budget_for_Utilities { get; set; }
        public Nullable<decimal> Income { get; set; }
        public Nullable<int> UserID { get; set; }
        public string CardNumber { get; set; }
        public string CardExperation { get; set; }
        public string CardCvv { get; set; }
    
        public virtual User User { get; set; }
    }
}
