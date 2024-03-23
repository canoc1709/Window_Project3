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

namespace Test
{
    /// <summary>
    /// Interaction logic for FDangki.xaml
    /// </summary>
    public partial class FDangki : Window
    {
        UngvienDAO ungvienDAO;
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
                ungvienDAO = new UngvienDAO();
                ungvienDAO.Themtaikhoan(txtUsername.Text, txtPassword.Text, txtMail.Text);
            }
            FDangnhap dangnhap = new FDangnhap();
            dangnhap.Show();
            this.Close();
        }

        private void QuayLai_Click(object sender, RoutedEventArgs e)
        {
            FTrangChu main = new FTrangChu();
            main.Show();
            this.Close();
        }
    }
}