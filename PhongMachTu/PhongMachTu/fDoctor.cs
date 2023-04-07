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
    public partial class fDoctor : Form
    {
        BUS_Thuoc bThuoc;
        BUS_BenhNhan bBenhNhan;
        BUS_DichVu bDichVu;
        BUS_PhieuKham bPhieuKham;
        BUS_HoaDon bHoaDon;
        bool co = false;
        DataTable dtDichVu, dtThuoc;
        public int maAccount, ma, maHD ,maDV, gia;

        public fDoctor()
        {
            InitializeComponent();
            bThuoc = new BUS_Thuoc();
            bBenhNhan =new BUS_BenhNhan();
            bDichVu = new BUS_DichVu();
            bPhieuKham = new BUS_PhieuKham();
            bHoaDon = new BUS_HoaDon();
        }

        private void fDoctor_Load(object sender, EventArgs e)
        {
            lbMaBS.Text = maAccount.ToString();
            bBenhNhan.LayDSBN(cbbTenBN);
            bThuoc.LayDSThuoc(cbbThuoc);
            bDichVu.LayDSDV(cbbDichVu);
            txtTienDV.Text = "0";
            txtTienThuoc.Text = "0";
            lbTienKham.Text = "100000";
            txtTongTien.Text = "100000";

            co = true;

            dtDichVu = new DataTable();
            dtDichVu.Columns.Add("id");
            dtDichVu.Columns.Add("idHD");
            dtDichVu.Columns.Add("idDV");
            dtDichVu.Columns.Add("Gia");
            dgDichVu.DataSource = dtDichVu;

            dtThuoc = new DataTable();
            dtThuoc.Columns.Add("id");
            dtThuoc.Columns.Add("LieuLuong");
            dtThuoc.Columns.Add("Gia");
            dtThuoc.Columns.Add("CachDung");
            dtThuoc.Columns.Add("idThuoc");
            dtThuoc.Columns.Add("idHD");
            dgThuoc.DataSource = dtThuoc;

            bHoaDon.HienThiHDChuaThanhToan(dgHDChuaThanhToan);
            bHoaDon.HienThiHDDaThanhToan(dgHDDaThanhToan);
        }

        private void btTaoPK_Click(object sender, EventArgs e)
        {
            PhieuKham pk = new PhieuKham();
            pk.idBS = Int32.Parse(lbMaBS.Text);
            pk.idBN = Int32.Parse(cbbThuoc.SelectedValue.ToString());
            pk.NgayKham =  dpNgayKham.Value.Date;
            pk.TrieuChung = txtTrieuChung.Text;
            pk.ChuanDoanBenh = txtDuDoan.Text;

            txtTienDV.Enabled = false;
            txtTienThuoc.Enabled = false;
            txtTongTien.Enabled = false;
            if (bPhieuKham.taoPK(pk) == true)
            {
                MessageBox.Show("Tạo thành công");
                lbMaPK.Text = pk.id.ToString();
                gbDichVu.Enabled = true;
                gbKeThuoc.Enabled = true;
                gbTongTien.Enabled = true;
                HoaDon hd = new HoaDon();
                hd.NgayKham = pk.NgayKham;
                hd.TienKham = 0;
                hd.TienDV = 0;
                hd.TienThuoc = 0;
                hd.TongTien = 0;
                hd.idPK = pk.id;
                if (bHoaDon.ThemHD(hd))
                {
                    lbMaHD.Text = hd.id.ToString();
                }
                else
                    MessageBox.Show("Tạo hóa đơn không thành công");
            }
            else
                MessageBox.Show("Tạo không thành công");
        }

        private void btTaoHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.id = Int32.Parse(lbMaHD.Text);
            hd.NgayKham = dpNgayKham.Value.Date;
            hd.TienKham = Int32.Parse(lbTienKham.Text);
            hd.TienDV = Int32.Parse(txtTienDV.Text);
            hd.TienThuoc = Int32.Parse(txtTienThuoc.Text);
            hd.TongTien = Int32.Parse(txtTongTien.Text);
            hd.idPK = Int32.Parse(lbMaPK.Text);

            if (bHoaDon.CapNhatHD(hd))
            {
                MessageBox.Show("Tạo hóa đơn thành công");
                txtTrieuChung.Text = "";
                txtDuDoan.Text = "";
                lbMaHD.Text = "";
                lbTienKham.Text = "";
                txtTienDV.Text = "0";
                txtTienThuoc.Text = "0";
                txtTongTien.Text = "100000";
                gbDichVu.Enabled = false;
                gbKeThuoc.Enabled = false;
                txtCachDung.Text = "";
                numLieuLuong.Value = 0;
                txtGia.Text = "";
                gbTongTien.Enabled = false;

                dtDichVu = new DataTable();
                dtDichVu.Columns.Add("id");
                dtDichVu.Columns.Add("idHD");
                dtDichVu.Columns.Add("idDV");
                dtDichVu.Columns.Add("Gia");
                dgDichVu.DataSource = dtDichVu;

                dtThuoc = new DataTable();
                dtThuoc.Columns.Add("id");
                dtThuoc.Columns.Add("LieuLuong");
                dtThuoc.Columns.Add("Gia");
                dtThuoc.Columns.Add("CachDung");
                dtThuoc.Columns.Add("idThuoc");
                dtThuoc.Columns.Add("idHD");
                dgThuoc.DataSource = dtThuoc;

                lbMaPK.Text = "";
                lbMaHD.Text = "";
            }
            else
                MessageBox.Show("Tạo hóa đơn không thành công");
        }

        private void dgHDChuaThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int maHD = Int32.Parse(dgHDChuaThanhToan.Rows[e.RowIndex].Cells["id"].Value.ToString());
                HoaDon hd = bHoaDon.HienThiThongTinHD(maHD);
                //MessageBox.Show((hd.id).ToString() + (hd.TienKham).ToString());
                if (hd != null)
                {
                    HoaDon h = new HoaDon();
                    h.id = hd.id;
                    h.NgayKham = hd.NgayKham;
                    h.TienKham = hd.TienKham;
                    h.TienDV = hd.TienDV;
                    h.TienThuoc = hd.TienThuoc;
                    h.TongTien = hd.TongTien;
                    h.idPK = hd.idPK;
                    h.TrangThai = true;
                    if (bHoaDon.CapNhatHD(h))
                    {
                        fHoaDon f = new fHoaDon();
                        f.maHoaDon = h.id;
                        f.ShowDialog();
                        bHoaDon.HienThiHDChuaThanhToan(dgHDChuaThanhToan);
                        bHoaDon.HienThiHDDaThanhToan(dgHDDaThanhToan);
                    }
                    else
                        MessageBox.Show("Cap nhat k thanh cong");
                }
                else
                    MessageBox.Show("Khong co hoa don");
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập tên bệnh nhân cần tìm ...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Nhập tên bệnh nhân cần tìm ...";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void tpLPK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tpLPK.SelectedIndex == 0)
            {
                gbDichVu.Enabled = false;
                gbKeThuoc.Enabled = false;
                gbTongTien.Enabled = false;
            }   
            else if (tpLPK.SelectedIndex == 1)
            {
                bHoaDon.HienThiHDChuaThanhToan(dgHDChuaThanhToan);
                bHoaDon.HienThiHDDaThanhToan(dgHDDaThanhToan);
            }
            else if (tpLPK.SelectedIndex == 2)
            {
                 if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                        fAdmin.Exit();
            } 
                
        }

        private void btThemDV_Click(object sender, EventArgs e)
        {
            DataRow r;
            bool ktDichVu = true;
            foreach (DataRow item in dtDichVu.Rows)
            {
                if (cbbDichVu.SelectedValue.ToString() == item[2].ToString())
                {
                    MessageBox.Show("Dịch vụ đã chọn");
                    ktDichVu = false;
                    break;
                }
            }
            
            if (ktDichVu)
            {
                CTDV dichvu = new CTDV();
                dichvu.idHD = Int32.Parse(lbMaHD.Text);
                dichvu.idDV = Int32.Parse(cbbDichVu.SelectedValue.ToString());
                dichvu.Gia = bDichVu.LayThongTinDichVu(Int32.Parse(cbbDichVu.SelectedValue.ToString())).giaDV;
                if (bDichVu.ThemCTDV(dichvu))
                {
                    //MessageBox.Show("Thêm dịch vụ thành công");
                    //Them 1 dong dl vao bang dich vu
                    r = dtDichVu.NewRow();
                    r[0] = dichvu.id;
                    r[1] = dichvu.idHD;
                    r[2] = dichvu.idDV;
                    r[3] = dichvu.Gia;
                    dtDichVu.Rows.Add(r);
                    dgDichVu.DataSource = dtDichVu;
                    txtTienDV.Text = (Int32.Parse(txtTienDV.Text) + Int32.Parse(dichvu.Gia.ToString())).ToString();
                    txtTongTien.Text = (Int32.Parse(txtTongTien.Text) + Int32.Parse(dichvu.Gia.ToString())).ToString();
                }
                else
                    MessageBox.Show("Thêm dịch vụ không thành công");
            }

        }

        private void btXoaDV_Click(object sender, EventArgs e)
        {
            if (this.dgDichVu.SelectedRows.Count > 0)
            {
                int index = dgDichVu.CurrentCell.RowIndex;
                int ma = Int32.Parse(dgDichVu.Rows[index].Cells[0].Value.ToString());
                //Goi xoa thuoc o bus_Dich vu
                if (bDichVu.xoaDV(ma))
                {
                    //MessageBox.Show("Xoa thanh cong");
                    txtTienDV.Text = (Int32.Parse(txtTienDV.Text) - Int32.Parse(dgDichVu.Rows[index].Cells[3].Value.ToString())).ToString();
                    txtTongTien.Text = (Int32.Parse(txtTongTien.Text) - Int32.Parse(dgDichVu.Rows[index].Cells[3].Value.ToString())).ToString();
                    dgDichVu.Rows.RemoveAt(this.dgDichVu.SelectedRows[0].Index);
                    //bDichVu.hienThi(dgDichVu);
                    //dgDichVu.DataSource = dtDichVu;
                }
                else
                {
                    MessageBox.Show("Xoa khong thanh cong");
                }
               
            }
        }

        private void btThemThuoc_Click(object sender, EventArgs e)
        {
            DataRow r;
            bool ktThuoc = true;
            ChiTietTT thuoc = new ChiTietTT();
            foreach (DataRow item in dtThuoc.Rows)
            {
                if (cbbThuoc.SelectedValue.ToString() == item[4].ToString())
                {
                    item[1] = Int32.Parse(item[1].ToString()) + numLieuLuong.Value;
                    MessageBox.Show("Thuốc đã được thêm trước đó!!!", "Thông báo");
                    txtTongTien.Text = (Int32.Parse(txtTongTien.Text) + (Int32.Parse(thuoc.Gia.ToString()) * Int32.Parse(thuoc.LieuLuong.ToString()))).ToString();
                    ktThuoc = false;
                    break;
                }
            }

            if (ktThuoc)
            {
                thuoc.LieuLuong = Int32.Parse(numLieuLuong.Value.ToString());
                thuoc.Gia = Int32.Parse(txtGia.Text);
                thuoc.CachDung = txtCachDung.Text;
                thuoc.idThuoc = Int32.Parse(cbbThuoc.SelectedValue.ToString());
                thuoc.idHD = Int32.Parse(lbMaHD.Text);
                if (bThuoc.ThemCTTT(thuoc))
                {
                    //MessageBox.Show("Thêm thuốc thành công");
                    //Them 1 dong dl vao bang thuoc
                    r = dtThuoc.NewRow();
                    r[0] = thuoc.id;
                    r[1] = numLieuLuong.Value;
                    r[2] = txtGia.Text;
                    r[3] = txtCachDung.Text;
                    r[4] = Int32.Parse(cbbThuoc.SelectedValue.ToString());
                    r[5] = Int32.Parse(lbMaHD.Text);
                    dtThuoc.Rows.Add(r);
                    dgThuoc.DataSource = dtThuoc;
                    txtTienThuoc.Text = (Int32.Parse(txtTienThuoc.Text) + (Int32.Parse(thuoc.Gia.ToString()) * Int32.Parse(thuoc.LieuLuong.ToString()))).ToString();
                    txtTongTien.Text = (Int32.Parse(txtTongTien.Text) + (Int32.Parse(thuoc.Gia.ToString()) * Int32.Parse(thuoc.LieuLuong.ToString()))).ToString();
                }
                else
                    MessageBox.Show("Thêm thuốc không thành công");
            }
        }

        private void btXoaThuoc_Click(object sender, EventArgs e)
        {
            if (this.dgThuoc.SelectedRows.Count > 0)
            {
                int index = dgThuoc.CurrentCell.RowIndex;
                int ma = Int32.Parse(dgThuoc.Rows[index].Cells[0].Value.ToString());
                //Goi xoa thuoc o bus_Thuoc
                if (bThuoc.xoaCTTT(ma))
                {
                    MessageBox.Show("Xoa thanh cong");
                    txtTienThuoc.Text = (Int32.Parse(txtTienThuoc.Text) - (Int32.Parse(dgThuoc.Rows[index].Cells[2].Value.ToString()) * Int32.Parse(dgThuoc.Rows[index].Cells[1].Value.ToString()))).ToString();
                    txtTongTien.Text = (Int32.Parse(txtTongTien.Text) - (Int32.Parse(dgThuoc.Rows[index].Cells[2].Value.ToString()) * Int32.Parse(dgThuoc.Rows[index].Cells[1].Value.ToString()))).ToString();
                    dgThuoc.Rows.RemoveAt(this.dgThuoc.SelectedRows[0].Index);
                    //bDichVu.hienThi(dgDichVu);
                    //dgDichVu.DataSource = dtDichVu;
                }
                else
                {
                    MessageBox.Show("Xoa khong thanh cong");
                }

            }
        }


        private void cbbThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thuoc t;
            int maThuoc;
            if (co)
            {
                maThuoc = Int32.Parse(cbbThuoc.SelectedValue.ToString());
                t = bThuoc.LayThongTinThuoc(maThuoc);
                txtGia.Text = t.TienThuoc.ToString();
            }
        }
    }
}
