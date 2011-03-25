using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Threading;
using EStoreDTO;
using EStoreBUS;
using NUnit.Framework;

namespace QLKS
{
    [TestFixture]
    public class TestInterfaceKhachHang
    {
        /////////////////////////////////////////////////////////////////////
        InterfaceKhachHang ifKhachHang = new InterfaceKhachHang();
        myKhachHangBUS khachhang_BUS = new myKhachHangBUS();
        /////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Tue - Ham 1
        /// </summary>
        [Test]
        public void khoiTaoThemKhachHangTest()
        {
            InterfaceKhachHang interfaceKhachHangTest = new InterfaceKhachHang();
            List<String> gioiTinh = new List<string>();
            gioiTinh.Add("Nam");
            gioiTinh.Add("Nữ");
            Assert.AreEqual(gioiTinh, interfaceKhachHangTest.khoiTaoThemKhachHang(), "lỗi khi so sánh giới tính nam");
        }

        /// <summary>
        /// Tue - Ham 2
        /// </summary>
        [Test]
        public void layDataGridViewKhachHangTest()
        {
            DevComponents.DotNetBar.Controls.DataGridViewX dataGridView;
            InterfaceKhachHang _interfaceKhachHangTest = new InterfaceKhachHang();
            List<myKhachHang> dsKhachHang = new List<myKhachHang>();
            myKhachHangBUS khachHang_BUS = new myKhachHangBUS();
            dsKhachHang = khachHang_BUS.LayDanhSachKhachHang();

            //////////////////////////////////////////////////////////////////////////
            //Tạo DataGridView dataGridViewKhachHang
            //////////////////////////////////////////////////////////////////////////
            DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewKhachHang = new DevComponents.DotNetBar.Controls.DataGridViewX();

            DataGridViewTextBoxColumn TenKhachHang = new DataGridViewTextBoxColumn();
            TenKhachHang.HeaderText = "Tên Khách Hàng";
            TenKhachHang.Name = "TenKhachHang";

            DataGridViewTextBoxColumn GioiTinh = new DataGridViewTextBoxColumn();
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.Name = "GioiTinh";

            DataGridViewTextBoxColumn CMND = new DataGridViewTextBoxColumn();
            CMND.HeaderText = "CMND";
            CMND.Name = "CMND";

            DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
            CMND.HeaderText = "Địa chỉ";
            CMND.Name = "DiaChi";

            DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
            CMND.HeaderText = "Email";
            CMND.Name = "Email";

            DataGridViewTextBoxColumn Phone = new DataGridViewTextBoxColumn();
            CMND.HeaderText = "Phone";
            CMND.Name = "Phone";

            DataGridViewTextBoxColumn NgaySinh = new DataGridViewTextBoxColumn();
            CMND.HeaderText = "Ngày Sinh";
            CMND.Name = "NgaySinh";

            dataGridViewKhachHang.Columns.AddRange(new DataGridViewTextBoxColumn[] {
            TenKhachHang,
            GioiTinh,
            CMND,
            DiaChi,
            Email,
            Phone,
            NgaySinh});
            //////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < dsKhachHang.Count; ++i)
                dataGridViewKhachHang.Rows.Add(dsKhachHang[i].STenKhachHang, dsKhachHang[i].SGioiTinh, dsKhachHang[i].SCMND, dsKhachHang[i].SDiaChi, dsKhachHang[i].SEmail, dsKhachHang[i].SSoDienThoai, dsKhachHang[i].SNgaySinh);
            dataGridView = _interfaceKhachHangTest.layDataGridViewKhachHang(dataGridViewKhachHang);

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
            Assert.AreEqual(khachHangDauTien.STenKhachHang, dataGridView.Rows[0].Cells[0].Value, "Lỗi do không có khách hàng nào thỏa");
        }

        /// <summary>
        /// Le Anh Tuan - Test ham 3
        /// </summary>
        [Test]
        public void DuaDuLieuVaoDataGridViewTest()
        {
            //////////////////////////////////////////////////////////////////////////
            //Tạo DataGridView result
            //////////////////////////////////////////////////////////////////////////
            DevComponents.DotNetBar.Controls.DataGridViewX result = new DevComponents.DotNetBar.Controls.DataGridViewX();            

            DataGridViewTextBoxColumn TenKhachHang = new DataGridViewTextBoxColumn();
            TenKhachHang.HeaderText = "Tên Khách Hàng";
            TenKhachHang.Name = "TenKhachHang";

            DataGridViewTextBoxColumn GioiTinh = new DataGridViewTextBoxColumn();
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.Name = "GioiTinh";

            DataGridViewTextBoxColumn CMND = new DataGridViewTextBoxColumn();
            CMND.HeaderText = "CMND";
            CMND.Name = "CMND";

            DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.Name = "DiaChi";

            DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
            Email.HeaderText = "Email";
            Email.Name = "Email";

            DataGridViewTextBoxColumn Phone = new DataGridViewTextBoxColumn();
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";

            DataGridViewTextBoxColumn NgaySinh = new DataGridViewTextBoxColumn();
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.Name = "NgaySinh";

            result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] 
            {
                TenKhachHang, GioiTinh, CMND, DiaChi, Email, Phone, NgaySinh
            });
            //////////////////////////////////////////////////////////////////////////

            List<myKhachHang> lKhachHang = khachhang_BUS.LayDanhSachKhachHang();
            ifKhachHang.DuaDuLieuVaoDataGridView(result, lKhachHang);

            string strDiaChi = "Biên Hòa";

            Assert.AreEqual(strDiaChi, result.Rows[0].Cells[3].Value.ToString(),
                "Loi dua du lieu vao DataGridView khong dung !");
        }

        /// <summary>
        /// Le Anh Tuan - Test ham 4 - Tra ve true
        /// </summary>
        [Test]
        public void KiemTraDuLieuTrongTest1()
        {
            DevComponents.DotNetBar.Controls.TextBoxX txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();

            myKhachHang khachHang = new myKhachHang
            {
                STenKhachHang = "",
                SNgaySinh = "",
                SDiaChi = "",
                SSoDienThoai = ""
            };

            bool bKetQua = true;
            bKetQua = ifKhachHang.KiemTraDuLieuTrong(txtHoTen, dtNgaySinh, txtDiaChi, txtDienThoai, khachHang);

            Assert.AreEqual(true, bKetQua, "Kiem tra du lieu trong cua khach hang khong dung !");
        }

        /// <summary>
        /// Le Anh Tuan - Test ham 4 - Tra ve false
        /// </summary>
        [Test]
        public void KiemTraDuLieuTrongTest2()
        {
            DevComponents.DotNetBar.Controls.TextBoxX txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();

            myKhachHang khachHang = new myKhachHang
            {
                STenKhachHang = "Le Anh Tuan",
                SNgaySinh = "06/07/1990",
                SDiaChi = "Thanh pho Ho Chi Minh",
                SSoDienThoai = "01659752739"
            };

            bool bKetQua = true;
            bKetQua = ifKhachHang.KiemTraDuLieuTrong(txtHoTen, dtNgaySinh, txtDiaChi, txtDienThoai, khachHang);

            Assert.AreEqual(false, bKetQua, "Kiem tra du lieu trong cua khach hang khong dung !");
        }
    }
}
