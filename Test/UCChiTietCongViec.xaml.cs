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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test
{
    /// <summary>
    /// Interaction logic for UC_ChiTietCongViec.xaml
    /// </summary>
    public partial class UCChiTietCongViec : UserControl
    {
        UngVien ungvien = new UngVien();
        Congty congty = new Congty();
        Congviec congviec = new Congviec();
        CongviecDAO congviecDAO = new CongviecDAO();
        public Button BtnExit
        {
            get { return btnExit; }
            set { btnExit = value; }
        }
        public UCChiTietCongViec()
        {
            InitializeComponent();
        }
        public UCChiTietCongViec(Congviec congviec, UngVien ungvien)
        {
            this.congviec = congviec;
            this.ungvien = ungvien;
            InitializeComponent();
        }
        public UCChiTietCongViec(Congviec congviec, Congty congty)
        {
            this.congviec = congviec;
            this.congty = congty;
            InitializeComponent();
        }
        private void UCChiTietCongViec_Load(object sender, RoutedEventArgs e)
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
            txtChucvu.Text += congviec.Chucvu;
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
            txtChucvu.IsReadOnly = false;
        }
        private void BtnLuu_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)congviec.ID;
            congviec = new Congviec(id, int.Parse(txtLuong.Text), txtMotacv.Text, txtYeucau.Text, txtPhucloi.Text,
                txtChucvu.Text, txtTencty.Text);
            congviecDAO.Sua(congviec);
            txtYeucau.IsReadOnly = true;
            txtPhucloi.IsReadOnly = true;
            txtLuong.IsReadOnly = true;
            txtMotacv.IsReadOnly = true;
            txtChucvu.IsReadOnly = true;
        }
    }
}
