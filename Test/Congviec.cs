using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Congviec
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int luong;
        public int Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        private string motacv;
        public string Motacv
        {
            get { return motacv; }
            set { motacv = value; }
        }
        private string yeucau;
        public string Yeucau
        {
            get { return yeucau; }
            set { yeucau = value; }
        }
        private string phucloi;
        public string Phucloi
        {
            get { return phucloi; }
            set { phucloi = value; }
        }
        private string chucvu;
        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        private string tencty;
        public string Tencty
        {
            get { return tencty; }
            set { tencty = value; }
        }
        public Congviec() { }
        public Congviec(DataRow dr)
        {
            Tencty = (string)dr[0];
            ID = (int)dr[1];
            Chucvu = (string)dr[2];
            Luong = (int)dr[3];
            Motacv = (string)dr[4];
            Yeucau = (string)dr[5];
            Phucloi = (string)dr[6];
        }
        public Congviec(int iD, int luong, string motacv, string yeucau, string phucloi, string chucvu, string tencty)
        {
            ID = iD;
            Luong = luong;
            Motacv = motacv;
            Yeucau = yeucau;
            Phucloi = phucloi;
            Chucvu = chucvu;
            Tencty = tencty;
        }

        public Congviec(int luong, string motacv, string yeucau, string phucloi, string chucvu, string tencty)
        {
            Luong = luong;
            Motacv = motacv;
            Yeucau = yeucau;
            Phucloi = phucloi;
            Chucvu = chucvu;
            Tencty = tencty;
        }
    }
}
