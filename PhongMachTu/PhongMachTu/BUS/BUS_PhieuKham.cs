using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhongMachTu.DAO;

namespace PhongMachTu.BUS
{
    public class BUS_PhieuKham
    {
        DAO_PhieuKham dPhieuKham;
        public BUS_PhieuKham()
        {
            dPhieuKham = new DAO_PhieuKham();
        }

        public PhieuKham LayThongTinPhieuKham(int ma)
        {
            return dPhieuKham.LayThongTinPhieuKham(ma);
        }
        public void LayNgayKham(ComboBox cb)
        {
            cb.DataSource = dPhieuKham.LayNgayKham();
            cb.DisplayMember = "ngayKham";
            cb.ValueMember = "idBN";
        }


        public bool taoPK(PhieuKham pk)
        {
            try
            {
                dPhieuKham.TaoPK(pk);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
    }
}
