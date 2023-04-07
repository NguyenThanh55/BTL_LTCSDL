using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongMachTu.DAO
{
    public class DAO_DichVu
    {
        QLPMEntities db;
        public DAO_DichVu()
        {
            db = new QLPMEntities();
        }

        public dynamic LayDSThongTin()
        {
            var ds = db.CTDVs.Select(s => new
            {
                s.id,
                s.idHD,
                s.idDV,
                s.Gia
            }).ToList();
            return ds;
        }


        public dynamic LayDSTen()
        {
            var ds = db.DichVus.Select(s => new
            { s.id, s.tenDV }).ToList();
            return ds;
        }

        public DichVu LayGia(int id)
        {
            DichVu dv = db.DichVus.Where(s => s.id == id).FirstOrDefault();
            return dv;
        }

        public void ThemCTDV(CTDV dichVu)
        {
            db.CTDVs.Add(dichVu);
            db.SaveChanges();
        }

        public bool KiemTraDV(int ma)
        {
            CTDV dv = db.CTDVs.Find(ma);
            //CTDV d = db.CTDVs.Find(dv.idDV);
            if (dv != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void CapNhatDV(CTDV dichvu)
        //{
        //    CTDV dv = db.CTDVs.Find(dichvu.id);
        //    dv.idHD = dichvu.idHD;
        //    dv.idDV = dichvu.idDV;
        //    dv.Gia = dichvu.Gia;
        //    db.SaveChanges();
        //}

        public void XoaCTDV(int ma)
        {
            try
            {
                CTDV dv = db.CTDVs.Find(ma);
                //CTDV d = db.CTDVs.Find(dv.idDV);
                db.CTDVs.Remove(dv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public CTDV LayGiaCTDV(int id)
        {
            CTDV dv = db.CTDVs.Where(s => s.id == id).FirstOrDefault();
            return dv;
        }
    }
}
