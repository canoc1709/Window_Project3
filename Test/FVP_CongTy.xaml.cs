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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class FVP_CongTy : Window
    {
        Congty congty = new Congty();
        CongtyDAO congtyDAO = new CongtyDAO();
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
            
        }
    }
}
