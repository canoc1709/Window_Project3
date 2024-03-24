using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for FDangnhap.xaml
    /// </summary>
    public partial class FDangnhap : Window
    {
        UngvienDAO ungvienDAO = new UngvienDAO();
        public FDangnhap()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FTrangChu main = new FTrangChu();
            this.Close();
            main.Show();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        private void Grid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FDangki dangki = new FDangki();
            dangki.Show();
            this.Close();
        }
        private void Dangnhap_click(object sender, RoutedEventArgs e)
        {
            if (Check_Ungvien.IsChecked == true)
            {
                DataTable dt = new DataTable();
                dt = ungvienDAO.Loadthongtin(txtUsername.Text, txtPassword.Text);
                UngVien ungvien = new UngVien();
                foreach (DataRow dr in dt.Rows)
                {
                    ungvien = new UngVien(dr);
                }
                if (ungvien.ID != 0)
                {
                    FNhanVien trangchu = new FNhanVien(ungvien);
                    trangchu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("no acc");
                }
            }
            else if(Check_Nhanvien.IsChecked == true)
            {
                    FVP_CongTy vP_CongTy = new FVP_CongTy();
                    vP_CongTy.Show();
                    this.Close();
            }
            else
            {
                MessageBox.Show("Vui long chon role");
            }

        }
    }
}
