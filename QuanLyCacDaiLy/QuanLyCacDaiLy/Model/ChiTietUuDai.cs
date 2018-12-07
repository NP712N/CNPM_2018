using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class ChiTietUuDai
    {
        [Key]
        [MaxLength(10)]
        public string MaChiTietUuDai { get; set; }

        public string MaDaiLy { get; set; }
        [ForeignKey("MaDaiLy")]
        public virtual DaiLy DaiLy { get; set; }


        public string MaUuDai { get; set; }
        [ForeignKey("MaUuDai")]
        public virtual UuDai UuDai { get; set; }

        public string NoiDung { get; set; }
    }
}
