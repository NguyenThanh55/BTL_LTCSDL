using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongMachTu.DAO
{
    public class DAO_Account
    {
        QuanLyPhongMachTuEntities db;
        public DAO_Account()
        {
            db = new QuanLyPhongMachTuEntities();
        }

        public bool DangNhap(String name, String pass)
        {
            int? acc;
            acc = db.getAccount(name, pass).FirstOrDefault();
            if (acc == 1)
                return true;
            return false;
        }
    }
}
