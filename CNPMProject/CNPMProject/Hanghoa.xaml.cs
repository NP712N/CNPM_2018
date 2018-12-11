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
        }

        private void button_closewindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            ThemHH add = new ThemHH();
            add.ShowDialog();
        }

        private void button_update_Click(object sender, RoutedEventArgs e)
        {
            SuaHH update = new SuaHH();
            update.ShowDialog();
        }
    }
}
