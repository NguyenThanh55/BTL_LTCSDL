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
    public partial class fDangKi : Form
    {
        BUS_BenhNhan bBenhNhan;
        public fDangKi()
        {
            InitializeComponent();
            bBenhNhan = new BUS_BenhNhan();
        }
       
        private void btLogin_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Hide();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            BenhNhan benhNhan = new BenhNhan();
            benhNhan.Ten = txtTenBN.Text;
            benhNhan.NgaySinh = dpNgaySinh.Value;
            if (radNam.Checked == true)
                benhNhan.GioiTinh = true;
            else if (radNu.Checked == true)
                benhNhan.GioiTinh = false;
            benhNhan.DiaChi = txtDiaChi.Text;

            //Goi ham them o bus_Thuoc
            if (bBenhNhan.themBN(benhNhan))
            {
                MessageBox.Show("Dang ki thanh cong");
                txtTenBN.Text = "";
                dpNgaySinh.CustomFormat = " ";
                radNam.Checked = false;
                radNu.Checked = false;
                txtDiaChi.Text = "";
            }
            else
            {
                MessageBox.Show("Dang ki khong thanh cong");
            }

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            dpNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        private void fDangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
