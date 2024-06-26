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
    /// Interaction logic for FChitietcongviec.xaml
    /// </summary>
    public partial class FChitietcongviec : Window
    {
        UngVien ungvien = new UngVien();
        Congty congty = new Congty();
        Congviec congviec = new Congviec();
        CongviecDAO congviecDAO = new CongviecDAO();
        public Congviec CongViec
        {
            get { return congviec; }
            set { congviec = value; }
        }
        public Button BtnExit
        {
            get { return btnExit; }
            set { btnExit = value; }
        }
        public FChitietcongviec()
        {
            InitializeComponent();
        }
        public FChitietcongviec(Congviec congviec, UngVien ungvien)
        {
            this.congviec = congviec;
            this.ungvien = ungvien;
            InitializeComponent();
        }
        public FChitietcongviec(Congviec congviec, Congty congty)
        {
            this.congviec = congviec;
            this.congty = congty;
            InitializeComponent();
        }
        private void FChitietcongviec_Load(object sender, RoutedEventArgs e)
        {
            load();
            if (congty.ID != 0)
            {
                btnDangki.Visibility = Visibility.Hidden;
            }
            if (ungvien.ID != 0)
            {
                btnSua.Visibility = Visibility.Hidden;
                btnXoa.Visibility = Visibility.Hidden;
                btnLuu.Visibility = Visibility.Hidden;
            }
        }
        private void load()
        {
            txtTencty.Text += congviec.Tencty;
            txtNganhnghe.Text += congviec.Nganhnghe;
            txtCapbac.Text += congviec.Capbac;
            txtLuong.Text += congviec.Luong.ToString();
            txtPhucloi.Text += congviec.Phucloi;
            txtYeucau.Text += congviec.Phucloi;
            txtMotacv.Text += congviec.Motacv;
        }
        private void btnDangki_Click(object sender, RoutedEventArgs e)
        {
            congviecDAO.Dangki(congviec.ID, ungvien.ID);
        }
        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            txtYeucau.IsReadOnly = false;
            txtPhucloi.IsReadOnly = false;
            txtLuong.IsReadOnly = false;
            txtMotacv.IsReadOnly = false;
            txtCapbac.IsReadOnly = false;
            txtNganhnghe.IsReadOnly = false;
        }
        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)congviec.ID;
            congviec = new Congviec(id, int.Parse(txtLuong.Text), txtMotacv.Text, txtYeucau.Text, txtPhucloi.Text,
                txtNganhnghe.Text, txtCapbac.Text, txtTencty.Text);
            congviecDAO.Sua(congviec);
            txtYeucau.IsReadOnly = true;
            txtPhucloi.IsReadOnly = true;
            txtLuong.IsReadOnly = true;
            txtMotacv.IsReadOnly = true;
            txtNganhnghe.IsReadOnly = true;
            txtCapbac.IsReadOnly = true;
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
