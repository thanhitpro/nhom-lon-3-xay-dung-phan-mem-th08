using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Threading;
using EStoreBUS;
using EStoreDTO;

namespace QLKS
{
    public partial class THEMKHACHHANG : DevComponents.DotNetBar.Office2007Form
    {
        private DevComponents.DotNetBar.Controls.DataGridViewX m_dataGridViewKhachHang;
        private InterfaceKhachHang ifKhachHang;

        /// <summary>
        /// Ham dung class THEMKHACHHANG, khoi tao comboboxGioiTinh gom 2 gia tri la 'Nam' va 'Nữ'
        /// </summary>
        public THEMKHACHHANG()
        {
            InitializeComponent();
            ifKhachHang = new InterfaceKhachHang();
            List<string> comboboxTemp = new List<string>();
            comboboxTemp = ifKhachHang.khoiTaoThemKhachHang();
            comboBoxGioiTinh.DataSource = comboboxTemp;
        }

        /// <summary>
        /// Ham nhan dataGridView tu form MANHINHCHINH
        /// </summary>
        /// <param name="_dataGirdViewX"></param>
        public void LayDataGirdViewKhachHang(DevComponents.DotNetBar.Controls.DataGridViewX _dataGirdViewX)
        {
            this.m_dataGridViewKhachHang = ifKhachHang.layDataGridViewKhachHang(_dataGirdViewX);
        }

        /// <summary>
        /// Ham dua du lieu khach hang vao DataGirdview cua form MANHINHCHINH
        /// </summary>
        /// <param name="danhSachKhachHang"></param>
        private void DuaDuLieuVaoDataGridView(List<myKhachHang> _danhSachKhachHang)
        {
            ifKhachHang = new InterfaceKhachHang();
            ifKhachHang.DuaDuLieuVaoDataGridView(this.m_dataGridViewKhachHang, _danhSachKhachHang);            
        }

        /// <summary>
        /// Ham de kiem tra du lieu khach hang nhap co hop le khong? co day du thong tin khong ?
        /// </summary>
        /// <param name="_thongTinKhachHang"></param>
        /// <returns></returns>
        private bool KiemTraDuLieuTrong(myKhachHang _thongTinKhachHang)
        {
            ifKhachHang = new InterfaceKhachHang();

            return ifKhachHang.KiemTraDuLieuTrong(textBoxHoTen, dateTimeInputNgaySinh,
                textBoxDiaChi, textBoxSdt, _thongTinKhachHang);            
        }

        /// <summary>
        /// Ham khoi phuc lai trang thai cua cac textbox sau khi thong bao loi xuat hien
        /// </summary>
        /// <param name="_thongTinKhachHang"></param>
        private void KhoiPhucTrangThai(myKhachHang _thongTinKhachHang)
        {
            if (_thongTinKhachHang.STenKhachHang == "")
            {
                textBoxHoTen.BackColor = SystemColors.Window;
            }

            if (_thongTinKhachHang.SNgaySinh == "")
            {
                dateTimeInputNgaySinh.ForeColor = SystemColors.ControlText;
            }

            if (_thongTinKhachHang.SDiaChi == "")
            {
                textBoxDiaChi.BackColor = SystemColors.Window;
            }

            if (_thongTinKhachHang.SSoDienThoai == "")
            {
                textBoxSdt.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// Ham reset gia tri trong cac textbox, dua ve ""
        /// </summary>
        private void Reset()
        {
            textBoxHoTen.Text = "";
            dateTimeInputNgaySinh.Text = "";
            textBoxCMND.Text = "";
            textBoxDiaChi.Text = "";
            textBoxEmail.Text = "";
            textBoxSdt.Text = "";
        }

        /// <summary>
        /// Ham xu li khi click vao button "Nhap thong tin"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNhapThongTin_Click(object sender, EventArgs e)
        {
            myKhachHang thongTinKhachHang = new myKhachHang();
            thongTinKhachHang.STenKhachHang = textBoxHoTen.Text;
            thongTinKhachHang.SNgaySinh = dateTimeInputNgaySinh.Text;
            thongTinKhachHang.SCMND = textBoxCMND.Text;
            thongTinKhachHang.SGioiTinh = comboBoxGioiTinh.Text;
            thongTinKhachHang.SDiaChi = textBoxDiaChi.Text;
            thongTinKhachHang.SEmail = textBoxEmail.Text;
            thongTinKhachHang.SSoDienThoai = textBoxSdt.Text;

            if (KiemTraDuLieuTrong(thongTinKhachHang) == false)
            {
                myKhachHangBUS khachHang_BUS = new myKhachHangBUS();
                if (khachHang_BUS.ThemKhachHang(thongTinKhachHang))
                    if (MessageBox.Show("Khach hang da duoc them thanh cong vao CSDL", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Reset();
                        DuaDuLieuVaoDataGridView(khachHang_BUS.LayDanhSachKhachHang());
                    }
            }
            else
            {
                if (MessageBox.Show("Ban nhap thieu thong tin", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    KhoiPhucTrangThai(thongTinKhachHang);
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Ham xu ly o textboxSdt, chi cho nhap number vao textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Ham xu ly o textboxCMND, chi cho nhap number vao textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}