using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CNPMProject
{
    /// <summary>
    /// Interaction logic for Hoadon.xaml
    /// </summary>
    public partial class Hoadon : Window
    {
        public Hoadon()
        {
            InitializeComponent();
            using (var db = new QUANLYCACDAILYEntities())
            {
                ds_hoadon.ItemsSource = db.HOADONs.ToList();
                cb_madonhang.ItemsSource = db.DONHANGs.ToList();
                cb_maphieuxuat.ItemsSource = db.PHIEUXUATs.ToList();
                cb_madonhang.DisplayMemberPath = "MaDonHang";
                cb_madonhang.SelectedValuePath = "MaDonHang";
                cb_madonhang.SelectedIndex = 0;
                cb_maphieuxuat.DisplayMemberPath = "MaPhieuXuat";
                cb_maphieuxuat.SelectedValuePath = "MaPhieuXuat";
                cb_maphieuxuat.SelectedIndex = 0;
                dp_ngaylap.SelectedDate = DateTime.Now;
            }
        }
        private void button_closewindow_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                Close();
            }
        }
        public void Reset()
        {
            txt_mahoadon.Text = "";
            cb_madonhang.Text = "";
            cb_maphieuxuat.Text = "";
            txt_thanhtien.Text = "";
        }
        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                try
                {
                    if (txt_mahoadon.Text == "" || cb_madonhang.SelectedValue == null || cb_maphieuxuat.SelectedValue == null || dp_ngaylap.Text == "" || txt_thanhtien.Text == "")
                    {
                        MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        var m = new HOADON();
                        if (txt_mahoadon.Text == m.MaHoaDon)
                        {
                            MessageBox.Show("Nhập mã khác", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                        else
                        {
                            var temp = new HOADON();
                            if (temp != null)
                            {
                                temp.MaHoaDon = txt_mahoadon.Text;
                                temp.MaDonHang = cb_madonhang.SelectedValue.ToString();
                                temp.MaPhieuXuat = cb_maphieuxuat.SelectedValue.ToString();
                                temp.NgayLap= DateTime.Parse(dp_ngaylap.Text);
                                temp.ThanhTien = int.Parse(txt_thanhtien.Text);
                                db.HOADONs.Add(temp);
                                db.SaveChanges();
                                ds_hoadon.ItemsSource = db.HOADONs.ToList();
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm hóa đơn không thành công", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            Reset();
        }

        private void button_update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_mahoadon.Text != "" )
                {
                    using (var db = new QUANLYCACDAILYEntities())
                    {


                        if (txt_mahoadon.Text == "" || cb_madonhang.SelectedValue == null || cb_maphieuxuat.SelectedValue == null || dp_ngaylap.Text == "" || txt_thanhtien.Text == "")
                        {
                            MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else

                        {
                            var m = db.HOADONs.ToList().Find(n => n.MaHoaDon == txt_mahoadon.Text);
                            m.MaDonHang = cb_madonhang.SelectedValue.ToString();
                            m.MaPhieuXuat = cb_maphieuxuat.SelectedValue.ToString();
                            m.NgayLap = DateTime.Parse(dp_ngaylap.Text);
                            m.ThanhTien = int.Parse(txt_thanhtien.Text);
                            db.SaveChanges();
                            ds_hoadon.ItemsSource = db.HOADONs.ToList();
                            MessageBox.Show("Sửa thông tin thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);

                        }

                    }
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("không thể sửa ID", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ds_hoadon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ds_hoadon.Items.Count >= 0 && ds_hoadon.SelectedIndex <= ds_hoadon.Items.Count - 1)
            {
                var dl = (HOADON)ds_hoadon.SelectedItem;
                if (dl != null)
                {
                    txt_mahoadon.Text = dl.MaHoaDon;
                    dp_ngaylap.Text = dl.NgayLap.ToString();
                    txt_thanhtien.Text = dl.ThanhTien.ToString();
                    using (var db = new QUANLYCACDAILYEntities())
                    {
                        var l = db.DONHANGs.Find(dl.MaDonHang);
                        cb_madonhang.SelectedIndex = db.DONHANGs.ToList().IndexOf(l);
                        var k = db.PHIEUXUATs.Find(dl.MaPhieuXuat);
                        cb_maphieuxuat.SelectedIndex = db.PHIEUXUATs.ToList().IndexOf(k);
                    }
                }

            }
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.HOADONs.ToList().Find(n => n.MaHoaDon == ((HOADON)ds_hoadon.SelectedItem).MaHoaDon);
                    if (m != null)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            db.HOADONs.Remove(m);
                            db.SaveChanges();
                            ds_hoadon.ItemsSource = db.HOADONs.ToList();
                            ds_hoadon.Items.Refresh();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reset();
        }

        private void button_refresh_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                var k = (from n in db.HOADONs
                         join m in db.DONHANGs on n.MaDonHang equals m.MaDonHang
                         join t in db.PHIEUXUATs on n.MaPhieuXuat equals t.MaPhieuXuat
                         select n).ToList();
                ds_hoadon.ItemsSource = k;
                ds_hoadon.Items.Refresh();
            }
        }

        private void button_search_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (txt_search.Text != "")
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.HOADONs.ToList().Find(n => n.MaHoaDon == txt_search.Text);

                    try
                    {
                        var query = (from n in db.HOADONs
                                     join k in db.DONHANGs on n.MaDonHang equals k.MaDonHang
                                     join t in db.PHIEUXUATs on n.MaPhieuXuat equals t.MaPhieuXuat
                                     where n.MaHoaDon == txt_search.Text
                                     select n).ToList();
                        ds_hoadon.ItemsSource = query;
                        ds_hoadon.Items.Refresh();
                        txt_search.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Không thể tìm được", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        txt_search.Text = "";
                        button_refresh_Click(sender, e);
                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập để tìm kiếm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
