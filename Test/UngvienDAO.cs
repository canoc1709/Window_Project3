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
        public void Themtaikhoan(string username, string password, string mail)
        {
            string s = string.Format("insert into Ungvien(Ten, Gioitinh, Ngaysinh, Sdt, Mail,Kinhnghiem, username, password) " +
                "values('','','','0000000000','{0}','','{1}','{2}')", mail, username.ToLower(), password);
            connection.ThucThi(s);
        }
        public DataTable Loadthongtin(string username, string password)
        {
            DataTable dt = new DataTable();
            string s = string.Format("select * from Ungvien where username = '{0}' and password = '{1}'", username, password);
            dt = connection.load(s);
            return dt;
        }
        public void Sua(UngVien ungvien)
        {
            string s = string.Format("update Ungvien set Ten = '{0}', Gioitinh = '{1}', Ngaysinh = '{2}', Sdt = '{3}', Mail = '{4}', Kinhnghiem = '{5}' where ID = {6}",
                ungvien.Name, ungvien.Sex, ungvien.Birthdate, ungvien.Phonenumber, ungvien.Mail, ungvien.Experience, ungvien.ID);
            connection.ThucThi(s);
        }
    }
}
