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
        public UCCongViec(Congviec congviec)
        {
            this.congviec = congviec;
            InitializeComponent();
        }
        private void UCCongViec_Load(object sender, RoutedEventArgs e)
        {
            lblChucvu.Text += congviec.Chucvu;
            lblLuong.Text += congviec.Luong.ToString();
            lblTencty.Text += congviec.Tencty;
        }
    }
}
