using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for ChiTietCongViec.xaml
    /// </summary>
    public partial class ChiTietCongViec : Window
    {
        UngVien ungvien = new UngVien();
        Congty congty = new Congty();
        Congviec congviec = new Congviec();
        CongviecDAO congviecDAO = new CongviecDAO();
        public ChiTietCongViec()
        {
            InitializeComponent();
        }
        public ChiTietCongViec(Congviec congviec, UngVien ungvien)
        {
            this.congviec = congviec;
            this.ungvien = ungvien;
            InitializeComponent();
        }
        public ChiTietCongViec(Congviec congviec, Congty congty)
        {
            this.congviec = congviec;
            this.congty = congty;
            InitializeComponent();
        }
        private void ChiTietCongViec_Load(object sender, RoutedEventArgs e)
        {
            load();
            ucChitiet.BtnDangki.Click += btnDangki_Click;
            ucChitiet.btnSua.Click += btnSua_Click;
            ucChitiet.BtnLuu.Click += BtnLuu_Click;
            if (congty.ID != 0)
            {
                ucChitiet.BtnDangki.Visibility = Visibility.Hidden;
            }
            if (ungvien.ID != 0)
            {
                ucChitiet.BtnSua.Visibility = Visibility.Hidden;
                ucChitiet.BtnXoa.Visibility = Visibility.Hidden;
                ucChitiet.BtnLuu.Visibility = Visibility.Hidden;
            }
        }
        private void load()
        {
            ucChitiet.TxtTencty.Text += congviec.Tencty;
            ucChitiet.TxtChucvu.Text += congviec.Chucvu;
            ucChitiet.TxtLuong.Text += congviec.Luong.ToString();
            ucChitiet.TxtPhucloi.Text += congviec.Phucloi;
            ucChitiet.TxtYeucau.Text += congviec.Phucloi;
            ucChitiet.TxtMotacv.Text += congviec.Motacv;
        }
        private void btnDangki_Click(object sender, RoutedEventArgs e)
        {
            congviecDAO.Dangki(congviec.ID, ungvien.ID);
        }
        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            ucChitiet.txtYeucau.IsReadOnly = false;
            ucChitiet.txtPhucloi.IsReadOnly = false;
            ucChitiet.txtLuong.IsReadOnly = false;
            ucChitiet.txtMotacv.IsReadOnly = false;
            ucChitiet.txtChucvu.IsReadOnly = false;
        }
        private void BtnLuu_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)congviec.ID;
            congviec = new Congviec(id, int.Parse(ucChitiet.txtLuong.Text), ucChitiet.TxtMotacv.Text, ucChitiet.TxtYeucau.Text, ucChitiet.TxtPhucloi.Text,
                ucChitiet.TxtChucvu.Text, ucChitiet.TxtTencty.Text);
            congviecDAO.Sua(congviec);
            ucChitiet.txtYeucau.IsReadOnly = true;
            ucChitiet.txtPhucloi.IsReadOnly = true;
            ucChitiet.txtLuong.IsReadOnly = true;
            ucChitiet.txtMotacv.IsReadOnly = true;
            ucChitiet.txtChucvu.IsReadOnly = true;
        }
    }
}
