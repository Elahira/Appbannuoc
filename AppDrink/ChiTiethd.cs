//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppDrink
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTiethd
    {
        public int IdChitiet { get; set; }
        public Nullable<int> IdNuoc { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<double> Thanhtien { get; set; }
        public Nullable<int> IdHoadon { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual NuocUong NuocUong { get; set; }
        public string Tennuoc { get; internal set; }
    }
}
