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

        public BenhNhan LayThongTinBenhNhan(int ma)
        {
            return dBenhNhan.LayThongTinBenhNhan(ma);
        }

        public void LayDSBN(ComboBox cb)
        {
            cb.DataSource = dBenhNhan.LayDSTen();
            cb.DisplayMember = "Ten";
            cb.ValueMember = "id";
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
    }
}
