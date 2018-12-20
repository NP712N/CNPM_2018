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
    /// Interaction logic for Phieuthu.xaml
    /// </summary>
    public partial class Phieuthu : Window
    {
        public Phieuthu()
        {
            InitializeComponent();
            using (var db = new QUANLYCACDAILYEntities())
            {
                ds_phieuthu.ItemsSource = db.PHIEUTHUs.ToList();
                cb_mahoadon.ItemsSource = db.HOADONs.ToList();
                cb_mahoadon.DisplayMemberPath = "MaHoaDon";
                cb_mahoadon.SelectedValuePath = "MaHoaDon";
                cb_mahoadon.SelectedIndex = 0;
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
            txt_maphieuthu.Text = "";
            cb_mahoadon.Text = "";
            txt_tienphaitra.Text = "";
        }
        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                try
                {
                    if (txt_maphieuthu.Text == "" || cb_mahoadon.SelectedValue == null || dp_ngaylap.Text == "" || txt_tienphaitra.Text == "")
                    {
                        MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        var m = new PHIEUTHU();
                        if (txt_maphieuthu.Text == m.MaPhieuThu)
                        {
                            MessageBox.Show("Nhập mã khác", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                        else
                        {
                            var temp = new PHIEUTHU();
                            if (temp != null)
                            {
                                temp.MaPhieuThu = txt_maphieuthu.Text;
                                temp.MaHoaDon = cb_mahoadon.SelectedValue.ToString();
                                temp.NgayLapPhieu = DateTime.Parse(dp_ngaylap.Text);
                                temp.SoTienDaThu = int.Parse(txt_tienphaitra.Text);
                                db.PHIEUTHUs.Add(temp);
                                db.SaveChanges();
                                ds_phieuthu.ItemsSource = db.PHIEUTHUs.ToList();
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm phiếu thu không thành công", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            Reset();
        }

        private void button_update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_maphieuthu.Text != "" && cb_mahoadon.SelectedValue.ToString() != null)
                {
                    using (var db = new QUANLYCACDAILYEntities())
                    {


                        if (txt_maphieuthu.Text == "" || cb_mahoadon.SelectedValue == null || dp_ngaylap.Text == "" || txt_tienphaitra.Text == "")
                        {
                            MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else

                        {
                            var m = db.PHIEUTHUs.ToList().Find(n => n.MaPhieuThu == txt_maphieuthu.Text);
                            m.MaHoaDon = cb_mahoadon.SelectedValue.ToString();
                            m.NgayLapPhieu = DateTime.Parse(dp_ngaylap.Text);
                            m.SoTienDaThu = int.Parse(txt_tienphaitra.Text);
                            db.SaveChanges();
                            ds_phieuthu.ItemsSource = db.PHIEUTHUs.ToList();
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

        private void ds_phieuthu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ds_phieuthu.Items.Count >= 0 && ds_phieuthu.SelectedIndex <= ds_phieuthu.Items.Count - 1)
            {
                var dl = (PHIEUTHU)ds_phieuthu.SelectedItem;
                if (dl != null)
                {
                    txt_maphieuthu.Text = dl.MaPhieuThu;
                    dp_ngaylap.Text = dl.NgayLapPhieu.ToString();
                    txt_tienphaitra.Text = dl.SoTienDaThu.ToString();
                    using (var db = new QUANLYCACDAILYEntities())
                    {
                        var l = db.HOADONs.Find(dl.MaHoaDon);
                        cb_mahoadon.SelectedIndex = db.HOADONs.ToList().IndexOf(l);
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
                    var m = db.PHIEUTHUs.ToList().Find(n => n.MaHoaDon == ((PHIEUTHU)ds_phieuthu.SelectedItem).MaPhieuThu);
                    if (m != null)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            db.PHIEUTHUs.Remove(m);
                            db.SaveChanges();
                            ds_phieuthu.ItemsSource = db.PHIEUTHUs.ToList();
                            ds_phieuthu.Items.Refresh();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn phiếu thu", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reset();
        }

        private void button_refresh_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                var k = (from n in db.PHIEUTHUs
                         join m in db.HOADONs on n.MaHoaDon equals m.MaHoaDon
                         select n).ToList();
                ds_phieuthu.ItemsSource = k;
                ds_phieuthu.Items.Refresh();
            }
        }

        private void button_search_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (txt_search.Text != "")
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.PHIEUTHUs.ToList().Find(n => n.MaPhieuThu == txt_search.Text);

                    try
                    {
                        var query = (from n in db.PHIEUTHUs
                                     join k in db.HOADONs on n.MaHoaDon equals k.MaHoaDon
                                     where n.MaPhieuThu == txt_search.Text
                                     select n).ToList();
                        ds_phieuthu.ItemsSource = query;
                        ds_phieuthu.Items.Refresh();
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
