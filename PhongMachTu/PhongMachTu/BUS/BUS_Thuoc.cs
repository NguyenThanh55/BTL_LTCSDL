﻿using System;
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
    }
}
