//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhongMachTu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {
            this.ChiTietTTs = new HashSet<ChiTietTT>();
        }
    
        public int id { get; set; }
        public string Ten { get; set; }
        public string DonVi { get; set; }
        public string CongDung { get; set; }
        public int SoLuong { get; set; }
        public string NhaSX { get; set; }
        public int TienThuoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietTT> ChiTietTTs { get; set; }
    }
}
