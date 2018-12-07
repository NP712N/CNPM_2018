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
        [Key]
        [MaxLength(10)]
        public string MaChiTietPhieuXuat { get; set; }

        public string MaPhieuXuat { get; set; }
        [ForeignKey("MaPhieuXuat")]
        public virtual PhieuXuat PhieuXuat { get; set; }

        
        public ICollection<HangHoa> HangHoas { get; set; }

        public DateTime NgayXuat { get; set; }
    }
}
