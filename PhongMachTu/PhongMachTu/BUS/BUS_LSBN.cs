using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhongMachTu.DAO;


namespace PhongMachTu.BUS
{
    internal class BUS_LSBN
    {
        DAO_LSBN dLSBN;
        public BUS_LSBN()
        {
            dLSBN = new DAO_LSBN();
        }

        public void HienThiDSBN(DataGridView dg)
        {
            dg.DataSource = dLSBN.HienThiDSBN();

        }
    }

}