using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

       

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn hủy đăng ký không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK )
                {
                e.Cancel = true;
                }
            
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            fLogin1 f = new fLogin1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
