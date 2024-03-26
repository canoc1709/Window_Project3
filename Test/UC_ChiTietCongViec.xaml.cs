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
    public partial class UC_ChiTietCongViec : UserControl
    {
        public TextBox TxtTencty
        {
            get { return txtTencty; }
            set { txtTencty = value; }
        }
        public TextBox TxtLuong
        {
            get { return txtLuong; }
            set { txtLuong = value; }
        }
        public TextBox TxtChucvu
        {
            get { return txtChucvu; }
            set { txtChucvu = value; }
        }
        public TextBox TxtPhucloi
        {
            get { return txtPhucloi; }
            set { txtPhucloi = value; }
        }
        public TextBox TxtMotacv
        {
            get { return txtMotacv; }
            set { txtMotacv = value; }
        }
        public TextBox TxtYeucau
        {
            get { return txtYeucau; }
            set { txtYeucau = value; }
        }
        public Button BtnDangki
        {
            get { return btnDangki; }
            set { btnDangki = value; }
        }
        public Button BtnXoa
        {
            get { return btnXoa; }
            set { btnXoa = value; }
        }
        public Button BtnSua
        {
            get { return btnSua; }
            set { btnSua = value; }
        }
        public Button BtnLuu
        {
            get { return btnLuu; }
            set { btnLuu = value; }
        }
        public UC_ChiTietCongViec()
        {
            InitializeComponent();
        }
    }
}
