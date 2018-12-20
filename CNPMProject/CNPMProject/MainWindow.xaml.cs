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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CNPMProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_DaiLy_Click(object sender, RoutedEventArgs e)
        {
            Daily daily = new Daily();
            daily.ShowDialog();
        }

        private void button_hanghoa_Click(object sender, RoutedEventArgs e)
        {
            Hanghoa hh = new Hanghoa();
            hh.ShowDialog();
        }

        private void button_hoadon_Click(object sender, RoutedEventArgs e)
        {
            Hoadon hd = new Hoadon();
            hd.ShowDialog();
        }

        private void button_uudai_Click(object sender, RoutedEventArgs e)
        {
            Uudai ud = new Uudai();
            ud.ShowDialog();
        }

        private void button_phieuthu_Click(object sender, RoutedEventArgs e)
        {
            Phieuthu pt = new Phieuthu();
            pt.ShowDialog();
        }

        private void button_donhang_Click(object sender, RoutedEventArgs e)
        {
            DonHang dh = new DonHang();
            dh.ShowDialog();
        }
        private void button_closewindow_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                Close();
            }
        }
    }
}
