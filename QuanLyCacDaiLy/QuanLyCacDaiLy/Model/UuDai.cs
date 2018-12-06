using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class UuDai
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaUuDai { get; set; }
        
        [ForeignKey("MaChiTietHoaDon")]
        public string MaChiTietHoaDonRefID { get; set; }
        public virtual ChiTietHoaDon ChiTietHoaDon { get; set; }

        [MaxLength(20)]
        public string TenUuDai { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        [MaxLength(1)]
        public byte LoaiDaiLy { get; set; }
        public string NoiDung { get; set; }
        
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
