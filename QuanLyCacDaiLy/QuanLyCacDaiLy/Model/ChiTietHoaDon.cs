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
        [Key]
        [MaxLength(10)]
        public string MaChiTietHoaDon { get; set; }

        public string MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HoaDon { get; set; }

        public string MaDoanhThu { get; set; }
        [ForeignKey("MaDoanhThu")]
        public virtual BaoCaoDoanhThu BaoCaoDoanhThu { get; set; }

        public double ThanhTien { get; set; }
    }
}
