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
    /// Interaction logic for Uudai.xaml
    /// </summary>
    public partial class Uudai : Window
    {
        public Uudai()
        {
            InitializeComponent();
            using (var db = new QUANLYCACDAILYEntities())
            {
                ds_uudai.ItemsSource = db.UUDAIs.ToList();
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
            txt_mauudai.Text = "";
            txt_tenuudai.Text = "";
            dp_ngaybatdau.Text = "";
            dp_ngayketthuc.Text = "";
            txt_loai.Text = "";
            txt_phantram.Text = "";
        }
        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QUANLYCACDAILYEntities())
            {
                try
                {
                    if (txt_mauudai.Text == "" || txt_tenuudai.Text == "" || dp_ngaybatdau.Text == "" || dp_ngayketthuc.Text == "" || txt_loai.Text == "" || txt_phantram.Text == "")
                    {
                        MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        var m = new UUDAI();
                        if (txt_mauudai.Text == m.MaUuDai)
                        {
                            MessageBox.Show("Nhập mã khác", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                        else
                        {
                            var temp = new UUDAI();
                            if (temp != null)
                            {
                                temp.MaUuDai = txt_mauudai.Text;
                                temp.TenUuDai = txt_tenuudai.Text;
                                temp.NgayBatDau = DateTime.Parse(dp_ngaybatdau.Text);
                                temp.NgayKetThuc = DateTime.Parse(dp_ngayketthuc.Text);
                                temp.CapDaiLy = txt_loai.Text;
                                temp.PhanTram = int.Parse(txt_phantram.Text);
                                db.UUDAIs.Add(temp);
                                db.SaveChanges();
                                ds_uudai.ItemsSource = db.PHIEUTHUs.ToList();
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm ưu đãi không thành công", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            Reset();
        }

        private void button_update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_mauudai.Text != "")
                {
                    using (var db = new QUANLYCACDAILYEntities())
                    {


                        if (txt_mauudai.Text == "" || txt_tenuudai.Text == "" || dp_ngaybatdau.Text == "" || dp_ngayketthuc.Text == "" || txt_loai.Text == "" || txt_phantram.Text == "")
                        {
                            MessageBox.Show("Nhập thông tin đầy đủ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else

                        {
                            var m = db.UUDAIs.ToList().Find(n => n.MaUuDai == txt_mauudai.Text);
                            m.TenUuDai = txt_tenuudai.Text;
                            m.NgayBatDau = DateTime.Parse(dp_ngaybatdau.Text);
                            m.NgayKetThuc = DateTime.Parse(dp_ngayketthuc.Text);
                            m.CapDaiLy = txt_loai.Text;
                            m.PhanTram = int.Parse(txt_phantram.Text);
                            db.SaveChanges();
                            ds_uudai.ItemsSource = db.UUDAIs.ToList();
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

        private void ds_uudai_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ds_uudai.Items.Count >= 0 && ds_uudai.SelectedIndex <= ds_uudai.Items.Count - 1)
            {
                var dl = (UUDAI)ds_uudai.SelectedItem;
                if (dl != null)
                {
                    txt_mauudai.Text = dl.MaUuDai;
                    txt_tenuudai.Text = dl.TenUuDai;
                    dp_ngaybatdau.Text = dl.NgayBatDau.ToString();
                    dp_ngayketthuc.Text = dl.NgayKetThuc.ToString();
                    txt_loai.Text = dl.CapDaiLy;
                    txt_phantram.Text = dl.PhanTram.ToString();
                }

            }
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.UUDAIs.ToList().Find(n => n.MaUuDai == ((UUDAI)ds_uudai.SelectedItem).MaUuDai);
                    if (m != null)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            db.UUDAIs.Remove(m);
                            db.SaveChanges();
                            ds_uudai.ItemsSource = db.UUDAIs.ToList();
                            ds_uudai.Items.Refresh();
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
                var k = (from n in db.UUDAIs
                         select n).ToList();
                ds_uudai.ItemsSource = k;
                ds_uudai.Items.Refresh();
            }
        }

        private void button_search_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (txt_search.Text != "")
            {
                using (var db = new QUANLYCACDAILYEntities())
                {
                    var m = db.UUDAIs.ToList().Find(n => n.TenUuDai == txt_search.Text);

                    try
                    {
                        var query = (from n in db.UUDAIs
                                     where n.TenUuDai == txt_search.Text
                                     select n).ToList();
                        ds_uudai.ItemsSource = query;
                        ds_uudai.Items.Refresh();
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
