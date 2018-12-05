using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class PhieuThu
    {
        public string MaPhieuThu { get; set; }
        public string MaHoaDon { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public double TienPhaiTra { get; set; }
        public double TienThu { get; set; }
        public double ConThieu { get; set; }
    }
}
