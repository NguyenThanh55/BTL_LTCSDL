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
    
    public partial class ChiTietTT
    {
        public int id { get; set; }
        public int LieuLuong { get; set; }
        public int Gia { get; set; }
        public string CachDung { get; set; }
        public int idThuoc { get; set; }
        public int idHD { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual Thuoc Thuoc { get; set; }
    }
}
