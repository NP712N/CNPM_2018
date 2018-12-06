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
        [Key,ForeignKey("MaDaiLy"),Column(Order =0)]
        public string MaDaiLy { get; set; }

        [Key, ForeignKey("MaUuDai"), Column(Order = 1)]
        public string MaUuDai { get; set; }

        public virtual UuDai UuDai { get; set; }
        public virtual DaiLy DaiLy { get; set; }


        public string NoiDung { get; set; }
    }
}
