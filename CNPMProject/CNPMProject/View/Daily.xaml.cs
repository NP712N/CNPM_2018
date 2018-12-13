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
            
        }

        private void button_closewindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void button_update_Click(object sender, RoutedEventArgs e)
        {
            SuaDL sdl = new SuaDL();
            sdl.ShowDialog();

        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            ThemDL tdl = new ThemDL();
            tdl.ShowDialog();
        }

        private void DaiLy_Loaded(object sender, RoutedEventArgs e)
        {
            CNPMProject.ViewModel.DAILYViewModel dAILYViewModel = new ViewModel.DAILYViewModel();
            dAILYViewModel.LoadDaiLy();
            DaiLyViewControl.DataContext = dAILYViewModel;
        }
    }
}
