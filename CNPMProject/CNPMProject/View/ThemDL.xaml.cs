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
    /// Interaction logic for ThemDL.xaml
    /// </summary>
    public partial class ThemDL : Window
    {
        public ThemDL()
        {
            InitializeComponent();
        }


        private void button_closewindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
