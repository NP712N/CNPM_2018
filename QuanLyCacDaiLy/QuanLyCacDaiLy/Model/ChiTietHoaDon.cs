using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class ChiTietHoaDon
    {
        [Key,ForeignKey("MaHoaDon"),Column(Order =0)]
        public string MaHoaDon { get; set; }

        [Key, ForeignKey("MaDoanhThu"), Column(Order = 0)]
        public string MaDoanhThu { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual BaoCaoDoanhThu BaoCaoDoanhThu  { get; set; }

        public double ThanhTien { get; set; }
    }
}
