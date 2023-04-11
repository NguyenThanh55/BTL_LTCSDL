//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PhongMachTu.DAO
//{
//    public class DAO_Account
//    {
//        QLPMEntities db;
//        public DAO_Account()
//        {
//            db = new QLPMEntities();
//        }

//        public bool DangNhap(String name, String pass)
//        {
//            int? acc;
//            acc = db.SP_GetAccountByUsername(name, pass).FirstOrDefault();
//            if (acc == 1)
//                return true;
//            return false;
//        }



//        public dynamic LayDSThongTin()
//        {
//            var ds = db.Accounts.Select(s => new
//            {
//                s.id,
//                s.Username,
//                s.Password,
//                s.Type
//            }).ToList();
//            return ds;
//        }

//        public dynamic LayType()
//        {
//            var ds = db.Accounts.Select(s => new
//            { s.id, s.Type }).ToList();
//            return ds;
//        }
//    }
//}

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
        QLPMEntities db;
        public DAO_Account()
        {
            db = new QLPMEntities();
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

        public int LayId(String user)
        {
            var ds = db.SP_GetID(user).Select(s => new { s.Value }).ToList();
            return ds[0].Value;
        }

        public dynamic LayDSID()
        {
            var ds = db.Accounts.Select(s => new { s.id }).ToList();
            return ds;
        }

        public void TaoTK(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }

        public bool KiemTraTK(Account account)
        {
            Account t = db.Accounts.Find(account.id);
            if (account != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SuaTK(Account accout)
        {
            Account t = db.Accounts.Find(accout.id);
            t.id = accout.id;
            t.Type = accout.Type;
            t.Username = accout.Username;
            t.Password = accout.Password;
            db.SaveChanges();
        }

        public void XoaTK(Account account)
        {
            Account t = db.Accounts.Find(account.id);
            db.Accounts.Remove(t);
            db.SaveChanges();
        }


    }
}