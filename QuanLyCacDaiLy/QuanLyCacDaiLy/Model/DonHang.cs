using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class DonHang
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaDonHang { get; set; }
        public DateTime NgayDangKy { get; set; }

        [ForeignKey("MaHangHoa")]
        public string MaHangHoaRefID { get; set; }
        public virtual HangHoa HangHoa { get; set; }

        [ForeignKey("MaHoaDon")]
        public string MaHoaDonRefID { get; set; }
        public virtual HoaDon HoaDon { get; set; }

        [ForeignKey("MaDaiLy")]
        public string MaDaiLyRefID { get; set; }
        public virtual DaiLy DaiLy { get; set; }

        public int SoLuong { get; set; }
        public float DonGia { get; set; }
    }
}
