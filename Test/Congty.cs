using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
    public class Congty
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string phonenumber;

		public string Phonenumber
		{
			get { return phonenumber; }
			set { phonenumber = value; }
		}
		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}
		private string mail;

		public string Mail
		{
			get { return mail; }
			set { mail = value; }
		}

		public Congty() { }
		public Congty(DataRow dr)
		{
			ID = (int)dr[0];
			Name = (string)dr[1];
			Phonenumber = (string)dr[2];
			Mail = (string)dr[3];
			Address = (string)dr[4];
		}
		public Congty(int id, string name, string phonenumber, string address, string mail)
		{
			ID = id;
			Name = name;
			Phonenumber = phonenumber;
			Address = address;
			Mail = mail;
		}
		public bool Checknull(object myObject)
		{
            foreach (PropertyInfo pi in myObject.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(myObject);
                    if (string.IsNullOrEmpty(value))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool Checkmail()
        {
            return Regex.IsMatch(mail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
    }
}
