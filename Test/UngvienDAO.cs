using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
    internal class UngvienDAO
    {
        Connection connection = new Connection();
        public void Themtaikhoan(string username,string password,string mail)
        {
            string s = string.Format("insert into Ungvien(Ten, Gioitinh, Ngaysinh, Sdt, Mail, username, password) " +
                "values('','','','0000000000','{0}','{1}','{2}')", mail, username.ToLower(), password);
            connection.ThucThi(s);
        }
        public DataTable Loadthongtin(string username, string password)
        {
            DataTable dt = new DataTable();
            string s = string.Format("select * from Ungvien where username = 'quan123' and password = 'quan123'", username, password);
            dt = connection.load(s);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("null");
                return null;
            }
            else
            {
                return dt;
            }
        }
    }
}
