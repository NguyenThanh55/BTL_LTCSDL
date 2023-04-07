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
    public class BUS_HoaDon
    {
        DAO_HoaDon dHoaDon;
        public BUS_HoaDon()
        {
            dHoaDon = new DAO_HoaDon();
        }

        public void HienThiHDChuaThanhToan(DataGridView dg)
        {
            dg.DataSource = dHoaDon.HienThiHDChuaThanhToan();
        }

        public void HienThiHDDaThanhToan(DataGridView dg)
        {
            dg.DataSource = dHoaDon.HienThiHDDaThanhToan();
        }

        public HoaDon HienThiThongTinHD(int ma)
        {
            return dHoaDon.LayThongTinHD(ma);
        }

        public bool ThemHD(HoaDon hd)
        {
            try
            {
                dHoaDon.ThemHD(hd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }

        public bool CapNhatHD(HoaDon hd)
        {
            //Kiem tra thuoc co ton tai hay k 
            if (dHoaDon.KiemTraHD(hd))
            {
                try
                {
                    dHoaDon.CapNhatHD(hd);
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
