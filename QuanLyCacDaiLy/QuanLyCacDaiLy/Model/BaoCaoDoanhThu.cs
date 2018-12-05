using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class BaoCaoDoanhThu
    {
        public string MaDoanhThu { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime DenNgay { get; set; }
        public string MaDaiLy { get; set; }
        public string MaDinhMuc { get; set; }
        public string MaMatHang { get; set; }
        public int SoLuong { get; set; }
        public double TongDoanhThu { get; set; }
    }
}
