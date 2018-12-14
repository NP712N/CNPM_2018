using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

namespace CNPMProject.ViewModel
{
    public class HangHoaViewModel
    {
        public List<HANGHOA> HANGHOAS { get; set; }
        public HangHoaViewModel()
        {
            LoadHangHoa();
        }

        public void LoadHangHoa()
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                HANGHOAS = db.HANGHOAs.ToList();
            }
        }
    }
}
