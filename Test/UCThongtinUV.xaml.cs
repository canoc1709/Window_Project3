using Microsoft.Win32;
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
    /// Interaction logic for UCThongtinUV.xaml
    /// </summary>
    public partial class UCThongtinUV : UserControl
    {
        UngVien ungvien = new UngVien();
        UngvienDAO ungvienDAO = new UngvienDAO();
        public UCThongtinUV()
        {
            InitializeComponent();
        }
        public UCThongtinUV(UngVien ungvien)
        {
            this.ungvien = ungvien;
            InitializeComponent();
        }
        private void UCThongtinUV_Load(object sender, RoutedEventArgs e)
        {
            load();
        }
        private void load()
        {
            txtHoTen_Dangky.Text = ungvien.Name;
            txtGioiTinh.Text = ungvien.Sex;
            txtNamSinh_Dangky.Text = ungvien.Birthdate.ToString("dd/MM/yyyy");
            txtSDT.Text = ungvien.Phonenumber;
            txtKinhNghiem.Text = ungvien.Experience;
            txtEmail_Dangky.Text = ungvien.Mail;
        }
        private void TaiAnh_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                                    "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                    "Portable Network Graphic (*.png)|*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                // Tạo một BitmapImage và đặt nó làm nguồn cho Image control.
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                imgNhanVien.Source = bitmapImage;
            }
        }
        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            txtHoTen_Dangky.IsReadOnly = false;
            txtGioiTinh.IsReadOnly = false;
            txtSDT.IsReadOnly = false;
            txtKinhNghiem.IsReadOnly = false;
            txtEmail_Dangky.IsReadOnly = false;
            dtpNgaysinh.SelectedDate = DateTime.Now;
            dtpNgaysinh.Visibility = Visibility.Visible;
        }
        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)ungvien.ID;
            ungvien = new UngVien(id, txtHoTen_Dangky.Text, txtGioiTinh.Text, txtSDT.Text,
                txtEmail_Dangky.Text, dtpNgaysinh.SelectedDate.Value,txtKinhNghiem.Text);
            ungvienDAO.Sua(ungvien);
            txtHoTen_Dangky.IsReadOnly = true;
            txtGioiTinh.IsReadOnly = true;
            txtSDT.IsReadOnly = true;
            txtKinhNghiem.IsReadOnly = true;
            txtEmail_Dangky.IsReadOnly = true;
            dtpNgaysinh.Visibility = Visibility.Hidden;
            load();
        }
    }
}
