using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPMProject.ViewModel
{
   public class PhieuThuViewModel
    {
        public class ViewPhieuThu
        {
            public string MaPhieuThu { get; set; }
            public string MaHoaDon { get; set; }
            public DateTime NgayLap { get; set; }
            public double TienPhaiTra { get; set; }
            public double TienThu { get; set; }
            public double TienNo { get; set; }
            public ViewPhieuThu()
            {

            }
            public ViewPhieuThu(string maPhieuThu, string maHoaDon, DateTime ngayLap, double tienPhaiTra, double tienThu, double tienNo)
            {
                MaPhieuThu = maPhieuThu;
                MaHoaDon = maHoaDon;
                NgayLap = ngayLap;
                TienPhaiTra = tienPhaiTra;
                TienThu = tienThu;
                TienNo = tienNo;
            }
        }
        public List<ViewPhieuThu> PHIEUTHUS { get; set;}
        public PhieuThuViewModel()
        {
            LoadPhieuThu();
        }

        private void LoadPhieuThu()
        {
            PHIEUTHUS = new List<ViewPhieuThu>();
            using (var db = new QUANLYCACDAILYEntities())
            {
                var query = from hd in db.HOADONs
                            join pt in db.PHIEUTHUs on hd.MaHoaDon equals pt.MaHoaDon
                            select new
                            {
                                pt.MaPhieuThu,
                                hd.MaHoaDon,
                                pt.NgayLapPhieu,
                                hd.ThanhTien,
                                pt.SoTienDaThu
                            };
                foreach (var item in query)
                {
                    ViewPhieuThu viewPhieuThu = new ViewPhieuThu(
                        item.MaPhieuThu,
                        item.MaHoaDon,
                        item.NgayLapPhieu.Value,
                        item.ThanhTien.Value,
                        item.SoTienDaThu.Value,
                        item.ThanhTien.Value-item.SoTienDaThu.Value
                        );

                    PHIEUTHUS.Add(viewPhieuThu);
                }
                
            }
        }
    }
}
