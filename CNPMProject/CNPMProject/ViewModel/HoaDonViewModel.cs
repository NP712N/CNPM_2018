using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPMProject.ViewModel
{
    public class HoaDonViewModel
    {
        public class ViewHoaDon
        {
            public string TenDaiLy { get; set; }
            public string MaHoaDon { get; set; }
            public string TenMatHang { get; set; }
            public DateTime NgayLap { get; set; }
            public int SoLuong { get; set; }
            public double DonGia { get; set; }
            public double ThanhTien { get; set; }
            public string PhanTram { get; set; }
            public double TienSauUuDai { get; set; }

            public ViewHoaDon()
            {

            }

            public ViewHoaDon(string tenDaiLy, string maHoaDon, string tenMatHang, DateTime ngayLap, int soLuong,double donGia, double thanhTien,string phanTram, double thanhTienSauUuDai)
            {
                TenDaiLy = tenDaiLy;
                MaHoaDon = maHoaDon;
                TenMatHang = tenMatHang;
                NgayLap = ngayLap;
                SoLuong = soLuong;
                DonGia = donGia;
                ThanhTien = thanhTien;
                PhanTram = phanTram;
                TienSauUuDai = thanhTienSauUuDai;
            }
        }

        public List<ViewHoaDon> HOADONS { get; set; }
        public HoaDonViewModel()
        {
            LoadHoaDon();

        }

        private void LoadHoaDon()
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                HOADONS = new List<ViewHoaDon>();

                var query1 = from ud in db.UUDAIs
                             from dl in db.DAILies 
                             join dh in db.DONHANGs on dl.MaDaiLy equals dh.MaDaiLy
                             join hd in db.HOADONs on dh.MaDonHang equals hd.MaDonHang
                             join px in db.PHIEUXUATs on hd.MaPhieuXuat equals px.MaPhieuXuat
                             join ct in db.CHITIETHANGHOAXUATs on px.MaPhieuXuat equals ct.MaPhieuXuat
                             join hh in db.HANGHOAs on ct.MaHangHoa equals hh.MaHangHoa
                             where dl.UUDAIs.Contains(ud)
                             select new
                             {
                                 dl.MaDaiLy,
                                 dl.TenDaiLy,
                                 hd.MaHoaDon,
                                 hh.TenMatHang,
                                 hd.NgayLap,
                                 ct.SoLuong,
                                 px.ThanhTien,
                                 hh.DonGia,
                                 ud.PhanTram
                             };

                
                foreach (var item in query1)
                {
                    ViewHoaDon viewHoaDon = new ViewHoaDon(
                        item.TenDaiLy,
                        item.MaHoaDon,
                        item.TenMatHang,
                        item.NgayLap.Value,
                        item.SoLuong.Value,
                        item.DonGia.Value,
                        item.SoLuong.Value*item.DonGia.Value,
                        item.PhanTram.Value+"%",
                        item.SoLuong.Value * item.DonGia.Value*((100-item.PhanTram.Value)/100)
                        );
                    HOADONS.Add(viewHoaDon);
                }
            }
        }
    }
}
