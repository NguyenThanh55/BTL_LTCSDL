using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongMachTu.DAO
{
    public class DAO_PhieuKham
    {
        QLPMEntities db;
        public DAO_PhieuKham()
        {
            db = new QLPMEntities();
        }
        public dynamic LayNgayKham()
        {
            var ds = db.PhieuKhams.Select(s => new
            {
                s.idBN,
                s.NgayKham,
            }).ToList();
            return ds;
        }
        public PhieuKham LayThongTinPhieuKham(int ma)
        {
            PhieuKham pk = db.PhieuKhams.Where(s => s.id == ma).FirstOrDefault();
            return pk;
        }

        public void TaoPK(PhieuKham pk)
        {
            db.PhieuKhams.Add(pk);
            db.SaveChanges();
        }
    }
}
