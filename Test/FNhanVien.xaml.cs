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
        private void FNhanVien_Load(object sender, RoutedEventArgs e)
        {
            ucThongtin.BtnSua.Click += btnSua_Click;
            ucThongtin.BtnLuu.Click += btnLuu_Click;
        }
        private void load()
        {
            ucThongtin.TxtTen.Text = ungvien.Name;
            ucThongtin.TxtGioitinh.Text = ungvien.Sex;
            ucThongtin.TxtNgaysinh.Text = ungvien.Birthdate.ToString("dd/MM/yyyy");
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
            FTimKiemCongViec timKiemCongViec = new FTimKiemCongViec(ungvien);
            timKiemCongViec.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            ucThongtin.TxtTen.IsReadOnly = false;
            ucThongtin.TxtGioitinh.IsReadOnly = false;
            ucThongtin.TxtNgaysinh.IsReadOnly = false;
            ucThongtin.TxtSdt.IsReadOnly = false;
            ucThongtin.TxtKinhnghiem.IsReadOnly = false;
            ucThongtin.TxtMail.IsReadOnly = false;
            ucThongtin.DtpNgaysinh.SelectedDate = DateTime.Now;
            ucThongtin.DtpNgaysinh.Visibility = Visibility.Visible;
        }
        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)ungvien.ID;
            ungvien = new UngVien(id, ucThongtin.TxtTen.Text, ucThongtin.TxtGioitinh.Text, ucThongtin.TxtSdt.Text,
                ucThongtin.TxtMail.Text, ucThongtin.DtpNgaysinh.SelectedDate.Value, ucThongtin.TxtKinhnghiem.Text);
            ungvienDAO.Sua(ungvien);
            ucThongtin.TxtTen.IsReadOnly = true;
            ucThongtin.TxtGioitinh.IsReadOnly = true;
            ucThongtin.TxtNgaysinh.IsReadOnly = true;
            ucThongtin.TxtSdt.IsReadOnly = true;
            ucThongtin.TxtKinhnghiem.IsReadOnly = true;
            ucThongtin.TxtMail.IsReadOnly = true;
            ucThongtin.DtpNgaysinh.Visibility = Visibility.Hidden;
            load();
        }
    }
}
