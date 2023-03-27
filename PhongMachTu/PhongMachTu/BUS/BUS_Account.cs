using System;
using System.Collections.Generic;
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
    }
}
