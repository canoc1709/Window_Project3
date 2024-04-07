﻿using System;
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
        //string strcon = @"Data Source=DESKTOP-K8C76HP;Initial Catalog=QLCongviec;Integrated Security=True;Encrypt=False";
        string strcon = "Data Source=LAPTOP-GPLGAEAL\\YORDLEYUU;Initial Catalog=Test;Integrated Security=True";
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
        public DataTable load(string s)
        {
            DataTable dt = new DataTable();
            try
            {
                conn = new SqlConnection(strcon);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(s, conn);
                adapter.Fill(dt);
                return dt;
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
