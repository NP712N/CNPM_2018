using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class BaoCaoDoanhThu
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaDoanhThu { get; set; }

        public DateTime NgayLap { get; set; }
        public DateTime DenNgay { get; set; }

        public string MaDaiLy { get; set; }
        [ForeignKey("MaDaiLy")]
        public virtual DaiLy DaiLy { get; set; }

        public string MaDinhMuc { get; set; }
        [ForeignKey("MaDinhMuc")]
        public virtual DinhMuc DinhMuc { get; set; }

        public string MaHangHoa { get; set; }
        [ForeignKey("MaHangHoa")]
        public virtual HangHoa HangHoa { get; set; }

        public int SoLuong { get; set; }
        public double TongDoanhThu { get; set; }

        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        
    }
}
