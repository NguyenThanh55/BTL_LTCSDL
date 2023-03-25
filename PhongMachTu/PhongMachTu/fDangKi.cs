using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongMachTu
{
    public partial class fDangKi : Form
    {
        public fDangKi()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Hide();
        }
    }
}
