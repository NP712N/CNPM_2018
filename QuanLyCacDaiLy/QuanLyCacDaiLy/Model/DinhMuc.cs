using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [MaxLength(1)]
        public byte CapDaiLy { get; set; }
        public string NoiDungDinhMuc { get; set; }

        public virtual DaiLy DaiLy { get; set; }
    }
}
