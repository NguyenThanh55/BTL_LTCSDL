using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongMachTu.DAO
{
    
    public class DAO_ThongKe
    {
        QLPMEntities db;
        public DAO_ThongKe()
        {
            db = new QLPMEntities();
        }

        public dynamic DoanhThuThuoc()
        {
            var list = db.ChiTietTTs.Select(t => new {
                t.Thuoc.Ten,
                t.HoaDon.NgayKham,
                t.LieuLuong,
                t.Gia
            }).ToList();
            return list;
        }

        public int? SoBN(int? soThang)
        {
            return db.SP_DEM(soThang).FirstOrDefault();
        }
    }
}
