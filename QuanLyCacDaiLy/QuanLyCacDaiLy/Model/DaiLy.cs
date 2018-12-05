using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class DaiLy
    {
        public string MaDaiLy { get; set; }
        public string MaHopDong { get; set; }
        public DateTime NgayLap { get; set; }
        public string CMND { get; set; }
        public string HoTenChuDaiLy { get; set; }
        public DateTime NgaySinh { get; set; }
        public byte CapDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string NoiDung { get; set; }
        public string CongNo { get; set; }
    }
}
