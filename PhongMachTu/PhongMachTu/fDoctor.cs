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
        public fDoctor()
        {
            InitializeComponent();
            bThuoc = new BUS_Thuoc();
            bBenhNhan =new BUS_BenhNhan();
        }

        private void fDoctor_Load(object sender, EventArgs e)
        {
            bBenhNhan.LayDSBN(cbbTenBN);
            bThuoc.LayDSThuoc(cbbThuoc);
        }
    }
}
