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
    
    public partial class NuocUong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NuocUong()
        {
            this.ChiTiethd = new HashSet<ChiTiethd>();
        }
    
        public int IdNuoc { get; set; }
        public string TenNuoc { get; set; }
        public Nullable<double> Gia { get; set; }
        public Nullable<int> IdTheloai { get; set; }
    
        public virtual TheLoai TheLoai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiethd> ChiTiethd { get; set; }
        public string Tentheloai { get; internal set; }
    }
}
