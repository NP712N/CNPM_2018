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
    /// Interaction logic for Daily.xaml
    /// </summary>
    public partial class Daily : Window
    {
        public Daily()
        {
            InitializeComponent();
            using (var db = new QUANLYCACDAILYEntities())
            {
                ds_daily.ItemsSource = db.DAILies.ToList();
                cb_madinhmuc.ItemsSource = db.DINHMUCs.ToList();
                cb_madinhmuc.DisplayMemberPath = "CapDaiLy";
                cb_madinhmuc.SelectedValuePath = "MaDinhMuc";
                cb_madinhmuc.SelectedIndex = 0;
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
            txt_madaily.Text = "";
            cb_madinhmuc.Text = "";
            txt_mahopdong.Text = "";
            txt_cmnd.Text = "";
            txt_hotenchudaily.Text = "";
            dp_ngaysinh.Text = "";
            txt_cap.Text = "";
            txt_tendaily.Text = "";
            txt_noidung.Text = "";
        }

        private void button_update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_madaily.Text != "" && cb_madinhmuc.SelectedValue.ToString() != "")
                {
                    using (var db = new QUANLYCACDAILYEntities())
                    {


                        if (txt_madaily.Text == "" || txt_mahopdong.Text == "" || txt_tendaily.Text == "" || cb_madinhmuc.SelectedValue == null || txt_hotenchudaily.Text == "" || txt_cmnd.Text == "" || txt_cap.Text == "" || dp_ngaylap.Text == "" || dp_ngaysinh.Text == "")
                        {
                            MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else

                        {
                            var m = db.DAILies.ToList().Find(n => n.MaDaiLy == txt_madaily.Text);
                            m.MaDinhMuc = cb_madinhmuc.SelectedValue.ToString();
                            m.MaHopDong = txt_mahopdong.Text;
                            m.NgayLap = DateTime.Parse(dp_ngaylap.Text);
                            m.CMND = txt_cmnd.Text;
                            m.HoTenChuDaiLy = txt_hotenchudaily.Text;
                            m.NgaySinh = DateTime.Parse(dp_ngaysinh.Text);
                            m.CapDaiLy = txt_cap.Text;
                            m.TenDaiLy = txt_tendaily.Text;
                            m.NoiDung = txt_noidung.Text;
                            db.SaveChanges();
                            ds_daily.ItemsSource = db.DAILies.ToList();
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



        private void button_add_Click(object sender, RoutedEventArgs e)
        {

            if (txt_madaily.Text != "" || txt_mahopdong.Text != "" || txt_tendaily.Text != "" || cb_madinhmuc.SelectedValue != null || txt_hotenchudaily.Text != "" || txt_cmnd.Text != "" || txt_cap.Text != "" || dp_ngaylap.Text != "" || dp_ngaysinh.Text != "")
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = new DAILY();
                    try { 
                        if (txt_madaily.Text != m.MaDaiLy)
                        {
                            var temp = new DAILY();
                            if (temp != null)
                            {
                                temp.MaDaiLy = txt_madaily.Text;
                                temp.MaDinhMuc = cb_madinhmuc.SelectedValue.ToString();
                                temp.MaHopDong = txt_mahopdong.Text;
                                temp.NgayLap = DateTime.Parse(dp_ngaylap.Text);
                                temp.CMND = txt_cmnd.Text;
                                temp.HoTenChuDaiLy = txt_hotenchudaily.Text;
                                temp.NgaySinh = DateTime.Parse(dp_ngaysinh.Text);
                                temp.CapDaiLy = txt_cap.Text;
                                temp.TenDaiLy = txt_tendaily.Text;
                                temp.NoiDung = txt_noidung.Text;
                                db.DAILies.Add(temp);
                                db.SaveChanges();
                                ds_daily.ItemsSource = db.DAILies.ToList();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Nhập mã khác", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }




            Reset();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.DAILies.ToList().Find(n => n.MaDaiLy == ((DAILY)ds_daily.SelectedItem).MaDaiLy);
                    if (m != null)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            db.DAILies.Remove(m);
                            db.SaveChanges();
                            ds_daily.ItemsSource = db.DAILies.ToList();
                            ds_daily.Items.Refresh();
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn đại lý", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reset();
        }



        private void ds_daily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ds_daily.Items.Count >= 0 && ds_daily.SelectedIndex <= ds_daily.Items.Count - 1)
            {
                var dl = (DAILY)ds_daily.SelectedItem;
                if (dl != null)
                {
                    txt_madaily.Text = dl.MaDaiLy;
                    txt_mahopdong.Text = dl.MaHopDong;
                    dp_ngaylap.Text = dl.NgayLap.ToString();
                    dp_ngaysinh.Text = dl.NgaySinh.ToString();
                    txt_cmnd.Text = dl.CMND;
                    txt_cap.Text = dl.CapDaiLy;
                    txt_hotenchudaily.Text = dl.HoTenChuDaiLy;
                    txt_tendaily.Text = dl.TenDaiLy;
                    txt_noidung.Text = dl.NoiDung;
                    using (var db = new QUANLYCACDAILYEntities())
                    {
                        var l = db.DINHMUCs.Find(dl.MaDinhMuc);
                        cb_madinhmuc.SelectedIndex = db.DINHMUCs.ToList().IndexOf(l);
                    }
                }

            }
        }

        private void button_search_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (txtsearchDaiLy.Text != "")
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.DAILies.ToList().Find(n => n.TenDaiLy == txtsearchDaiLy.Text);
                    try
                    {
                        
                            var query = (from n in db.DAILies
                                         join k in db.DINHMUCs on n.MaDinhMuc equals k.MaDinhMuc
                                         where n.TenDaiLy == txtsearchDaiLy.Text
                                         select n).ToList();
                            ds_daily.ItemsSource = query;
                            ds_daily.Items.Refresh();
                            txtsearchDaiLy.Text = "";
                        
                    }
                    catch
                    {
                        MessageBox.Show("Không thể tìm được", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtsearchDaiLy.Text = "";
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
                var k = (from n in db.DAILies
                         join m in db.DINHMUCs on n.MaDinhMuc equals m.MaDinhMuc
                         select n).ToList();
                ds_daily.ItemsSource = k;
                ds_daily.Items.Refresh();
            }
        }
    }
}
