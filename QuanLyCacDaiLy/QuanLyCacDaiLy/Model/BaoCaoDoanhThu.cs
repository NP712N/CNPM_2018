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

        [ForeignKey("MaDaiLy")]
        public string MaDaiLyRefID { get; set; }
        public virtual DaiLy DaiLy { get; set; }

        [ForeignKey("MaDinhMuc")]
        public string MaDinhMucRefID { get; set; }
        public virtual DinhMuc DinhMuc { get; set; }

        [ForeignKey("MaMatHang")]
        public string MaMatHangRefID { get; set; }
        public virtual HangHoa HangHoa { get; set; }

        public int SoLuong { get; set; }
        public double TongDoanhThu { get; set; }

        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        
    }
}
