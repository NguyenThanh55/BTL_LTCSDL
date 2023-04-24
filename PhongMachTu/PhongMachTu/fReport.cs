using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PhongMachTu.BUS;
namespace PhongMachTu
{
    public partial class fReport : Form
    {
        BUS_ThongKe bThongKe;
        public fReport()
        {
            InitializeComponent();
            bThongKe = new BUS_ThongKe();
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            //Series series = new Series("Doanh thu bán thuốc theo tên thuốc");
            //series.ChartType = SeriesChartType.Pie;
            //var n1 = bThongKe.bieudoThuoc(0);
            //var n2 = bThongKe.bieudoThuoc(1);
            //chartThuoc.DataSource = bThongKe.bieudoThuoc();
            //chartThuoc.Series["ChartThuoc"].XValueMember = "Ten";
            //chartThuoc.Series["ChartThuoc"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            //chartThuoc.Series["ChartThuoc"].YValueMembers = "TongTien";
            //chartThuoc.Series["ChartThuoc"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            //this.reportViewer.RefreshReport();
        }
    }
}
