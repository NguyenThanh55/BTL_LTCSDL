using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongMachTu.DAO
{
    public class DAO_Thuoc
    {
        QLPMEntities db;
        public DAO_Thuoc()
        {
            db = new QLPMEntities();
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
                s.NhaSX,
                s.TienThuoc
            }).ToList();
            return ds;
        }

        public Thuoc LayThongTinThuoc(int ma)
        {
            Thuoc t = db.Thuocs.Where(s => s.id == ma).FirstOrDefault();
            return t;
        }

        public dynamic LayDSTen()
        {
            var ds = db.Thuocs.Select(s => new
            { s.id, s.Ten }).ToList();
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
            if (t != null)
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
            t.TienThuoc = thuoc.TienThuoc;
            db.SaveChanges();
        }

        public void XoaThuoc(Thuoc thuoc)
        {
            Thuoc t = db.Thuocs.Find(thuoc.id);
            db.Thuocs.Remove(t);
            db.SaveChanges();
        }

        public ChiTietTT LayGiaCTTT(int id)
        {
            ChiTietTT dv = db.ChiTietTTs.Where(s => s.id == id).FirstOrDefault();
            return dv;
        }

        public void ThemCTTT(ChiTietTT toa)
        {
            db.ChiTietTTs.Add(toa);
            db.SaveChanges();
        }

        public bool KiemTraThuoc(int ma)
        {
            ChiTietTT thuoc = db.ChiTietTTs.Find(ma);
            //CTDV d = db.CTDVs.Find(dv.idDV);
            if (thuoc != null)
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

        public void XoaCTTT(int ma)
        {
            try
            {
                ChiTietTT thuoc = db.ChiTietTTs.Find(ma);
                //CTDV d = db.CTDVs.Find(dv.idDV);
                db.ChiTietTTs.Remove(thuoc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
