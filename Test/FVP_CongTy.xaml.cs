using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class FVP_CongTy : Window
    {
        Congty congty = new Congty();
        CongtyDAO congtyDAO = new CongtyDAO();
        Congviec congviec = new Congviec();
        CongviecDAO congviecDAO = new CongviecDAO();
        public FVP_CongTy()
        {
            InitializeComponent();
        }
        public FVP_CongTy(Congty congty)
        {
            this.congty = congty;
            InitializeComponent();
        }
        private void FVP_CongTy_Load(object sender, RoutedEventArgs e)
        {
            txtDiachi.Text = congty.Address;
            txtMail.Text = congty.Mail;
            txtSdt.Text = congty.Phonenumber;
            txtTenCongTy.Text = congty.Name;
            load(congty);
        }
        private void load(Congty congty)
        {
            DataTable dt = new DataTable();
            congviec = new Congviec();
            dt = congviecDAO.LoadCongviec(congty);
            foreach(DataRow dr in dt.Rows)
            {
                congviec = new Congviec(dr);
                UCCongViec ucCongViec = new UCCongViec(congviec);
                ucCongViec.BtnChitiet.Click += (na, RoutedEventArgs) =>
                {
                    ChiTietCongViec chitiet = new ChiTietCongViec(congviec, congty);
                    chitiet.Show();
                };
                ltvCongviec.Items.Add(ucCongViec);
            }
        }
        private void btnDangtuyen_Click(object sender, RoutedEventArgs e)
        {
            congviec = new Congviec(int.Parse(txtLuong.Text),txtMotacv.Text,txtYeucau.Text,txtPhucloi.Text,txtChucvu.Text,txtTenCongTy.Text);
            congviecDAO.Themcongviec(congviec, congty);
            load(congty);
        }
        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            txtTenCongTy.IsReadOnly = false;
            txtDiachi.IsReadOnly = false;
            txtMail.IsReadOnly = false;
            txtSdt.IsReadOnly = false;
        }
        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)congty.ID;
            congty = new Congty(id, txtTenCongTy.Text,txtSdt.Text,txtDiachi.Text,txtMail.Text);
            congtyDAO.Sua(congty);
            txtTenCongTy.IsReadOnly = true;
            txtDiachi.IsReadOnly = true;
            txtMail.IsReadOnly = true;
            txtSdt.IsReadOnly = true;
        }
    }
}
