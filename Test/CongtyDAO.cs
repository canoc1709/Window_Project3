using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class CongtyDAO
    {
        Connection connection  = new Connection();
        public void Themtaikhoan(string username, string password, string mail)
        {
            string s = string.Format("insert into Congty(TenCT, Sdt, Mail, Diachi, username, password) " +
                "values('','0000000000','{0}','','{1}','{2}')", mail, username.ToLower(), password);
            connection.ThucThi(s);
        }
        public DataTable LoadCongty(string username, string password)
        {
            DataTable dt = new DataTable();
            string s = string.Format("select * from Congty where username = '{0}' and password = '{1}'", username, password);
            dt = connection.load(s);
            return dt;
        }
        public void Sua(Congty congty)
        {
            string s = string.Format("update Congty set TenCT = '{0}', Sdt = '{1}', Mail = '{2}', Diachi = '{3}' where ID = {4}", 
                congty.Name, congty.Phonenumber, congty.Mail, congty.Address, congty.ID);
            connection.ThucThi(s);
        }
    }
}
