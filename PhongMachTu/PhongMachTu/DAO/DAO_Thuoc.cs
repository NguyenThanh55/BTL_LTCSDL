using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongMachTu.DAO
{
    public class DAO_Thuoc
    {
        QLPMEntities1 db;
        public DAO_Thuoc()
        {
            db = new QLPMEntities1();
        }

        public dynamic LayDSThongTin()
        {
            var ds = db.Thuocs.Select(s => new
            {
                s.id,
                s.Ten,
                s.DonVi,
                s.CongDung,
                s.SoLuong,
                s.NhaSX
            }).ToList();
            return ds;
        }

        public void ThemThuoc(Thuoc thuoc)
        {
            db.Thuocs.Add(thuoc);
            db.SaveChanges();
        }

        public bool KiemTraThuoc(Thuoc thuoc)
        {
            Thuoc t = db.Thuocs.Find(thuoc.id);
            if (thuoc != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SuaThuoc(Thuoc thuoc)
        {
            Thuoc t = db.Thuocs.Find(thuoc.id);
            t.Ten = thuoc.Ten;
            t.DonVi = thuoc.DonVi;
            t.CongDung = thuoc.CongDung;
            t.SoLuong = thuoc.SoLuong;
            t.NhaSX = thuoc.NhaSX;
            db.SaveChanges();
        }

        public void XoaThuoc(Thuoc thuoc)
        {
            Thuoc t = db.Thuocs.Find(thuoc.id);
            db.Thuocs.Remove(t);
            db.SaveChanges();
        }
    }
}
