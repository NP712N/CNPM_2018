using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
   public class No
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaNo { get; set; }

        public string MaDaiLy { get; set; }
        [ForeignKey("MaDaiLy")]
        public virtual DaiLy DaiLy { get; set; }

        public string MaPhieuThu { get; set; }
        [ForeignKey("MaPhieuThu")]
        public virtual PhieuThu PhieuThu { get; set; }

        [MaxLength(10)]
        public string MaThuTien { get; set; }
        public float TienNo { get; set; }        
    }
}
