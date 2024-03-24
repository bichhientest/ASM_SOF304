using assigment_kiemthunangcao_pd09444;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnit_Assigment
{
    public class TestTrangquanlysinhvien
    {
        [Test]
        public void test_nhapDuLieuNhaplieuchosinhvienmoi()
        {
            quanlydanhsachsinhvien ql = new quanlydanhsachsinhvien();
            ql.nhapdulieusinhvienmoi("pd09444", "mai van minh", "minh@123", "0822761718", "nam", "quang binh");
        }
        [TestCase("pd09444", "mai van minh", "minh@123", "0822761718", "nam", "quang binh")]
        public void test_adddiemsinhvien(string msv, string ht, string mail, string sdt, string gentle, string dc)
        {
            quanlydanhsachsinhvien ql = new quanlydanhsachsinhvien();
            ql.nhapdulieusinhvienmoi(msv, ht,mail, sdt, gentle,dc);
            Assert.AreEqual(ql.maSV, msv);
            Assert.AreEqual(ql.hoTen, ht);
            Assert.AreEqual(ql.email, mail);
            Assert.AreEqual(ql.sodienthoai, sdt);
            Assert.AreEqual(ql.gioitinh, gentle);
            Assert.AreEqual(ql.diachi, dc);

        }
        [TestCase("pd09444", "mai van minh", "minh@123", "0822761718", "nam", "quang binh")]
        public void suathongtinchosinhvien(string msv, string ht, string mail, string sdt, string gentle, string dc)
        {
            quanlydanhsachsinhvien ql = new quanlydanhsachsinhvien();
            ql.maSV = "pd09444";
            ql.hoTen = "mai van minh";
            ql.email = "minh@123";
            ql.sodienthoai = "0822761718";
            ql.gioitinh = "nam";
            ql.diachi = "quang binh";

            if (msv == ql.maSV)
            {
                ql.sualieusinhvien(msv, ht, mail, sdt, gentle, dc);
            }
            else
            {
                Assert.Fail();
            }

        }

        [TestCase("pd09444")]
        public void xoathongtinsinhvien(string msv)
        {
            quanlydanhsachsinhvien ql = new quanlydanhsachsinhvien();
            ql.maSV = "pd09444";
            ql.hoTen = "mai van minh";
            ql.email = "minh@123";
            ql.sodienthoai = "0822761718";
            ql.gioitinh = "nam";
            ql.diachi = "quang binh";

            if (msv == ql.maSV)
            {
                ql.xoadulieusinhvien(msv);
            }
            else
            {
                Assert.Fail();
            }

        }


        [TestCase("pd09444")]
        public void timkiemsinhvien(string msv)
        {
            quanlydanhsachsinhvien ql = new quanlydanhsachsinhvien();
            ql.maSV = "pd09444";
            ql.hoTen = "mai van minh";
            ql.email = "minh@123";
            ql.sodienthoai = "0822761718";
            ql.gioitinh = "nam";
            ql.diachi = "quang binh";

            if (msv == ql.maSV)
            {
                ql.timkiemsinhvien(ql.maSV,ql.hoTen,ql.email,ql.sodienthoai,ql.gioitinh,ql.diachi);
            }
            else
            {
                Assert.Fail();
            }

        }
    }
}
