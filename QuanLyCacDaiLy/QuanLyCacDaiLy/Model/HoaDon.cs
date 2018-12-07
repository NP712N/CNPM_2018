using QuanLyCacDaiLy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy
{
    public class HoaDon
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }

        public string MaUuDai { get; set; }
        [ForeignKey("MaUuDai")]
        public virtual UuDai UuDai { get; set; }

        
        public string MaHangHoa{ get; set; }
        [ForeignKey("MaHangHoa")]
        public HangHoa HangHoa { get; set; }

        public string MaChiTietHoaDon { get; set; }
        [ForeignKey("MaChiTietHoaDon")]
        public virtual ChiTietHoaDon ChiTietHoaDon { get; set; }

        public string MaPhieuXuat { get; set; }
        [ForeignKey("MaPhieuXuat")]
        public virtual PhieuXuat PhieuXuat { get; set; }

        public string MaPhieuThu { get; set; }
        [ForeignKey("MaPhieuThu")]
        public virtual PhieuThu PhieuThu { get; set; }

        public string MaDonHang { get; set; }
        [ForeignKey("MaDonHang")]
        public virtual DonHang DonHang { get; set; }

        [MaxLength(10)]
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTienGoc { get; set; }
        public double TienSauUuDai { get; set; }
    }
}
