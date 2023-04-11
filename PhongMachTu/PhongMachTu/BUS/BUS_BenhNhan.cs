//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using PhongMachTu.DAO;

//namespace PhongMachTu.BUS
//{
//    public class BUS_BenhNhan
//    {
//        DAO_BenhNhan dBenhNhan;
//        public BUS_BenhNhan()
//        {
//            dBenhNhan = new DAO_BenhNhan();
//        }

//        public void HienThi(DataGridView dg)
//        {
//            dg.DataSource = dBenhNhan.LayDSThongTin();
//        }





//        public void LayDSBN(ComboBox cb)
//        {
//            cb.DataSource = dBenhNhan.LayDSTen();
//            cb.DisplayMember = "Ten";
//            cb.ValueMember = "id";
//        }

//        public bool themBN(BenhNhan benhNhan)
//        {
//            try
//            {
//                dBenhNhan.ThemBN(benhNhan);
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;

//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhongMachTu.DAO;

namespace PhongMachTu.BUS
{
    public class BUS_BenhNhan
    {
        DAO_BenhNhan dBenhNhan;
        public BUS_BenhNhan()
        {
            dBenhNhan = new DAO_BenhNhan();
        }

        public void HienThi(DataGridView dg)
        {
            dg.DataSource = dBenhNhan.LayDSThongTin();
        }

        public void HienThiTK(DataGridView dg, String name)
        {
            dg.DataSource = dBenhNhan.TimKiem(name);

        }

        public void LayDSBN(ComboBox cb)
        {
            cb.DataSource = dBenhNhan.LayDSTen();
            cb.DisplayMember = "Ten";
            cb.ValueMember = "id";
        }

        public BenhNhan LayThongTinBenhNhan(int ma)
        {
            return dBenhNhan.LayThongTinBenhNhan(ma);
        }

        public void LayDSThongTinBN(DataGridView dg, String ten)
        {
            dg.DataSource = dBenhNhan.LayDSThongTinBN(ten);
        }

        public bool themBN(BenhNhan benhNhan)
        {
            try
            {
                dBenhNhan.ThemBN(benhNhan);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public bool timBN(string name)
        {
            if (dBenhNhan.TimKiem(name).Count != 0)

                return true;
            return false;
        }
    }
}