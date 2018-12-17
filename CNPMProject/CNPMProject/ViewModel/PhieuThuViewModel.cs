using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPMProject.ViewModel
{
   public class PhieuThuViewModel
    {
        public List<PHIEUTHU> PHIEUTHUS { get; set;}
        public PhieuThuViewModel()
        {
            LoadPhieuThu();
        }

        private void LoadPhieuThu()
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                PHIEUTHUS = db.PHIEUTHUs.ToList();
            }
        }
    }
}
