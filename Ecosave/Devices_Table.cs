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
    
    public partial class Devices_Table
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type_Of_Device { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Number_of_Devices { get; set; }
        public Nullable<int> Power_Output { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Person_Table Person_Table { get; set; }
    }
}
