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
    
    public partial class Calculator
    {
        public int ID { get; set; }
        public Nullable<double> Power_Average { get; set; }
        public string Device { get; set; }
        public Nullable<int> Hours_Used { get; set; }
        public Nullable<double> Daily_Average { get; set; }
        public Nullable<double> Weekly_Average { get; set; }
        public Nullable<double> Monthly_Average { get; set; }
        public Nullable<double> Yearly_Average { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Person_Table Person_Table { get; set; }
    }
}
