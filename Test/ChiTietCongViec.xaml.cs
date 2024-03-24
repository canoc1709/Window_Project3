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
    /// Interaction logic for ChiTietCongViec.xaml
    /// </summary>
    public partial class ChiTietCongViec : Window
    {
        Congviec congviec = new Congviec();
        UngVien ungvien = new UngVien();
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
        private void ChiTietCongViec_Load(object sender, RoutedEventArgs e)
        {
            ucChitiet.TxtTencty.Text += congviec.Tencty;
            ucChitiet.TxtChucvu.Text += congviec.Chucvu;
            ucChitiet.TxtLuong.Text += congviec.Luong.ToString();
            ucChitiet.TxtPhucloi.Text += congviec.Phucloi;
            ucChitiet.TxtYeucau.Text += congviec.Phucloi;
            ucChitiet.TxtMotacv.Text += congviec.Motacv;
            ucChitiet.BtnDangki.Click += btnDangki_Click;
        }
        private void btnDangki_Click(object sender, RoutedEventArgs e)
        {
            congviecDAO.Dangki(congviec.ID, ungvien.ID);
        }
    }
}
