//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CropAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class INVOICE
    {
        public int ID { get; set; }
        public Nullable<int> Orders_ID { get; set; }
        public Nullable<int> Crop_ID { get; set; }
        public string Crop_Name { get; set; }
        public int Crop_Qty { get; set; }
        public Nullable<decimal> Total_Price { get; set; }
        public Nullable<int> User_ID { get; set; }
    
        public virtual CROP CROP { get; set; }
        public virtual ORDER ORDER { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
