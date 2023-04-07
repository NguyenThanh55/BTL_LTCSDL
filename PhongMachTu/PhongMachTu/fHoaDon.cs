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
    public partial class fHoaDon : Form
    {
        public int maHoaDon;
        BUS_HoaDon bHoaDon;
        BUS_PhieuKham bPhieuKham;
        BUS_BenhNhan bBenhNhan;
        BUS_BacSi bBacSi;

        public fHoaDon()
        {
            InitializeComponent();
            bHoaDon = new BUS_HoaDon();
            bPhieuKham = new BUS_PhieuKham();
            bBenhNhan = new BUS_BenhNhan();
            bBacSi = new BUS_BacSi();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            HoaDon hd = bHoaDon.HienThiThongTinHD(maHoaDon);
            PhieuKham pk = bPhieuKham.LayThongTinPhieuKham(hd.idPK);
            BenhNhan bn = bBenhNhan.LayThongTinBenhNhan(pk.idBN);
            BacSi bs = bBacSi.LayThongTinBacSi(pk.idBS);
            lbTen.Text = bn.Ten;
            lbNgayKham.Text = pk.NgayKham.ToString();
            lbTienKham.Text = hd.TienKham.ToString();
            lbTienDV.Text = hd.TienDV.ToString();   
            lbTienThuoc.Text = hd.TienThuoc.ToString();
            lbTongTien.Text = hd.TongTien.ToString();
            lbNgayThanhToan.Text = hd.NgayKham.ToString();
            lbTenBs.Text = bs.Ten;
            lbMaHD.Text = hd.id.ToString();
        }
    }
}
