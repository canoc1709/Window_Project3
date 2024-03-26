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

namespace Test
{
    /// <summary>
    /// Interaction logic for FTrangChu.xaml
    /// </summary>
    public partial class FTrangChu : Window
    {
        public FTrangChu()
        {
            InitializeComponent();
        }
        private void Grid_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void DangNhap_Click(object sender, RoutedEventArgs e)
        {
            FDangnhap dangnhap = new FDangnhap();
            this.Close();
            dangnhap.Show();
        }

        private void DangKy_Click(object sender, RoutedEventArgs e)
        {
            FDangki dangki = new FDangki();
            this.Close();
            dangki.Show();
        }
        private void DenTrangChu_Click(object sender, RoutedEventArgs e)                                                                                     
        {
            FTrangChu main = new FTrangChu();
            main.Show();
            this.Close();
        }

        private void BtnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
