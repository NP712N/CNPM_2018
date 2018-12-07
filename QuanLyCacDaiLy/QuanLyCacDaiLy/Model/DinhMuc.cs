using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class DinhMuc
    {
        [Key]
        [Required]
        [MaxLength(10)]
        public string MaDinhMuc { get; set; }

        public int CapDaiLy { get; set; }
        public string NoiDungDinhMuc { get; set; }

        public string MaDaiLy { get; set; }
        [ForeignKey("MaDaiLy")]
        public virtual DaiLy DaiLy { get; set; }
    }
}
