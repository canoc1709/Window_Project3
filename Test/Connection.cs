using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
    internal class Connection
    {
        // string strcon = @"Data Source=DESKTOP-K8C76HP;Initial Catalog=QLCongviec;Integrated Security=True;Encrypt=False";
        string strcon = "Data Source=LAPTOP-GPLGAEAL\\YORDLEYUU;Initial Catalog=WindowForm;Integrated Security=True";
        SqlConnection conn = null;
        public void ThucThi(string s)
        {
            try
            {
                conn = new SqlConnection(strcon);
                conn.Open();
                SqlCommand cmd = new SqlCommand(s,conn);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public UngVien load(string s)
        {
            UngVien ungvien = new UngVien();
            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand(); 
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {

                }
                return ungvien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}
