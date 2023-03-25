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

namespace PhongMachTu
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            //LoadAccountList();
        }



        //void LoadAccountList()
        //{
        //    String query = "exec USP_GetAccountByUserName @username";

        //    DataProvider dataProvider = new DataProvider();

        //    dtgvAccount.DataSource = dataProvider.ExecuteQuery(query, new object[]{"nurse"});
        //}
    }
}
