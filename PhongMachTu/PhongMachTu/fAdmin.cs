using PhongMachTu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhongMachTu.BUS;

namespace PhongMachTu
{
    public partial class fAdmin : Form
    {
        BUS_Account bAccount;
        BUS_BenhNhan bBenhNhan;
        BUS_Thuoc bThuoc;
        public fAdmin()
        {
            InitializeComponent();
            bAccount = new BUS_Account();
            bBenhNhan = new BUS_BenhNhan();
            bThuoc = new BUS_Thuoc();
            //LoadAccountList();
        }

        private void HienThiDSAccount()
        {
            dgTaiKhoan.DataSource = null;
            bAccount.HienThi(dgTaiKhoan);
            dgTaiKhoan.Columns[0].Width = (int)(dgTaiKhoan.Width * 0.22);
            dgTaiKhoan.Columns[1].Width = (int)(dgTaiKhoan.Width * 0.22);
            dgTaiKhoan.Columns[2].Width = (int)(dgTaiKhoan.Width * 0.22);
            dgTaiKhoan.Columns[3].Width = (int)(dgTaiKhoan.Width * 0.22);
        }

        private void HienThiDSBenhNhan()
        {
            dgBenhNhan.DataSource = null;
            bBenhNhan.HienThi(dgBenhNhan);
            dgBenhNhan.Columns[0].Width = (int)(dgBenhNhan.Width * 0.1);
            dgBenhNhan.Columns[1].Width = (int)(dgBenhNhan.Width * 0.2);
            dgBenhNhan.Columns[2].Width = (int)(dgBenhNhan.Width * 0.2);
            dgBenhNhan.Columns[3].Width = (int)(dgBenhNhan.Width * 0.2);
            dgBenhNhan.Columns[4].Width = (int)(dgBenhNhan.Width * 0.2);
        }

        private void HienThiDSThuoc()
        {
            dgThuoc.DataSource = null;
            bThuoc.HienThi(dgThuoc);
            dgThuoc.Columns[0].Width = (int)(dgThuoc.Width * 0.1);
            dgThuoc.Columns[1].Width = (int)(dgThuoc.Width * 0.2);
            dgThuoc.Columns[2].Width = (int)(dgThuoc.Width * 0.15);
            dgThuoc.Columns[3].Width = (int)(dgThuoc.Width * 0.2);
            dgThuoc.Columns[4].Width = (int)(dgThuoc.Width * 0.15);
            dgThuoc.Columns[5].Width = (int)(dgThuoc.Width * 0.2);
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            //Page Account
            HienThiDSAccount();
            bAccount.HienThiType(cbbType);

            //Page BenhNhan
            HienThiDSBenhNhan();
            bBenhNhan.LayDSBN(cbbBN);

            //Page Thuoc
            HienThiDSThuoc();
        }

        //Thuoc
        private void dgThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgThuoc.Rows.Count)
            {
                txtId.Enabled = false;
                txtId.Text = dgThuoc.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtTenThuoc.Text = dgThuoc.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                txtDonVi.Text = dgThuoc.Rows[e.RowIndex].Cells["DonVi"].Value.ToString();
                txtSoLuong.Text = dgThuoc.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                txtCongDung.Text = dgThuoc.Rows[e.RowIndex].Cells["CongDung"].Value.ToString();
                txtNhaSX.Text = dgThuoc.Rows[e.RowIndex].Cells["NhaSX"].Value.ToString();
            }
        }

        private void btThemThuoc_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            Thuoc thuoc = new Thuoc();
            thuoc.Ten = txtTenThuoc.Text;
            thuoc.DonVi = txtDonVi.Text;
            thuoc.CongDung = txtCongDung.Text;
            thuoc.SoLuong = Int32.Parse(txtSoLuong.Text);
            thuoc.NhaSX = txtNhaSX.Text;
            
            //Goi ham them o bus_Thuoc
            if (bThuoc.themThuoc(thuoc))
            {
                MessageBox.Show("Them thanh cong");
                bThuoc.HienThi(dgThuoc);
                txtId.Text = "";
                txtTenThuoc.Text = "";
                txtDonVi.Text = "";
                txtCongDung.Text = "";
                txtSoLuong.Text = "";
                txtNhaSX.Text = "";
            }
            else
            {
                MessageBox.Show("Them khong thanh cong");
            }

        }

        private void btTimThuoc_Click(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc();
            thuoc.id = Int32.Parse(txtId.Text);
            thuoc.Ten = txtTenThuoc.Text;
            thuoc.DonVi = txtDonVi.Text;
            thuoc.CongDung = txtCongDung.Text;
            thuoc.SoLuong = Int32.Parse(txtSoLuong.Text);
            thuoc.NhaSX = txtNhaSX.Text;

            //Goi sua thuoc o bus_Thuoc
            if (bThuoc.suaThuoc(thuoc))
            {
                MessageBox.Show("Sua thanh cong");
                bThuoc.HienThi(dgThuoc);
                txtId.Text = "";
                txtTenThuoc.Text = "";
                txtDonVi.Text = "";
                txtCongDung.Text = "";
                txtSoLuong.Text = "";
                txtNhaSX.Text = "";
            }
            else
            {
                MessageBox.Show("Sua khong thanh cong");
            }
        }

        private void btXoaThuoc_Click(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc();
            thuoc.id = int.Parse(txtId.Text);

            //Goi xoa thuoc o bus_Thuoc
            if (bThuoc.xoaThuoc(thuoc))
            {
                MessageBox.Show("Xoa thanh cong");
                bThuoc.HienThi(dgThuoc);
                txtId.Text = "";
                txtTenThuoc.Text = "";
                txtDonVi.Text = "";
                txtCongDung.Text = "";
                txtSoLuong.Text = "";
                txtNhaSX.Text = "";
            }
            else
            {
                MessageBox.Show("Xoa khong thanh cong");
            }
        }
    }
}
