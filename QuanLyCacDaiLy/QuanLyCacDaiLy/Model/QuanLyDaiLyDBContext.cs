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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<QuanLyDaiLyDBContext, QuanLyCacDaiLy.Migrations.Configuration>());
        }

        public DbSet<DinhMuc> DinhMucs { get; set; }
        public DbSet<DaiLy> DaiLys { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }       
        public DbSet<UuDai> UuDais { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<BaoCaoCongNo> BaoCaoCongNos { get; set; }
        public DbSet<BaoCaoDoanhThu> BaoCaoDoanhThus { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public DbSet<ChiTietUuDai> ChiTietUuDais { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<No> Nos { get; set; }
        public DbSet<PhieuThu> PhieuThus { get; set; }
        public DbSet<PhieuXuat> PhieuXuats { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoCaoCongNo>()
                .HasRequired<DaiLy>(s => s.DaiLy)
                .WithMany(g => g.BaoCaoCongNos)
                .HasForeignKey<string>(s => s.MaDaiLy);

            modelBuilder.Entity<DaiLy>()
                .HasRequired(s => s.DinhMuc)
                .WithRequiredPrincipal(dm => dm.DaiLy);
            

            modelBuilder.Entity<No>()
                .HasRequired<DaiLy>(s => s.DaiLy)
                .WithMany(g => g.Nos)
                .HasForeignKey<string>(s => s.MaDaiLy);

            modelBuilder.Entity<DonHang>()
                .HasRequired<DaiLy>(s => s.DaiLy)
                .WithMany(g => g.DonHangs)
                .HasForeignKey<string>(s => s.MaDaiLy);

            modelBuilder.Entity<ChiTietUuDai>()
                .HasRequired<DaiLy>(s => s.DaiLy)
                .WithMany(g => g.ChiTietUuDais)
                .HasForeignKey<string>(s => s.MaDaiLy);

            modelBuilder.Entity<HangHoa>()
                .HasRequired<ChiTietPhieuXuat>(s => s.ChiTietPhieuXuat)
                .WithMany(g => g.HangHoas)
                .HasForeignKey<string>(s => s.MaChiTietPhieuXuat);


            modelBuilder.Entity<ChiTietPhieuXuat>()
                .HasRequired(s => s.PhieuXuat)
                .WithRequiredPrincipal(dm => dm.ChiTietPhieuXuat);

            modelBuilder.Entity<ChiTietHoaDon>()
                .HasRequired(s => s.HoaDon)
                .WithRequiredPrincipal(dm => dm.ChiTietHoaDon);

            modelBuilder.Entity<HoaDon>()
                .HasRequired(s => s.DonHang)
                .WithRequiredPrincipal(dm => dm.HoaDon);

            modelBuilder.Entity<HoaDon>()
                .HasRequired(s => s.PhieuThu)
                .WithRequiredPrincipal(dm => dm.HoaDon);

            modelBuilder.Entity<PhieuXuat>()
                .HasRequired(s => s.HoaDon)
                .WithRequiredPrincipal(dm => dm.PhieuXuat);

            base.OnModelCreating(modelBuilder);
        }
    }
}
