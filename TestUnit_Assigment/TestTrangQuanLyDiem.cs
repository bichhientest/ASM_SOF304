using assigment_kiemthunangcao_pd09444;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnit_Assigment
{
    [TestFixture]
    public class TestTrangQuanLyDiem
    {
        [Test]
        public void test_dulieunhaptinhTB()
        {
            quanlydanhsachdiem ql=new quanlydanhsachdiem();
            ql.tinhdiemTB(6,7,8);
        }
        [TestCase(7.5,8.5,8,8)]
        public void tinhdiemTB(double gt1, double gt2, double gt3, double result)
        {
            quanlydanhsachdiem ql = new quanlydanhsachdiem();
           double expected= ql.tinhdiemTB(gt1, gt2, gt3);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void test_DuLieuNhapDiem()
        {
            quanlydanhsachdiem ql = new quanlydanhsachdiem();
            ql.nhapdiemchosinhvien("pd09444","it18302",6, 7, 8);
        }
        [TestCase("pd09444", "it18302",6,7,8)]
        public void adddiemsinhvien(string msv, string lop, double gt1, double gt2, double gt3) {
            quanlydanhsachdiem ql = new quanlydanhsachdiem();
            ql.nhapdiemchosinhvien("pd09444", "it18302",gt1, gt2, gt3);
            Assert.AreEqual(ql.mssv, msv);
            Assert.AreEqual(ql.lophoc, lop);
            Assert.AreEqual(ql.toan, gt1);
            Assert.AreEqual(ql.ly, gt2);
            Assert.AreEqual(ql.hoa, gt3);

        }
        [Test]
        public void XoaSinhVienTrongBangDiem()
        {
            quanlydanhsachdiem ql = new quanlydanhsachdiem();
           ql. mssv = "pd09444";
           ql. lophoc = "it18302";
           ql. toan = 4;
           ql. ly = 3;
           ql.hoa = 8;
            ql.xoasinhvientrongbangdiem();
        }
        [TestCase("pd09444", "it18302", 6, 7, 8)]
        public void suadiemchosinhvien(string msv, string lop, double gt1, double gt2, double gt3)
        {
            quanlydanhsachdiem ql = new quanlydanhsachdiem();
            ql.mssv = "pd09444";
            ql.lophoc = "it18302";
            ql.toan = 4;
            ql.ly = 3;
            ql.hoa = 8;
            if (msv == ql.mssv && lop==ql.lophoc) {
                ql.suadiemchosinhvien(msv, lop, gt1, gt2, gt3);
            }
            else
            {
              Assert.Fail();
            }

        }

    }
}
