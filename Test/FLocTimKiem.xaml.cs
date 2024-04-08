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
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.Content = NganhNghe[i];
                CB_Job.Items.Add(cbItem);
            }

            string[] DiaDiem = {"An Giang", "Bà rịa-Vũng Tàu", "Bạc Liêu", "Bắc Giang", "Bắc Kạn", "Bắc Ninh", "Bến Tre", "Bình Dương", "Bình Định",
            "Bình Phước", "Bình Thuận", "Cà Mau", "Cao Bằng", "Cần Thơ", "Đà Nẵng", "Đắk Lắk", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai",
                "Hà Giang", "Hà Nam", "Hà Nội", "Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hậu Giang", "Hòa Bình", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum",
            "Lai Châu", "Lạng Sơn", "Lào Cai", "Lâm Đồng", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phụ Yên", "Quảng Bình",
            "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế",
            "Tiền Giang", "TP Hồ Chí Minh", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái"};
            for (int i = 0; i < DiaDiem.Length; i++)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.Content = DiaDiem[i];
                CB_Location.Items.Add(cbItem);
            }

            string[] CapBac = { "Thực tập sinh", "Nhân viên", "Quản lý" };
            for (int i = 0; i < CapBac.Length; i++)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.Content = CapBac[i];
                CB_Level.Items.Add(cbItem);
            }

            string[] MucLuong = { "Dưới 5 triệu", "5 - 10 triệu", "10 - 15 triệu", "Trên 15 triệu" };
            for (int i = 0; i < MucLuong.Length; i++)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.Content = MucLuong[i];
                CB_Salary.Items.Add(cbItem);
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

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }


    }
}
