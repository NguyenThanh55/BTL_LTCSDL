using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhongMachTu.BUS;
using System.Windows.Forms;

namespace PhongMachTu
{
    public partial class fLichSuBenhNhan : Form
    {
        public int maBenhNhan;
        BUS_HoaDon bHoaDon;
        BUS_PhieuKham bPhieuKham;
        BUS_BenhNhan bBenhNhan;
        BUS_DichVu bDichVu;
        BUS_Thuoc bThuoc;

        public fLichSuBenhNhan()
        {
            InitializeComponent();
            bHoaDon = new BUS_HoaDon();
            bPhieuKham = new BUS_PhieuKham();
            bBenhNhan = new BUS_BenhNhan();
            bDichVu = new BUS_DichVu();
            bThuoc = new BUS_Thuoc();
        }

        private void fLichSuBenhNhan_Load(object sender, EventArgs e)
        {
            txtMaBN.Text = maBenhNhan.ToString();
            BenhNhan bn = bBenhNhan.LayThongTinBenhNhan(maBenhNhan);
            PhieuKham pk = bPhieuKham.LayThongTinPhieuKham(bn.id);
            HoaDon hd = bHoaDon.HienThiThongTinHD(pk.id);
            DichVu dv = bDichVu.LayThongTinDichVu(hd.id);
            txtTenBN.Text = bn.Ten;
            txtNgayKham.Text = pk.NgayKham.ToString();
            txtTrieuChung.Text = pk.TrieuChung;
            txtDuDoan.Text = pk.ChuanDoanBenh;
            bDichVu.hienThi(dgDichVu);
            bThuoc.HienThi(dgThuoc);
        }
    }
}