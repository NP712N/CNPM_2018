using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class DaiLy
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaDaiLy { get; set; }

        [ForeignKey("MaDinhMuc")]
        public string MaDinhMucRefID { get; set; }
        public virtual DinhMuc DinhMuc { get; set; }

        [MaxLength(10)]
        public string MaHopDong { get; set; }
        public DateTime NgayLap { get; set; }
        [MaxLength(9)]
        public string CMND { get; set; }
        [MaxLength(20)]
        public string HoTenChuDaiLy { get; set; }
        public DateTime NgaySinh { get; set; }
        [MaxLength(1)]
        public byte CapDaiLy { get; set; }
        [MaxLength(20)]
        public string TenDaiLy { get; set; }
        public string NoiDung { get; set; }
        public string CongNo { get; set; }

        public ICollection<BaoCaoCongNo> BaoCaoCongNos { get; set; }
        public ICollection<ChiTietUuDai> ChiTietUuDais { get; set; }
        public ICollection<No> Nos { get; set; }
        
        public ICollection<DonHang> DonHangs { get; set; }
    }
}
