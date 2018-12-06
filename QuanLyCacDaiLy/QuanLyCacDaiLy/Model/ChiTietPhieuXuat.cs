using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class ChiTietPhieuXuat
    {
        [Key,ForeignKey("MaPhieu"),Column(Order =0)]      
        public string MaPhieu { get; set; }

        [Key, ForeignKey("MaPhieu"), Column(Order = 1)]     
        public string MaHangHoa { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }
        public virtual HangHoa HangHoa { get; set; }

        public DateTime NgayXuat { get; set; }
    }
}
