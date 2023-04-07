using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhongMachTu.DAO;

namespace PhongMachTu.BUS
{
    public class BUS_DichVu
    {
        DAO_DichVu dDichVu;
        public BUS_DichVu()
        {
            dDichVu = new DAO_DichVu();
        }

        public void LayDSDV(ComboBox cb)
        {
            cb.DataSource = dDichVu.LayDSTen();
            cb.DisplayMember = "tenDV";
            cb.ValueMember = "id";
        }

        public DichVu LayThongTinDichVu(int ma)
        {
            return dDichVu.LayGia(ma);
        }

        public void hienThi(DataGridView dg)
        {
             dg.DataSource = dDichVu.LayDSThongTin();
        }

        public CTDV LayThongTinCTDichVu(int ma)
        {
            return dDichVu.LayGiaCTDV(ma);
        }

        public bool ThemCTDV(CTDV dichvu)
        {
            try
            {
                dDichVu.ThemCTDV(dichvu);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }

        //public bool capNhatCTDV(CTDV dichvu)
        //{
        //    //Kiem tra thuoc co ton tai hay k 
        //    if (dDichVu.KiemTraDV(dichvu))
        //    {
        //        try
        //        {
        //            dDichVu.CapNhatDV(dichvu);
        //            return true;
        //        }
        //        catch (DbUpdateException ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool xoaDV(int ma)
        {
            if (dDichVu.KiemTraDV(ma))
            {
                try
                {
                    dDichVu.XoaCTDV(ma);
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
