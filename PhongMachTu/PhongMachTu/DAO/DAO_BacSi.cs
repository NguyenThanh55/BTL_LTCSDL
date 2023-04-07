using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongMachTu.DAO
{
    public class DAO_BacSi
    {
        QLPMEntities db;
        public DAO_BacSi() {
            db = new QLPMEntities();
        }

        public BacSi LayThongTinBacSi(int ma)
        {
            BacSi bs = db.BacSis.Where(s => s.id == ma).FirstOrDefault();
            return bs;
        }

    }
}
