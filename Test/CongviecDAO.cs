using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class CongviecDAO
    {
        Connection connection = new Connection();
        public void Themcongviec(Congviec congviec, Congty congty)
        {
            string s = string.Format("insert into Tuyenviec(Chucvu, Luong, MotaCV, Yeucau, Phucloi, Cty) " +
                "values('{0}','{1}','{2}','{3}','{4}',{5})", congviec.Chucvu, Convert.ToInt32(congviec.Luong), congviec.Motacv, congviec.Yeucau, congviec.Phucloi, congty.ID);
            connection.ThucThi(s);
        }
        public DataTable LoadCongviec(string a)
        {
            DataTable dt = new DataTable();
            string s = string.Format("select * from v_Tuyenviec where Tenct like '%{0}%' or Chucvu like '%{0}%'", a);
            dt = connection.load(s);
            return dt;
        }
        public DataTable LoadCongviec(Congty congty)
        {
            DataTable dt = new DataTable();
            string s = string.Format("select * from v_Tuyenviec where IDcty = {0}",congty.ID);
            dt = connection.load(s);
            return dt;
        }
        public void Dangki(int idcv, int iduv)
        {
            string s = string.Format("insert into HoSo(MaTV, MaUV, Tinhtrang) values ({0},{1},'Chua chap nhan')", idcv, iduv);
            connection.ThucThi(s);
        }
        public void Sua(Congviec congviec)
        {
            string s = string.Format("update Tuyenviec set Chucvu = '{0}', Luong = {1}, MotaCV = '{2}', " +
                "Yeucau = '{3}', Phucloi = '{4}' where ID = {5}", congviec.Chucvu, congviec.Luong, congviec.Motacv, congviec.Yeucau, congviec.Phucloi, congviec.ID);
            connection.ThucThi(s);
        }
        public DataTable LoadUngvien(Congviec congviec)
        {
            DataTable dt = new DataTable();
            string s = string.Format("select uv.* from Hoso hs inner join Ungvien uv on hs.MaUV = uv.ID where hs.MaTV = {0}", congviec.ID);
            dt = connection.load(s);
            return dt;
        }
    }
}
