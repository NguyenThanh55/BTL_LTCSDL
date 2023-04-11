//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using PhongMachTu.DAO;

//namespace PhongMachTu.BUS
//{
//    class BUS_Account
//    {
//        DAO_Account dAccount;
//        public BUS_Account()
//        {
//            dAccount = new DAO_Account();
//        }

//        public bool DangNhap(String name, String pass)
//        {
//            if (dAccount.DangNhap(name, pass))
//                return true;
//            return false;
//        }



//        public void HienThi(DataGridView dg)
//        {
//            dg.DataSource = dAccount.LayDSThongTin();
//        }

//        public void HienThiType(ComboBox cb)
//        {
//            cb.DataSource = dAccount.LayType();
//            cb.DisplayMember = "Type";
//            cb.ValueMember = "id";
//        }
//    }
//}

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
    class BUS_Account
    {
        DAO_Account dAccount;
        public BUS_Account()
        {
            dAccount = new DAO_Account();
        }

        public bool DangNhap(String name, String pass)
        {
            if (dAccount.DangNhap(name, pass))
                return true;
            return false;
        }

        public void HienThi(DataGridView dg)
        {
            dg.DataSource = dAccount.LayDSThongTin();
        }

        public void HienThiType(ComboBox cb)
        {
            cb.DataSource = dAccount.LayType();
            cb.DisplayMember = "Type";
            cb.ValueMember = "id";
        }

        public int LayID(String username)
        {
            return dAccount.LayId(username);
        }

        public bool TaoTaiKhoan(Account account)
        {
            try
            {
                dAccount.TaoTK(account);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }

        public bool SuaTK(Account account)
        {
            //Kiem tra tK co ton tai hay k 
            if (dAccount.KiemTraTK(account))
            {
                try
                {
                    dAccount.SuaTK(account);
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

        public bool XoaTK(Account account)
        {
            if (dAccount.KiemTraTK(account))
            {
                try
                {
                    dAccount.XoaTK(account);
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
