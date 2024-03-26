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
    /// Interaction logic for FHoSoDangKi.xaml
    /// </summary>
    public partial class FHoSoDangKi : UserControl
    {
        public TextBox TxtTen
        {
            get { return txtHoTen_Dangky; }
            set { txtHoTen_Dangky = value; }
        }
        public TextBox TxtGioitinh
        {
            get { return txtGioiTinh; }
            set { txtGioiTinh = value; }
        }
        public TextBox TxtSdt
        {
            get { return txtSDT; }
            set { txtSDT = value; }
        }
        public TextBox TxtMail
        {
            get { return txtEmail_Dangky; }
            set { txtEmail_Dangky = value; }
        }
        public TextBox TxtNgaysinh
        {
            get { return txtNamSinh_Dangky; }
            set { txtNamSinh_Dangky = value; }
        }
        public TextBox TxtKinhnghiem
        {
            get { return txtKinhNghiem; }
            set { txtKinhNghiem = value; }
        }
        public DatePicker DtpNgaysinh
        {
            get { return dtpNgaysinh; }
            set { dtpNgaysinh = value; }
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
        public FHoSoDangKi()
        {
            InitializeComponent();
        }
    }
}
