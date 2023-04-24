using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongMachTu.DAO
{
    internal class DAO_LSBN
    {
        QLPMEntities db;
        public DAO_LSBN()
        {
            db = new QLPMEntities();
        }
        public dynamic HienThiDSBN()
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
    }
}