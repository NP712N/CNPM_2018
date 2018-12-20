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
    /// Interaction logic for Hanghoa.xaml
    /// </summary>
    public partial class Hanghoa : Window
    {
        public Hanghoa()
        {
            InitializeComponent();
            using (var db = new QUANLYCACDAILYEntities())
            {
                ds_hanghoa.ItemsSource = db.HANGHOAs.ToList();
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
            txt_mahanghoa.Text = "";
            txt_dongia.Text = "";
            txt_soluong.Text = "";
            txt_tenhanghoa.Text = "";
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                try
                {
                    if (txt_mahanghoa.Text == "" || txt_tenhanghoa.Text == "" || txt_soluong.Text == "" || txt_dongia.Text == "")
                    {
                        MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        var m = new HANGHOA();
                        if (txt_mahanghoa.Text == m.MaHangHoa)
                        {
                            MessageBox.Show("Nhập mã khác", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                        else
                        {
                            var temp = new HANGHOA();
                            if (temp != null)
                            {
                                temp.MaHangHoa = txt_mahanghoa.Text;
                                temp.TenMatHang = txt_tenhanghoa.Text;
                                temp.DonGia = int.Parse(txt_dongia.Text);
                                temp.SoLuongCon = int.Parse(txt_soluong.Text);
                                db.HANGHOAs.Add(temp);
                                db.SaveChanges();
                                ds_hanghoa.ItemsSource = db.HANGHOAs.ToList();
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm hàng hóa không thành công", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            Reset();
        }

        private void button_update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_mahanghoa.Text != "")
                {
                    using (var db = new QUANLYCACDAILYEntities())
                    {


                        if (txt_mahanghoa.Text == "" || txt_tenhanghoa.Text == "" || txt_soluong.Text == "" || txt_dongia.Text == "")
                        {
                            MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else

                        {
                            var m = db.HANGHOAs.ToList().Find(n => n.MaHangHoa == txt_mahanghoa.Text);
                            m.TenMatHang = txt_tenhanghoa.Text;
                            m.DonGia = int.Parse(txt_dongia.Text);
                            m.SoLuongCon = int.Parse(txt_soluong.Text);
                            db.SaveChanges();
                            ds_hanghoa.ItemsSource = db.HANGHOAs.ToList();
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


        private void ds_hanghoa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ds_hanghoa.Items.Count >= 0 && ds_hanghoa.SelectedIndex <= ds_hanghoa.Items.Count - 1)
            {
                var dl = (HANGHOA)ds_hanghoa.SelectedItem;
                if (dl != null)
                {
                    txt_mahanghoa.Text = dl.MaHangHoa;
                    txt_tenhanghoa.Text = dl.TenMatHang;
                    txt_dongia.Text = dl.DonGia.ToString();
                    txt_soluong.Text = dl.SoLuongCon.ToString();
                }

            }
        }

        private void button_refresh_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                var k = (from n in db.HANGHOAs
                         select n).ToList();
                ds_hanghoa.ItemsSource = k;
                ds_hanghoa.Items.Refresh();
            }
        }
        private void button_search_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (txt_search.Text != "")
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.HANGHOAs.ToList().Find(n => n.TenMatHang == txt_search.Text);

                    try
                    {
                            var query = (from n in db.HANGHOAs
                                         where n.TenMatHang == txt_search.Text
                                         select n).ToList();
                            ds_hanghoa.ItemsSource = query;
                            ds_hanghoa.Items.Refresh();
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

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.HANGHOAs.ToList().Find(n => n.MaHangHoa == ((HANGHOA)ds_hanghoa.SelectedItem).MaHangHoa);
                    if (m != null)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            db.HANGHOAs.Remove(m);
                            db.SaveChanges();
                            ds_hanghoa.ItemsSource = db.DONHANGs.ToList();
                            ds_hanghoa.Items.Refresh();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn hàng hóa", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reset();
        }
    }
}
