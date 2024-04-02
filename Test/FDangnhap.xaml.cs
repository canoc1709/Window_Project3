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
        CongtyDAO congtyDAO = new CongtyDAO();
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
            DataTable dt = new DataTable();
            if (Check_Ungvien.IsChecked == true)
            {
                dt = ungvienDAO.Loadthongtin(txtUsername.Text, PB_Password.Password);
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
                    MessageBox.Show("Không tồn tại tài khoản!");
                }
            }
            else if(Check_Nhanvien.IsChecked == true)
            {
                dt = congtyDAO.LoadCongty(txtUsername.Text, PB_Password.Password);
                Congty congty = new Congty();
                foreach(DataRow dr in dt.Rows)
                {
                    congty = new Congty(dr);
                }
                if(congty.ID != 0)
                {
                    FVP_CongTy vP_CongTy = new FVP_CongTy(congty);
                    vP_CongTy.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tồn tại tài khoản trên!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ!");
            }

        }

        private void txtUsername_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.Foreground = base.Foreground;
            }
        }

        

  
        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
