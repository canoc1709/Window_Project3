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
        public void Themcongviec(Congviec congviec, int id)
        {
            string s = string.Format("insert into Tuyenviec(Chucvu, Luong, MotaCV, Yeucau, Phucloi, Cty) " +
                "values('{0}','{1}','{2}','{3}','{4}',{5})", congviec.Chucvu, Convert.ToInt32(congviec.Luong), congviec.Motacv, congviec.Yeucau, congviec.Phucloi, id);
            connection.ThucThi(s);
        }
        public DataTable LoadCongviec()
        {
            DataTable dt = new DataTable();
            string s = string.Format("select * from v_Tuyenviec");
            dt = connection.load(s);
            return dt;
        }
        public void Dangki(int idcv, int iduv)
        {
            string s = string.Format("insert into HoSo(MaTV, MaUV, Tinhtrang) values ({0},{1},'Chua chap nhan')", idcv, iduv);
            connection.ThucThi(s);
        }
    }
}
