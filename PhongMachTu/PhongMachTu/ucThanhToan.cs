using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhongMachTu.BUS;

namespace PhongMachTu
{
    public partial class ucThanhToan : UserControl
    {
        public int maHoaDon;
        BUS_HoaDon bHoaDon;
        BUS_PhieuKham bPhieuKham;
        BUS_BenhNhan bBenhNhan;
        
        public ucThanhToan()
        {
            InitializeComponent();
            bHoaDon = new BUS_HoaDon();
            bPhieuKham = new BUS_PhieuKham();
            bBenhNhan = new BUS_BenhNhan();
        }

        private void ucThanhToan_Load(object sender, EventArgs e)
        {
            HoaDon hd = bHoaDon.HienThiThongTinHD(maHoaDon);
            PhieuKham pk = bPhieuKham.LayThongTinPhieuKham(hd.idPK);
            BenhNhan bn = bBenhNhan.LayThongTinBenhNhan(pk.idBN);
            lbTen.Text = bn.Ten;

        }
    }
}
