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

namespace Test
{
    /// <summary>
    /// Interaction logic for FTimKiemCongViec.xaml
    /// </summary>
    public partial class FTimKiemCongViec : Window
    {
        public FTimKiemCongViec()
        {
            InitializeComponent();
        }

        private void TextBlock_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FNhanVien trangchu = new FNhanVien();
            trangchu.Show();
            this.Close();
        }
    }
}
