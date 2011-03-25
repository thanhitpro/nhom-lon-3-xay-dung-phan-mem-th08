using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using NUnit.Framework;

namespace EStoreDAO
{
    [TestFixture]
    public class TestmyKhachHangDAO
    {
        
        [Test]
        public void LayDanhSachKhachHangTest()
        {
            myKhachHangDAO ketQua = new myKhachHangDAO();
            List<myKhachHang> danhSachKhachHang = new List<myKhachHang>();
            danhSachKhachHang = ketQua.LayDanhSachKhachHang();

            myKhachHang khachHangDauTien = new myKhachHang 
            { 
                STenKhachHang = "Tống Hoàng Quốc Nhật",
                SNgaySinh = "08/03/1990",
                SGioiTinh = "Nam",
                SCMND = "272065189",
                SDiaChi = "Biên Hòa", 
                SEmail = "qnhata3@yahoo.com", 
                SSoDienThoai = "0977014007"
            };

             Assert.AreEqual(khachHangDauTien.SCMND, danhSachKhachHang[0].SCMND, "lỗi khi so sánh cmnd");
        }


        [Test]
        public void ThemKhachHangTest()
        {
            myKhachHangDAO ketQua = new myKhachHangDAO();

            myKhachHang khachHangMoi = new myKhachHang
            {
                STenKhachHang = "Tường",
                SNgaySinh = "08/03/1990",
                SGioiTinh = "Nữ",
                SCMND = "67890",
                SDiaChi = "Biên Hòa",
                SEmail = "qnhata3@yahoo.com",
                SSoDienThoai = "3423423"
            };
            ketQua.ThemKhachHang(khachHangMoi);
            List<myKhachHang> danhSachKhachHang = new List<myKhachHang>();
            danhSachKhachHang = ketQua.LayDanhSachKhachHang();
            Assert.AreEqual(khachHangMoi.SCMND, danhSachKhachHang[danhSachKhachHang.Count - 1].SCMND, "lỗi khi so sánh cmnd");
            danhSachKhachHang = ketQua.LayDanhSachKhachHang();
            ketQua.XoaKhachHangTheoCMND(danhSachKhachHang[danhSachKhachHang.Count - 1].SCMND);
        }

        
    }
}
