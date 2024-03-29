﻿using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for FTimKiemCongViec.xaml
    /// </summary>
    public partial class FTimKiemCongViec : Window
    {
        CongviecDAO congviecDAO = new CongviecDAO();
        UngVien ungvien = new UngVien();
        Congviec congviec = new Congviec();
        public FTimKiemCongViec()
        {
            InitializeComponent();
        }
        public FTimKiemCongViec(UngVien ungvien)
        {
            this.ungvien = ungvien;
            InitializeComponent();
        }
        private void TextBlock_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void btnTimKiem_Click(object sender,RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = congviecDAO.LoadCongviec();
            foreach(DataRow dr in dt.Rows)
            {
                congviec = new Congviec(dr);
                UCCongViec ucCongViec = new UCCongViec(congviec);
                ucCongViec.BtnChitiet.Click += (na, RoutedEventArgs) =>
                {
                    ChiTietCongViec chitiet = new ChiTietCongViec(congviec, ungvien);
                    chitiet.Show();
                };
                ltvCongviec.Items.Add(ucCongViec);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FNhanVien trangchu = new FNhanVien();
            trangchu.Show();
            this.Close();
        }
        private void button_click(object sender, RoutedEventArgs e, Congviec congviec)
        {
            ChiTietCongViec chitiet = new ChiTietCongViec(congviec, ungvien);
            chitiet.Show();
        }
    }
}
