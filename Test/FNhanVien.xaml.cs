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
    /// Interaction logic for FNhanVien.xaml
    /// </summary>
    public partial class FNhanVien : Window
    {
        UngvienDAO ungvienDAO = new UngvienDAO();
        UngVien ungvien = new UngVien();
        public FNhanVien()
        {
            InitializeComponent();
        }
        public FNhanVien(UngVien ungvien)
        {
            this.ungvien = ungvien;
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FDangnhap dangnhap = new FDangnhap();
            dangnhap.Show();
            this.Close();
        }
        private void FNhanVien_Load(object sender ,RoutedEventArgs e)
        {
                ucThongtin.TxtTen.Text = ungvien.Name;
                ucThongtin.TxtGioitinh.Text = ungvien.Sex;
                ucThongtin.TxtNgaysinh.Text = ungvien.Birthdate.ToString();
                ucThongtin.TxtSdt.Text = ungvien.Phonenumber;
                ucThongtin.TxtKinhnghiem.Text = ungvien.Experience;
                ucThongtin.TxtMail.Text = ungvien.Mail;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FNhanVien trangchu = new FNhanVien();
            trangchu.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FTimKiemCongViec timKiemCongViec = new FTimKiemCongViec();
            timKiemCongViec.Show();
            this.Close();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void HoSoDangKi_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
