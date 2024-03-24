using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    public class UngVien
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
		private string mail;

		public string Mail
		{
			get { return mail; }
			set { mail = value; }
		}
		private string experience;

		public string Experience
        {
			get { return experience; }
			set { experience = value; }
		}
		private DateTime birthdate;

		public DateTime Birthdate
        {
			get { return birthdate; }
			set { birthdate = value; }
		}
		private string sex;

		public string Sex
		{
			get { return sex; }
			set { sex = value; }
		}

		public UngVien() { }
		public UngVien(DataRow dr)
		{
			ID = (int)dr[0];
			Name = (string)dr[1];
			Sex = (string)dr[2];
			Birthdate = (DateTime)dr[3];
			Phonenumber = (string)dr[4];
			Mail = (string)dr[5];
		}
		public UngVien(int id,string name,string sex,string phonenumber,string mail, DateTime birthdate)
		{
			ID = id;
			Name = name;
			Sex = sex;
			Phonenumber = phonenumber;
			Mail = mail;
			Birthdate = birthdate;
		}
		public bool Checknull(object myObject)
		{
			foreach(PropertyInfo pi in myObject.GetType().GetProperties())
			{
				if(pi.PropertyType == typeof(string))
				{
					string value = (string)pi.GetValue(myObject);
					if(string.IsNullOrEmpty(value))
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
