using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class BaoCaoCongNo
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaCongNo { get; set; }

        public string MaDaiLy { get; set; }
        [ForeignKey("MaDaiLy")]
        public virtual DaiLy DaiLy { get; set; }

        public string MaDinhMuc { get; set; }
        [ForeignKey("MaDinhMuc")]
        public virtual DinhMuc DinhMuc { get; set; }

        public DateTime NgayLap { get; set; }
        public DateTime NgayGhiNo { get; set; }
        public DateTime KyHan { get; set; }
        public string GhiChu { get; set; }

        
        public ICollection<PhieuThu> PhieuThus { get; set; }
    }
}
