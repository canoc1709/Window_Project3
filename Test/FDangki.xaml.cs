﻿using System;
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
using System.Windows.Controls;
using System.Windows.Media.Media3D;
namespace Test
{
    /// <summary>
    /// Interaction logic for FDangki.xaml
    /// </summary>
    public partial class FDangki : Window
    {
        UngvienDAO ungvienDAO = new UngvienDAO();
        CongtyDAO congtyDAO = new CongtyDAO();
        public FDangki()
        {
            InitializeComponent();
        }
        private void Grid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void DangKy_Click(object sender, RoutedEventArgs e)
        {
            if(rbtCheck_Ungvien.IsChecked == true)
            {
                ungvienDAO.Themtaikhoan(txtUsername.Text, txtPassword.Text, txtMail.Text);
                FDangnhap dangnhap = new FDangnhap();
                dangnhap.Show();
                this.Close();
            }
            else if(rbtCheckbox_Nhanvien.IsChecked == true)
            {
                congtyDAO.Themtaikhoan(txtUsername.Text, txtPassword.Text, txtMail.Text);
                FDangnhap dangnhap = new FDangnhap();
                dangnhap.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui long chon role");
            }

        }

        private void QuayLai_Click(object sender, RoutedEventArgs e)
        {
            FTrangChu main = new FTrangChu();
            main.Show();
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
       
           
        }

        private void txtUsername_MouseEnter(object sender, MouseEventArgs e)
        {
            if(txtUsername.Text=="Username")
            {
                txtUsername.Text = "";
                txtUsername.Foreground=base.Foreground;
            }
        }

        private void txtPassword_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.Foreground = base.Foreground;
            }
        }

        

        private void txtMail_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtMail.Text == "Email")
            {
                txtMail.Text = "";
                txtMail.Foreground = base.Foreground;
            }
        }

        private void Họ_và_tên_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtPassword1.Text == "Password")
            {
                txtPassword1.Text = "";
                txtPassword1.Foreground = base.Foreground;
            }
        }

        private void txtUsername_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                
            }
        }

        private void txtPassword_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";

            }
        }

        private void txtPassword1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txtMail_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void txtPassword1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtPassword1.Text == "")
            {
                txtPassword1.Text = "Password";

            }
        }

        private void txtMail_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Email";

            }
        }
    }
}
