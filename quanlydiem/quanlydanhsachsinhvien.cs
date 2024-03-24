using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_kiemthunangcao_pd09444
{
    public class quanlydanhsachsinhvien
    {
        public string maSV { get; set; }
        public string hoTen { get; set; }
        public string email { get; set; }
        public string sodienthoai { get; set; }
        public string gioitinh { get; set; }
        public string diachi { get; set; }
        public void nhapdulieusinhvienmoi(string msv,string ht,string mail,string sdt,string gentle,string dc)
        {
            if (msv == "" || ht == "" || mail=="" || sdt=="" || gentle==""||dc=="") throw new ArgumentException("nhap sai dinh dang");
            maSV = msv;
            hoTen = ht;
            email = mail;
            sodienthoai = sdt;
            gioitinh = gentle;
            diachi = dc;

        }
        public void sualieusinhvien(string msv, string ht, string mail, string sdt, string gentle, string dc)
        {
            if (msv == "" || ht == "" || mail == "" || sdt == "" || gentle == "" || dc == "") throw new ArgumentException("nhap sai dinh dang");

            maSV = msv;
            hoTen = ht;
            email = mail;
            sodienthoai = sdt;
            gioitinh = gentle;
            diachi = dc;
        }
        public void xoadulieusinhvien(string msv)
        {
            if (msv == "" ) throw new ArgumentException("nhap sai dinh dang");

            maSV = "";
            hoTen = "";
            email = "";
            sodienthoai = "";
            gioitinh = "";
            diachi = "";
        }
        public void timkiemsinhvien(string msv, string ht, string mail, string sdt, string gentle, string dc)
        {
            if (msv == "") throw new ArgumentException("nhap sai dinh dang");
            msv+=maSV ;
            ht+=hoTen ;
            mail += email;
            sdt += sodienthoai;
            gentle += gioitinh;
            dc += diachi;

        }
    }
}
