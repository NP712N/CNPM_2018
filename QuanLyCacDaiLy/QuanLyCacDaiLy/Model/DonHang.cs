using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class DonHang
    {
        public string MaDonHang { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string MatHang { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
    }
}
