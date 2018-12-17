using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPMProject.ViewModel
{
    public class DonHangViewModel
    {
        public class ViewDonHang
        {
            public string MaDonHang { get; set; }
            public string TenDaiLy { get; set; }
            public string TenMatHang { get; set; }
            public Nullable<DateTime> NgayDangKy { get; set; }
            public int SoLuong { get; set; }
            public double DonGia { get; set; }

            public ViewDonHang()
            {

            }

            public ViewDonHang(string maDonHang, string tenDaiLy, string tenMatHang, DateTime ngayDangKy,int soLuong, double donGia)
            {
                MaDonHang = maDonHang;
                TenDaiLy = tenDaiLy;
                TenMatHang = tenMatHang;
                NgayDangKy = ngayDangKy;
                SoLuong = soLuong;
                DonGia = donGia;
            }
        }

        
        public List<ViewDonHang> DONHANGS { get; set; }
        public DonHangViewModel()
        {
            LoadDonHang();
        }

        private void LoadDonHang()
        {
            using (var db = new QUANLYCACDAILYEntities())
            {                
                var query = (from dl in db.DAILies
                             join dh in db.DONHANGs on dl.MaDaiLy equals dh.MaDaiLy
                             join hd in db.HOADONs on dh.MaDonHang equals hd.MaDonHang
                             join px in db.PHIEUXUATs on hd.MaPhieuXuat equals px.MaPhieuXuat
                             join ct in db.CHITIETHANGHOAXUATs on px.MaPhieuXuat equals ct.MaPhieuXuat
                             join hh in db.HANGHOAs on ct.MaHangHoa equals hh.MaHangHoa
                             select new {
                                 dh.MaDonHang,
                                 dl.TenDaiLy,
                                 hh.TenMatHang,
                                 dh.NgayDangKy,
                                 ct.SoLuong,
                                 hh.DonGia
                             }).ToList();
                DONHANGS = new List<ViewDonHang>();
                foreach (var item in query)
                {
                    ViewDonHang viewDonHang = new ViewDonHang(
                        item.MaDonHang,
                        item.TenDaiLy,
                        item.TenMatHang,
                        item.NgayDangKy.Value,
                        item.SoLuong.Value,
                        item.DonGia.Value);
                    DONHANGS.Add(viewDonHang);
                }
            }
        }
    }
}
