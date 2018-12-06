using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class HangHoa
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaHangHoa { get; set; }

        [ForeignKey("MaChiTietPhieuXuat")]
        public string MaChiTietPhieuXuatRefID { get; set; }
        public virtual ChiTietPhieuXuat ChiTietPhieuXuat { get; set; }

        [MaxLength(20)]
        public string TenMatHang { get; set; }
        public float DonGia { get; set; }
        public int SoLuongCon { get; set; }

        
    }
}
