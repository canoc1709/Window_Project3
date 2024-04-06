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
using static MaterialDesignThemes.Wpf.Theme;

namespace Test
{
    /// <summary>
    /// Interaction logic for FLocTimKiem.xaml
    /// </summary>
    public partial class FLocTimKiem : Window
    {
        public FLocTimKiem()
        {
            InitializeComponent();
            Load();
        }

        private void btnok_Loc_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Load()
        {
            string[] NganhNghe = { "Bán Lẻ/Tiêu Dùng", "Bảo Hiểm","Bất Động Sản", "Dược", "Dịch Vụ Khách Hàng", "Dịch Vụ Ăn Uống", "Kế Toán/Kiểm Toán",
            "Kỹ Thuật", "Nhà Hàng - Khách Sạn"};
            for (int i = 0; i < NganhNghe.Length; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Width = 150;
                checkBox.Height = 50;
                checkBox.HorizontalContentAlignment = HorizontalAlignment.Left;
                checkBox.VerticalContentAlignment = VerticalAlignment.Center;
                checkBox.VerticalAlignment = VerticalAlignment.Center;
                checkBox.Content = NganhNghe[i];
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Height = 50;
                listViewItem.Content = checkBox;
                LV_NganhNghe.Items.Add(listViewItem);
            }

        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnquit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
