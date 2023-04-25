//using PhongMachTu.DAO;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using PhongMachTu.BUS;

//namespace PhongMachTu
//{
//    public partial class fAdmin : Form
//    {
//        BUS_Account bAccount;
//        BUS_BenhNhan bBenhNhan;
//        BUS_Thuoc bThuoc;
//        public fAdmin()
//        {
//            InitializeComponent();
//            bAccount = new BUS_Account();
//            bBenhNhan = new BUS_BenhNhan();
//            bThuoc = new BUS_Thuoc();
//            //LoadAccountList();
//        }

//        private void HienThiDSAccount()
//        {
//            dgTaiKhoan.DataSource = null;
//            bAccount.HienThi(dgTaiKhoan);
//            dgTaiKhoan.Columns[0].Width = (int)(dgTaiKhoan.Width * 0.22);
//            dgTaiKhoan.Columns[1].Width = (int)(dgTaiKhoan.Width * 0.22);
//            dgTaiKhoan.Columns[2].Width = (int)(dgTaiKhoan.Width * 0.22);
//            dgTaiKhoan.Columns[3].Width = (int)(dgTaiKhoan.Width * 0.22);
//        }

//        private void HienThiDSBenhNhan()
//        {
//            dgBenhNhan.DataSource = null;
//            bBenhNhan.HienThi(dgBenhNhan);
//            dgBenhNhan.Columns[0].Width = (int)(dgBenhNhan.Width * 0.1);
//            dgBenhNhan.Columns[1].Width = (int)(dgBenhNhan.Width * 0.2);
//            dgBenhNhan.Columns[2].Width = (int)(dgBenhNhan.Width * 0.2);
//            dgBenhNhan.Columns[3].Width = (int)(dgBenhNhan.Width * 0.2);
//            dgBenhNhan.Columns[4].Width = (int)(dgBenhNhan.Width * 0.2);
//        }

//        private void HienThiDSThuoc()
//        {
//            dgThuoc.DataSource = null;
//            bThuoc.HienThi(dgThuoc);
//            dgThuoc.Columns[0].Width = (int)(dgThuoc.Width * 0.05);
//            dgThuoc.Columns[1].Width = (int)(dgThuoc.Width * 0.15);
//            dgThuoc.Columns[2].Width = (int)(dgThuoc.Width * 0.1);
//            dgThuoc.Columns[3].Width = (int)(dgThuoc.Width * 0.2);
//            dgThuoc.Columns[4].Width = (int)(dgThuoc.Width * 0.1);
//            dgThuoc.Columns[5].Width = (int)(dgThuoc.Width * 0.2);
//            dgThuoc.Columns[6].Width = (int)(dgThuoc.Width * 0.2);
//            //DataGridViewButtonColumn buttonColumn =
//            //new DataGridViewButtonColumn();
//            //buttonColumn.HeaderText = "";
//            //buttonColumn.Name = "Status Request";
//            //buttonColumn.Text = "Request Status";
//            //buttonColumn.UseColumnTextForButtonValue = true;
//            //dgThuoc.Columns.Add(buttonColumn);
//            //dgThuoc.Columns[6].Width = (int)(dgThuoc.Width * 0.2);
//        }

//        private void fAdmin_Load(object sender, EventArgs e)
//        {
//            //Page Account
//            HienThiDSAccount();
//            bAccount.HienThiType(cbbType);

//            //Page BenhNhan
//            HienThiDSBenhNhan();
//            bBenhNhan.LayDSBN(cbbBN);

//            //Page Thuoc
//            HienThiDSThuoc();
//        }

//        //Thuoc
//        private void dgThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0 && e.RowIndex < dgThuoc.Rows.Count)
//            {
//                txtId.Enabled = false;
//                txtId.Text = dgThuoc.Rows[e.RowIndex].Cells["id"].Value.ToString();
//                txtTenThuoc.Text = dgThuoc.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
//                txtDonVi.Text = dgThuoc.Rows[e.RowIndex].Cells["DonVi"].Value.ToString();
//                txtSoLuong.Text = dgThuoc.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
//                txtCongDung.Text = dgThuoc.Rows[e.RowIndex].Cells["CongDung"].Value.ToString();
//                txtNhaSX.Text = dgThuoc.Rows[e.RowIndex].Cells["NhaSX"].Value.ToString();
//            }
//        }

//        private void btThemThuoc_Click(object sender, EventArgs e)
//        {
//            txtId.Enabled = false;
//            Thuoc thuoc = new Thuoc();
//            thuoc.Ten = txtTenThuoc.Text;
//            thuoc.DonVi = txtDonVi.Text;
//            thuoc.CongDung = txtCongDung.Text;
//            thuoc.SoLuong = Int32.Parse(txtSoLuong.Text);
//            thuoc.NhaSX = txtNhaSX.Text;

//            //Goi ham them o bus_Thuoc
//            if (bThuoc.themThuoc(thuoc))
//            {
//                MessageBox.Show("Them thanh cong");
//                bThuoc.HienThi(dgThuoc);
//                txtId.Text = "";
//                txtTenThuoc.Text = "";
//                txtDonVi.Text = "";
//                txtCongDung.Text = "";
//                txtSoLuong.Text = "";
//                txtNhaSX.Text = "";
//            }
//            else
//            {
//                MessageBox.Show("Them khong thanh cong");
//            }

//        }

//        private void btTimThuoc_Click(object sender, EventArgs e)
//        {
//            Thuoc thuoc = new Thuoc();
//            thuoc.id = Int32.Parse(txtId.Text);
//            thuoc.Ten = txtTenThuoc.Text;
//            thuoc.DonVi = txtDonVi.Text;
//            thuoc.CongDung = txtCongDung.Text;
//            thuoc.SoLuong = Int32.Parse(txtSoLuong.Text);
//            thuoc.NhaSX = txtNhaSX.Text;

//            //Goi sua thuoc o bus_Thuoc
//            if (bThuoc.suaThuoc(thuoc))
//            {
//                MessageBox.Show("Sua thanh cong");
//                bThuoc.HienThi(dgThuoc);
//                txtId.Text = "";
//                txtTenThuoc.Text = "";
//                txtDonVi.Text = "";
//                txtCongDung.Text = "";
//                txtSoLuong.Text = "";
//                txtNhaSX.Text = "";
//            }
//            else
//            {
//                MessageBox.Show("Sua khong thanh cong");
//            }
//        }

//        private void btXoaThuoc_Click(object sender, EventArgs e)
//        {
//            Thuoc thuoc = new Thuoc();
//            thuoc.id = int.Parse(txtId.Text);

//            //Goi xoa thuoc o bus_Thuoc
//            if (bThuoc.xoaThuoc(thuoc))
//            {
//                MessageBox.Show("Xoa thanh cong");
//                bThuoc.HienThi(dgThuoc);
//                txtId.Text = "";
//                txtTenThuoc.Text = "";
//                txtDonVi.Text = "";
//                txtCongDung.Text = "";
//                txtSoLuong.Text = "";
//                txtNhaSX.Text = "";
//            }
//            else
//            {
//                MessageBox.Show("Xoa khong thanh cong");
//            }
//        }
//    }
//}

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
using System.Globalization;

namespace PhongMachTu
{
    public partial class fAdmin : Form
    {
        BUS_Account bAccount;
        BUS_BenhNhan bBenhNhan;
        BUS_Thuoc bThuoc;
        BUS_BacSi bBacSi;
        BUS_PhieuKham bPhieuKham;
        BUS_ThongKe bThongKe;
        public fAdmin()
        {
            InitializeComponent();
            bAccount = new BUS_Account();
            bBenhNhan = new BUS_BenhNhan();
            bThuoc = new BUS_Thuoc();
            bBacSi = new BUS_BacSi();
            bPhieuKham = new BUS_PhieuKham();
            bThongKe = new BUS_ThongKe();
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
            bBacSi.HienThiTenBS(cbbTenBS);

            //Page BenhNhan
            HienThiDSBenhNhan();
            bBenhNhan.LayDSBN(cbbBN);
            //bPhieuKham.LayNgayKham(cbbNgayKham);

            //Page Thuoc
            HienThiDSThuoc();

            //Page thong ke
            foreach (var i in bThongKe.bieudoThuoc())
            {
                chartCot.Series["ChartCot"].Points.AddXY(i.Ten, (i.Gia * i.LieuLuong));
            }

            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 1", bThongKe.bieudoBN(1));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 2", bThongKe.bieudoBN(2));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 3", bThongKe.bieudoBN(3));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 4", bThongKe.bieudoBN(4));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 5", bThongKe.bieudoBN(5));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 6", bThongKe.bieudoBN(6));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 7", bThongKe.bieudoBN(7));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 8", bThongKe.bieudoBN(8));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 9", bThongKe.bieudoBN(9));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 10", bThongKe.bieudoBN(10));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 11", bThongKe.bieudoBN(11));
            ChartLine.Series["Số bệnh nhân"].Points.AddXY("Tháng 12", bThongKe.bieudoBN(12));
        }

        //Page Account
        private void dgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgTaiKhoan.Rows.Count)
            {
                txtConfirmPass.Enabled = false;
                cbbTenBS.Text = dgTaiKhoan.Rows[e.RowIndex].Cells["id"].Value.ToString();
                cbbType.Text = dgTaiKhoan.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                txtUsername.Text = dgTaiKhoan.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtPassword.Text = dgTaiKhoan.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            }

        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.id = Int32.Parse(cbbTenBS.SelectedValue.ToString());
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.Type = int.Parse(cbbType.SelectedValue.ToString());
            if (String.Compare(txtPassword.Text, txtConfirmPass.Text, false) == 0)
            {

                account.Password = txtConfirmPass.Text;

                if (bAccount.TaoTaiKhoan(account))
                {
                    MessageBox.Show("Them tai khoan thanh cong");
                    bAccount.HienThi(dgTaiKhoan);
                    cbbTenBS.Text = "";
                    cbbType.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPass.Text = "";
                }
                else
                {
                    MessageBox.Show("Them tai khoan khong thanh cong");
                }
             }
            else
            {
                MessageBox.Show("Nhap sai Password");
            }
        }

        private void btSuaTK_Click(object sender, EventArgs e)
        {
            //txtConfirmPass.Enabled = false;
            Account account = new Account();
            account.id = int.Parse(cbbTenBS.SelectedValue.ToString());
            account.Type = int.Parse(cbbType.SelectedValue.ToString());
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;

            if (bAccount.SuaTK(account))
            {
                MessageBox.Show("Sua tai khoan thanh cong");
                bAccount.HienThi(dgTaiKhoan);
                cbbTenBS.Text = "";
                cbbType.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";

            }
            else
            {
                MessageBox.Show("Sua tai khoan khong thanh cong");
            }
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.id = int.Parse(cbbTenBS.SelectedValue.ToString());

            if (bAccount.XoaTK(account))
            {
                MessageBox.Show("Xoa tai khoan thanh cong");
                bAccount.HienThi(dgTaiKhoan);
                cbbTenBS.Text = "";
                cbbType.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPass.Text = "";
            }
            else
            {
                MessageBox.Show("Xoa khong thanh cong");
            }
        }

        private void btXemTK_Click(object sender, EventArgs e)
        {
            HienThiDSAccount();
        }

        //Page Thuoc
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

        private void btXemThuoc_Click(object sender, EventArgs e)
        {
            HienThiDSThuoc();
        }

        //Page Benh Nhan
        private void btTimBN_Click(object sender, EventArgs e)
        {

            string name = cbbBN.Text;
            if (bBenhNhan.timBN(name))
            {
                MessageBox.Show("Tìm thành công");
                bBenhNhan.HienThiTK(dgBenhNhan, name);
            }
            else
            {
                MessageBox.Show("Tìm thất bại");
            }
        }

        private void btXemBN_Click(object sender, EventArgs e)
        {
            HienThiDSBenhNhan();
        }

        //Chuyen tab trang Admin
        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabAdmin.SelectedIndex == 3)
            {
                //fReport f = new fReport();
                //this.Hide();
                //f.ShowDialog();
                //this.Show();
                fAdmin f = new fAdmin();
                

            }
        }

        private void btnTimTK_Click(object sender, EventArgs e)
        {
           
        }
    }
}
