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
    /// Interaction logic for DonHang.xaml
    /// </summary>
    public partial class DonHang : Window
    {
        public DonHang()
        {
            InitializeComponent();
            using (var db = new QUANLYCACDAILYEntities())
            {
                ds_donhang.ItemsSource = db.DONHANGs.ToList();
                cb_madaily.ItemsSource = db.DAILies.ToList();
                cb_madaily.DisplayMemberPath = "TenDaiLy";
                cb_madaily.SelectedValuePath = "MaDaiLy";
                cb_madaily.SelectedIndex = 0;
                dp_ngaydangky.SelectedDate = DateTime.Now;
            }
        }
        public void Reset()
        {
            txt_madonhang.Text = "";
            cb_madaily.Text = "";
        }
        private void button_closewindow_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                Close();
            }
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                try
                {
                    if (txt_madonhang.Text == "" || cb_madaily.SelectedValue == null || dp_ngaydangky.Text == "")
                    {
                        MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        var m = new DONHANG();
                        if (txt_madonhang.Text == m.MaDonHang)
                        {
                            MessageBox.Show("Nhập mã khác", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                        else
                        {
                            var temp = new DONHANG();
                            if (temp != null)
                            {
                                temp.MaDonHang = txt_madonhang.Text;
                                temp.MaDaiLy = cb_madaily.SelectedValue.ToString();
                                temp.NgayDangKy = DateTime.Parse(dp_ngaydangky.Text);
                                db.DONHANGs.Add(temp);
                                db.SaveChanges();
                                ds_donhang.ItemsSource = db.DONHANGs.ToList();
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm đơn hàng không thành công", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            Reset();
        }

        private void button_update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_madonhang.Text != "" && cb_madaily.SelectedValue.ToString() != "")
                {
                    using (var db = new QUANLYCACDAILYEntities())
                    {


                        if (txt_madonhang.Text == "" || cb_madaily.SelectedValue == null || dp_ngaydangky.Text == "")
                        {
                            MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else

                        {
                            var m = db.DONHANGs.ToList().Find(n => n.MaDonHang == txt_madonhang.Text);
                            m.MaDaiLy = cb_madaily.SelectedValue.ToString();
                            m.NgayDangKy = DateTime.Parse(dp_ngaydangky.Text);
                            db.SaveChanges();
                            ds_donhang.ItemsSource = db.DONHANGs.ToList();
                            MessageBox.Show("Sửa thông tin thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);

                        }

                    }
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.DONHANGs.ToList().Find(n => n.MaDonHang == ((DONHANG)ds_donhang.SelectedItem).MaDonHang);
                    if (m != null)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            db.DONHANGs.Remove(m);
                            db.SaveChanges();
                            ds_donhang.ItemsSource = db.DONHANGs.ToList();
                            ds_donhang.Items.Refresh();
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reset();
        }

        private void ds_donhang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ds_donhang.Items.Count >= 0 && ds_donhang.SelectedIndex <= ds_donhang.Items.Count - 1)
            {
                var dl = (DONHANG)ds_donhang.SelectedItem;
                if (dl != null)
                {
                    txt_madonhang.Text = dl.MaDonHang;
                    dp_ngaydangky.Text = dl.NgayDangKy.ToString();
                    using (var db = new QUANLYCACDAILYEntities())
                    {
                        var l = db.DAILies.Find(dl.MaDaiLy);
                        cb_madaily.SelectedIndex = db.DAILies.ToList().IndexOf(l);
                    }
                }

            }
        }

        private void button_search_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (txt_search.Text != "")
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.DONHANGs.ToList().Find(n => n.MaDonHang == txt_search.Text);
                    try
                    {

                        var query = (from n in db.DONHANGs
                                     where n.MaDonHang == txt_search.Text
                                     select n).ToList();
                        ds_donhang.ItemsSource = query;
                        ds_donhang.Items.Refresh();
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

        private void button_refresh_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                var k = (from n in db.DONHANGs
                         join m in db.DAILies on n.MaDaiLy equals m.MaDaiLy
                         select n).ToList();
                ds_donhang.ItemsSource = k;
                ds_donhang.Items.Refresh();
            }
        }
    }
}
