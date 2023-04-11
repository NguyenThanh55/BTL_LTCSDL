//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PhongMachTu.DAO
//{
//    public class DAO_BenhNhan
//    {
//        QLPMEntities db;
//        public DAO_BenhNhan()
//        {
//            db = new QLPMEntities();
//        }

//        public dynamic LayDSThongTin()
//        {
//            var ds = db.BenhNhans.Select(s => new
//            {
//                s.id,
//                s.Ten,
//                s.GioiTinh,
//                s.NgaySinh,
//                s.DiaChi
//            }).ToList();
//            return ds;
//        }





//        public dynamic LayDSTen() 
//        {
//            var ds = db.BenhNhans.Select(s => new
//            { s.id, s.Ten }).ToList();
//            return ds;
//        }

//        public void ThemBN(BenhNhan benhNhan)
//        {
//            db.BenhNhans.Add(benhNhan);
//            db.SaveChanges();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongMachTu.DAO
{
    public class DAO_BenhNhan
    {
        QLPMEntities db;
        public DAO_BenhNhan()
        {
            db = new QLPMEntities();
        }

        public dynamic LayDSThongTin()
        {
            var ds = db.BenhNhans.Select(s => new
            {
                s.id,
                s.Ten,
                s.GioiTinh,
                s.NgaySinh,
                s.DiaChi
            }).ToList();
            return ds;
        }

        public dynamic LayDSTen()
        {
            var ds = db.BenhNhans.Select(s => new
            { s.id, s.Ten }).ToList();
            return ds;
        }

        public BenhNhan LayThongTinBenhNhan(int ma)
        {
            BenhNhan bn = db.BenhNhans.Where(s => s.id == ma).FirstOrDefault();
            return bn;
        }

        public List<BenhNhan> LayDSThongTinBN(String ten)
        {
            return db.BenhNhans.Where(s => s.Ten.Contains(ten)).ToList();
        }

        public void ThemBN(BenhNhan benhNhan)
        {
            db.BenhNhans.Add(benhNhan);
            db.SaveChanges();
        }

        public bool KiemTraTK(BenhNhan bn)
        {
            BenhNhan b = db.BenhNhans.Find(bn.id);
            if (bn != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public dynamic TimKiem(string ten)
        {
            var ds = db.BenhNhans.Where(t => t.Ten.Contains(ten)).
                Select(s => new
                {
                    s.id,
                    s.Ten,
                    s.GioiTinh,
                    s.NgaySinh,
                    s.DiaChi
                }).ToList();
            return ds;
        }
    }
}
