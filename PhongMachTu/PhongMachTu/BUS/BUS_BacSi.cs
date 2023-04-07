using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhongMachTu.DAO;

namespace PhongMachTu.BUS
{
    public class BUS_BacSi
    {
        DAO_BacSi dBacSi;
        public BUS_BacSi()
        {
            dBacSi = new DAO_BacSi();
        }

        public BacSi LayThongTinBacSi(int ma)
        {
            return dBacSi.LayThongTinBacSi(ma);
        }
    }
}
