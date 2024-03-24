using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_kiemthunangcao_pd09444
{
    public class quanlydanhsachdiem
    {
        public float diemtrungbinh { get; set; }
        public string mssv {  get; set; }
        public string lophoc { get; set; }
        public double toan { get; set; }
            public double ly{ get; set; }
            public double hoa{ get; set; }
       
        public void nhapdiemchosinhvien(string msv,string lop,double gt1, double gt2, double gt3)
        {
            if (msv==""||lop==""||gt1 <= 0 || gt2 <= 0 || gt3 <= 0) throw new ArgumentException("nhap sai dinh dang");
             mssv = msv;
            lophoc = lop;
            toan = gt1;
            ly = gt2;
            hoa = gt3;
        }
        public void suadiemchosinhvien(string msv, string lop, double gt1, double gt2, double gt3)
        {
            if (msv == "" || lop == "" || gt1 <= 0 || gt2 <= 0 || gt3 <= 0) throw new ArgumentException("nhap sai dinh dang");
                mssv = msv;
                lop = lophoc;
                gt1 = toan;
                gt2=ly;
                gt3= hoa;
            
        }
        public double tinhdiemTB(double gt1, double gt2, double gt3)
        {
            if (gt1 <= 0 || gt2 <= 0 || gt3 <= 0) throw new ArgumentException("nhap sai dinh dang");
            double diemtb = (gt1 + gt2 + gt3) / 3;
            return diemtb;
        }
        public void xoasinhvientrongbangdiem()
        {
            mssv = "";
            lophoc = "";
            toan = 0;
            ly = 0;
            hoa = 0;
        }

    }
}
