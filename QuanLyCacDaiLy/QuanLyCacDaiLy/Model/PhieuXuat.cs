using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class PhieuXuat
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaPhieuXuat { get; set; }

        public string MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HoaDon { get; set; }

        public string MaChiTietPhieuXuat { get; set; }
        [ForeignKey("MaChiTietPhieuXuat")]
        public virtual ChiTietPhieuXuat ChiTietPhieuXuat { get; set; }

        [MaxLength(10)]
        public string MaDonHang { get; set; }
        public DateTime NgayXuat { get; set; }
        
    }
}
