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
        public string ID { get; set; }
        public Nullable<double> Power_Average { get; set; }
        public Nullable<int> Number_Of_Devices { get; set; }
    
        public virtual Billing_Table Billing_Table { get; set; }
    }
}
