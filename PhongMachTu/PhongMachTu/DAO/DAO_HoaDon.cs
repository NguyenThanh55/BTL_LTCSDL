using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongMachTu.DAO
{
    public class DAO_HoaDon
    {
        QLPMEntities db;
        public DAO_HoaDon()
        {
            db = new QLPMEntities();
        }

        public dynamic HienThiHDChuaThanhToan()
        {
            var ds = db.HoaDons.Where(s => s.TrangThai == false).Select(s => new {
                s.id,
                s.NgayKham,
                s.TienKham, 
                s.TongTien
            }).ToList();
            return ds;
        }

        public dynamic HienThiHDDaThanhToan()
        {
            var ds = db.HoaDons.Where(s => s.TrangThai == true).Select(s => new {
                s.id,
                s.NgayKham,
                s.TienKham,
                s.TongTien
            }).ToList();
            return ds;
        }

        public HoaDon LayThongTinHD(int ma)
        {
            HoaDon hd = db.HoaDons.Where(s => s.id == ma).FirstOrDefault();
            return hd;
        }

        public void ThemHD(HoaDon hd)
        {
            db.HoaDons.Add(hd);
            db.SaveChanges();
        }

        public bool KiemTraHD(HoaDon hd)
        {
            HoaDon h = db.HoaDons.Find(hd.id);
            if (h != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CapNhatHD(HoaDon hd)
        {
            HoaDon h = db.HoaDons.Find(hd.id);
            h.NgayKham = hd.NgayKham;
            h.TienKham = hd.TienKham;
            h.TienDV = hd.TienDV;
            h.TienThuoc = hd.TienThuoc;
            h.TongTien = hd.TongTien;
            h.idPK = hd.idPK;
            h.TrangThai = hd.TrangThai;
            db.SaveChanges();
        }
    }
}
