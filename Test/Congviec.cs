using System;
using System.Collections.Generic;
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
        private decimal luong;
        public decimal Luong
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
        public Congviec(int iD, decimal luong, string motacv, string yeucau, string phucloi, string chucvu, string tencty)
        {
            ID = iD;
            Luong = luong;
            Motacv = motacv;
            Yeucau = yeucau;
            Phucloi = phucloi;
            Chucvu = chucvu;
            Tencty = tencty;
        }
    }
}
