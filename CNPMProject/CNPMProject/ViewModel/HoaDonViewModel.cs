using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPMProject.ViewModel
{
    public class HoaDonViewModel
    {
        public List<HOADON> HOADONS { get; set; }
        public HoaDonViewModel()
        {
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                HOADONS = db.HOADONs.ToList();
            }
        }
    }
}
