using PhongMachTu.DAO;
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
    public partial class fLogin : Form
    {
        BUS_Account bAccount;
        public fLogin()
        {
            InitializeComponent();
            bAccount = new BUS_Account();
        }

        bool Login(string username, string password)
        {
            txtDangNhap.Text = "";
            txtMatKhau.Text = "";
            return bAccount.DangNhap(username, password);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            int maAccount;
            string username = txtDangNhap.Text;
            string password = txtMatKhau.Text;
            string loaiNV = cbbLoaiNhanVien.Text;
            if (Login(username, password))
            {
                if (loaiNV == "1")
                {
                    fAdmin f = new fAdmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (loaiNV == "2")
                {
                    maAccount = bAccount.LayID(username);
                    fDoctor f = new fDoctor();
                    f.maAccount = maAccount;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            cbbLoaiNhanVien.Items.Add("1");
            cbbLoaiNhanVien.Items.Add("2");
        }
    }
}
