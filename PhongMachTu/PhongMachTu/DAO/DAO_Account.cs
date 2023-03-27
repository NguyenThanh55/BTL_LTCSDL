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
        QLPMEntities1 db;
        public DAO_Account()
        {
            db = new QLPMEntities1();
        }

        public bool DangNhap(String name, String pass)
        {
            int? acc;
            acc = db.SP_GetAccountByUsername(name, pass).FirstOrDefault();
            if (acc == 1)
                return true;
            return false;
        }

        public dynamic LayDSThongTin()
        {
            var ds = db.Accounts.Select(s => new
            {
                s.id,
                s.Username,
                s.Password,
                s.Type
            }).ToList();
            return ds;
        }

        public dynamic LayType()
        {
            var ds = db.Accounts.Select(s => new
            { s.id, s.Type }).ToList();
            return ds;
        }
    }
}
