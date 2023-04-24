using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhongMachTu.DAO;

namespace PhongMachTu.BUS
{
    public class BUS_ThongKe
    {
        DAO_ThongKe dThongKe;
        public BUS_ThongKe()
        {
            dThongKe = new DAO_ThongKe();
        }

        public dynamic bieudoThuoc()
        {
            return dThongKe.DoanhThuThuoc();
        }

        public dynamic bieudoBN(int soThang)
        {
            return dThongKe.SoBN(soThang);
        }

    }
}
