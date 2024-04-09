using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for UCCongViec.xaml
    /// </summary>
    public partial class UCCongViec : UserControl
    {
        Congviec congviec = new Congviec();
        UngVien ungvien = new UngVien();
        Congty congty = new Congty();
        public Button BtnChitiet
        {
            get { return btnChitiet; }
            set { btnChitiet = value; }
        }
        public UCCongViec()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public UCCongViec(Congviec congviec, UngVien ungvien)
        {
            this.congviec = congviec;
            this.ungvien = ungvien;
            InitializeComponent();
        }
        public UCCongViec(Congviec congviec, Congty congty)
        {
            this.congviec = congviec;
            this.congty = congty;
            InitializeComponent();
        }
        public UCCongViec(Congviec congviec)
        {
            this.congviec = congviec;
            InitializeComponent();
        }
        private void UCCongViec_Load(object sender, RoutedEventArgs e)
        {
            load();
            if (ungvien.ID == 0)
                btnChitiet.Click += btnChitiet_Click1;
            if (congty.ID == 0)
                btnChitiet.Click += btnChitiet_Click2;
        }
        private void load()
        {
            lblCapbac.Content += congviec.Capbac;
            lblTencty.Content += congviec.Tencty;
            lblLuong.Content += congviec.Luong.ToString();
            lblNganhnghe.Content += congviec.Nganhnghe;
        }
        private void btnChitiet_Click1(object sender, RoutedEventArgs e)
        {
            FChitietcongviec chitietcongviec = new FChitietcongviec(congviec, congty);
            chitietcongviec.ShowDialog();
            if (chitietcongviec.DialogResult.HasValue && chitietcongviec.DialogResult.Value)
            {
                congviec = chitietcongviec.CongViec;
                load();
            }
        }
        private void btnChitiet_Click2(object sender, RoutedEventArgs e)
        {
            FChitietcongviec chitietcongviec = new FChitietcongviec(congviec, ungvien);
            chitietcongviec.Show();
        }
    }
}
