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

        /// <summary>
        /// Nguyễn Ngọc Tường - Test hàm 5_Khôi phục trạng thái - true
        /// </summary>
        [Test]
        public void TestKhoiPhucTrangThai1()
        {
            THEMKHACHHANG _themKH = new THEMKHACHHANG();

            myKhachHang khachHang = new myKhachHang
            {
                STenKhachHang = "",//Không có dữ liệu
                SNgaySinh = "",//Không có dữ liệu
                SGioiTinh = "Nam",
                SCMND = "272065189",
                SDiaChi = "Biên Hòa",//Không có dữ liệu
                SEmail = "",
                SSoDienThoai = ""//Không có dữ liệu
            };
            _themKH.KiemTraDuLieuTrong(khachHang);// Gọi hàm này mới test được hàm KhoiPhucTrangThai
            // Ở đây, không kiểm tra hàm này, xem như hoạt động đúng.

            _themKH.KhoiPhucTrangThai(khachHang);

            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["textBoxHoTen"].BackColor, SystemColors.Window, "Lỗi khi so sánh màu textbox Họ tên");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["dateTimeInputNgaySinh"].ForeColor, SystemColors.ControlText, "Lỗi khi so sánh màu textbox Ngày sinh");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinLienLac"].Controls["textBoxDiaChi"].BackColor, SystemColors.Window, "Lỗi khi so sánh màu textbox Địa chỉ");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinLienLac"].Controls["textBoxSdt"].BackColor, SystemColors.Window, "Lỗi khi so sánh màu textbox Điện thoại");
        }

        /// <summary>
        /// Nguyễn Ngọc Tường - Test hàm 5_Khôi phục trạng thái - false
        /// </summary>
        /// 
        [Test]
        public void TestKhoiPhucTrangThai2()
        {
            THEMKHACHHANG _themKH = new THEMKHACHHANG();

            myKhachHang khachHang = new myKhachHang
            {
                STenKhachHang = "Nguyễn Ngọc Tường",//có dữ liệu
                SNgaySinh = "03/06/90",//có dữ liệu
                SGioiTinh = "Nam",
                SCMND = "321372883",
                SDiaChi = "Bến Tre",//có dữ liệu
                SEmail = "0812600@gmail.com",
                SSoDienThoai = "0988686972"//có dữ liệu
            };
            _themKH.KiemTraDuLieuTrong(khachHang);// Gọi hàm này mới test được hàm KhoiPhucTrangThai
            // Ở đây, không kiểm tra hàm này, xem như hoạt động đúng.

            _themKH.KhoiPhucTrangThai(khachHang);

            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["textBoxHoTen"].BackColor, SystemColors.Window, "Lỗi khi so sánh màu textbox Họ tên");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["dateTimeInputNgaySinh"].ForeColor, SystemColors.ControlText, "Lỗi khi so sánh màu textbox Ngày sinh");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinLienLac"].Controls["textBoxDiaChi"].BackColor, SystemColors.Window, "Lỗi khi so sánh màu textbox Địa chỉ");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinLienLac"].Controls["textBoxSdt"].BackColor, SystemColors.Window, "Lỗi khi so sánh màu textbox Điện thoại");
        }

        /// <summary>
        /// Nguyễn Ngọc Tường - Test hàm 6_Reset
        /// </summary>
        /// 6. Tường
        [Test]
        public void TestReset()
        {
            THEMKHACHHANG _themKH = new THEMKHACHHANG();
            _themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["textBoxHoTen"].Text = "Nguyễn Thị A";
            _themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["dateTimeInputNgaySinh"].Text = "02/01/1990";
            _themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["comboBoxGioiTinh"].Text = "Nữ";
            _themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["textBoxCMND"].Text = "9554788";

            _themKH.Controls["groupPanel2"].Controls["panelThongTinLienLac"].Controls["textBoxDiaChi"].Text = "Cà Mau";
            _themKH.Controls["groupPanel2"].Controls["panelThongTinLienLac"].Controls["textBoxEmail"].Text = "acamau@gmail.com";
            _themKH.Controls["groupPanel2"].Controls["panelThongTinLienLac"].Controls["textBoxSdt"].Text = "74837584";

            _themKH.Reset();

            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["textBoxHoTen"].Text, "", "Chưa reset họ tên");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["dateTimeInputNgaySinh"].Text, "", "Chưa reset ngày sinh");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["comboBoxGioiTinh"].Text, "Nam", "Chưa reset giới tính");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinKH"].Controls["textBoxCMND"].Text, "", "Chưa reset CMND");

            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinLienLac"].Controls["textBoxDiaChi"].Text, "", "Chưa reset địa chỉ");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinLienLac"].Controls["textBoxEmail"].Text, "", "Chưa reset Email");
            Assert.AreEqual(_themKH.Controls["groupPanel2"].Controls["panelThongTinLienLac"].Controls["textBoxSdt"].Text, "", "Chưa reset số điệnt thoại");
        }

        /// <summary>
        /// Tran Cong Vien - Test ham 7 - Testcase1
        /// </summary>
        [Test]
        public void KiemTraVaThemKhachHangTest1()
        {
            myKhachHang thongTinKhachHang = new myKhachHang
            {
                STenKhachHang = "Trần Công Viên",
                SNgaySinh = "08/03/1990",
                SGioiTinh = "Nam",
                SCMND = "197113456",
                SDiaChi = "Quang Tri",
                SEmail = "mrken23@gmail.com",
                SSoDienThoai = "01693050051"
            };

            THEMKHACHHANG frmThemKH = new THEMKHACHHANG();
            ifKhachHang.KiemTraVaThemKhachHang(thongTinKhachHang, frmThemKH);

            List<myKhachHang> danhSachKhachHang = new List<myKhachHang>();
            danhSachKhachHang = khachhang_BUS.LayDanhSachKhachHang();
            Assert.AreEqual(thongTinKhachHang.SCMND, danhSachKhachHang[danhSachKhachHang.Count - 1].SCMND, "lỗi khi so sánh cmnd");
        }

        /// <summary>
        /// Tran Cong Vien - Test ham 7 - Testcase2
        /// </summary>
        [Test]
        public void KiemTraVaThemKhachHangTest2()
        {
            myKhachHang thongTinKhachHang = new myKhachHang
            {
                STenKhachHang = "Trần Công Viên",
                SNgaySinh = "08/03/1990",
                SGioiTinh = "Nam",
                SCMND = "197113456",
                SDiaChi = "Quang Tri",
                SEmail = "mrken23@gmail.com",
                //Thieu so dien thoai
            };

            THEMKHACHHANG frmThemKH = new THEMKHACHHANG();
            ifKhachHang.KiemTraVaThemKhachHang(thongTinKhachHang, frmThemKH);

            List<myKhachHang> danhSachKhachHang = new List<myKhachHang>();
            danhSachKhachHang = khachhang_BUS.LayDanhSachKhachHang();
            Assert.AreNotEqual(thongTinKhachHang.SCMND, danhSachKhachHang[danhSachKhachHang.Count - 1].SCMND, "Lỗi khi so sánh cmnd");
        }

    }
}
