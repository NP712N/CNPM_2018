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

        public string MaHangHoa { get; set; }
        [ForeignKey("MaHangHoa")]
        public virtual HangHoa HangHoa { get; set; }

        public string MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HoaDon { get; set; }

        public string MaDaiLy { get; set; }
        [ForeignKey("MaDaiLy")]
        public virtual DaiLy DaiLy { get; set; }

        public int SoLuong { get; set; }
        public float DonGia { get; set; }
    }
}
