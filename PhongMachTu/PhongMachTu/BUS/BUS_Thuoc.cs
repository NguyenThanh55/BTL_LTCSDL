using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhongMachTu.DAO;

namespace PhongMachTu.BUS
{
    public class BUS_Thuoc
    {
        DAO_Thuoc dThuoc;
        public BUS_Thuoc()
        {
            dThuoc = new DAO_Thuoc();
        }

        public void HienThi(DataGridView dg)
        {
            dg.DataSource = dThuoc.LayDSThongTin();
        }

        public Thuoc LayThongTinThuoc(int ma)
        {
            return dThuoc.LayThongTinThuoc(ma);
        }

        public void LayDSThuoc(ComboBox cb)
        {
            cb.DataSource = dThuoc.LayDSTen();
            cb.DisplayMember = "Ten";
            cb.ValueMember = "id";
        }

        public bool themThuoc(Thuoc thuoc)
        {
            try
            {
                dThuoc.ThemThuoc(thuoc);
                return true;
            }
            catch (Exception)
            {
                return false;
               
            }
        }

        public bool suaThuoc(Thuoc thuoc)
        {
            //Kiem tra thuoc co ton tai hay k 
            if(dThuoc.KiemTraThuoc(thuoc))
            {
                try
                {
                    dThuoc.SuaThuoc(thuoc);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool xoaThuoc(Thuoc thuoc)
        {
            if (dThuoc.KiemTraThuoc(thuoc))
            {
                try
                {
                    dThuoc.XoaThuoc(thuoc);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public ChiTietTT LayThongTinCTTT(int ma)
        {
            return dThuoc.LayGiaCTTT(ma);
        }

        public bool ThemCTTT(ChiTietTT toa)
        {
            try
            {
                dThuoc.ThemCTTT(toa);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }

        public bool xoaCTTT(int ma)
        {
            if (dThuoc.KiemTraThuoc(ma))
            {
                try
                {
                    dThuoc.XoaCTTT(ma);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
