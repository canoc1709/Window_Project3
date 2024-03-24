using System;
using System.Collections.Generic;
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
    }
}
