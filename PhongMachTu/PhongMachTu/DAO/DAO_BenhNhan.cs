using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongMachTu.DAO
{
    public class DAO_BenhNhan
    {
        QLPMEntities1 db;
        public DAO_BenhNhan()
        {
            db = new QLPMEntities1();
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

        public void ThemBN(BenhNhan benhNhan)
        {
            db.BenhNhans.Add(benhNhan);
            db.SaveChanges();
        }
    }
}
