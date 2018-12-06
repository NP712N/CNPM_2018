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
        public string MaHD { get; set; }
        public DateTime NgayLap { get; set; }

        [ForeignKey("MaUuDai")]
        public string MaUuDaiRefID { get; set; }
        public virtual UuDai UuDai { get; set; }

        [ForeignKey("MaHangHoa")]
        public string MaHangHoaRefID { get; set; }
        public HangHoa HangHoa { get; set; }

        [ForeignKey("MaChiTietHoaDon")]
        public string MaChiTietHoaDonRefID { get; set; }
        public virtual ChiTietHoaDon ChiTietHoaDon { get; set; }

        [ForeignKey("MaPhieuXuat")]
        public string MaPhieuXuatRefID { get; set; }
        public virtual PhieuXuat PhieuXuat { get; set; }

        [ForeignKey("MaPhieuThu")]
        public string MaPhieuThuRefID { get; set; }
        public virtual PhieuThu PhieuThu { get; set; }

        [ForeignKey("MaDonHang")]
        public string MaDonHangRefID { get; set; }
        public virtual DonHang DonHang { get; set; }

        [MaxLength(10)]
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTienGoc { get; set; }
        public double TienSauUuDai { get; set; }
    }
}
