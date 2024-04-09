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
        private string nganhnghe;
        public string Nganhnghe
        {
            get { return nganhnghe; }
            set { nganhnghe = value; }
        }
        private string capbac;

        public string Capbac
        {
            get { return capbac; }
            set { capbac = value; }
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
            Nganhnghe = (string)dr[2];
            Capbac = (string)dr[3];
            Luong = (int)dr[4];
            Motacv = (string)dr[5];
            Yeucau = (string)dr[6];
            Phucloi = (string)dr[7];
        }
        public Congviec(int iD, int luong, string motacv, string yeucau, string phucloi, string nganhnghe,string capbac, string tencty)
        {
            ID = iD;
            Luong = luong;
            Motacv = motacv;
            Yeucau = yeucau;
            Phucloi = phucloi;
            Nganhnghe = nganhnghe;
            Capbac = capbac;
            Tencty = tencty;
        }

        public Congviec(int luong, string motacv, string yeucau, string phucloi, string nganhnghe,string capbac, string tencty)
        {
            Luong = luong;
            Motacv = motacv;
            Yeucau = yeucau;
            Phucloi = phucloi;
            Nganhnghe = nganhnghe;
            Capbac = capbac;
            Tencty = tencty;
        }
    }
}
