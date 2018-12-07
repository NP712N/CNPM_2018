using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class PhieuThu
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaPhieuThu { get; set; }

        public string MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HoaDon { get; set; }

        public string MaBaoCaoCongNo { get; set; }
        [ForeignKey("MaBaoCaoCongNo")]
        public virtual BaoCaoCongNo BaoCaoCongNo { get; set; }

        public DateTime NgayLapPhieu { get; set; }
        public double TienPhaiTra { get; set; }
        public double TienThu { get; set; }
        public double ConThieu { get; set; }
    }
}
