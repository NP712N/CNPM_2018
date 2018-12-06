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

        [ForeignKey("MaHoaDon")]
        public string MaHoaDonRefID { get; set; }
        public virtual HoaDon HoaDon { get; set; }

        [ForeignKey("MaCongNo")]
        public string BaoCaoCongNoRefID { get; set; }
        public virtual BaoCaoCongNo BaoCaoCongNo { get; set; }

        public DateTime NgayLapPhieu { get; set; }
        public double TienPhaiTra { get; set; }
        public double TienThu { get; set; }
        public double ConThieu { get; set; }
    }
}
