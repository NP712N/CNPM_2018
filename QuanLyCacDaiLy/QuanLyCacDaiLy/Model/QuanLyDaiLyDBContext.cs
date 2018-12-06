using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCacDaiLy.Model
{
    public class QuanLyDaiLyDBContext : DbContext
    {
        public QuanLyDaiLyDBContext() : base("QuanLyDaiLyDB")
        {
            Database.SetInitializer<QuanLyDaiLyDBContext>(new CreateDatabaseIfNotExists<QuanLyDaiLyDBContext>());
        }

        public DbSet<BaoCaoCongNo> BaoCaoCongNos { get; set; }
        public DbSet<BaoCaoDoanhThu> BaoCaoDoanhThus { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public DbSet<ChiTietUuDai> ChiTietUuDais { get; set; }
        public DbSet<DaiLy> DaiLys { get; set; }
        public DbSet<DinhMuc> DinhMucs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<No> Nos { get; set; }
        public DbSet<PhieuThu> PhieuThus { get; set; }
        public DbSet<PhieuXuat> PhieuXuats { get; set; }
        public DbSet<UuDai> UuDais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
