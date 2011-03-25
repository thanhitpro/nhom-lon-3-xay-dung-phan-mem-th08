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


namespace QLKS
{
    public class InterfaceKhachHang
    {
        public List<String> khoiTaoThemKhachHang()
        {
            List<string> comboboxTemp = new List<string>();
            comboboxTemp.Add("Nam");
            comboboxTemp.Add("Nữ");
            return comboboxTemp;
        }

        public DevComponents.DotNetBar.Controls.DataGridViewX layDataGridViewKhachHang(DevComponents.DotNetBar.Controls.DataGridViewX _dataGirdViewX)
        {
            return _dataGirdViewX;
        }

        /// <summary>
        /// Hàm đưa dữ liệu vào 1 DataGridView
        /// </summary>
        /// <param name="_danhSachKhachHang"></param>
        /// <returns></returns>   
        public void DuaDuLieuVaoDataGridView(DevComponents.DotNetBar.Controls.DataGridViewX dataGridView,
            List<myKhachHang> _danhSachKhachHang)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < _danhSachKhachHang.Count; ++i)
                dataGridView.Rows.Add(_danhSachKhachHang[i].STenKhachHang, _danhSachKhachHang[i].SGioiTinh, _danhSachKhachHang[i].SCMND, _danhSachKhachHang[i].SDiaChi, _danhSachKhachHang[i].SEmail, _danhSachKhachHang[i].SSoDienThoai, _danhSachKhachHang[i].SNgaySinh);
        }

        /// <summary>
        /// Hàm kiểm tra dữ liệu trống của 1 khách hàng
        /// </summary>
        /// <param name="_thongTinKhachHang"></param>
        /// <returns></returns>    
        public bool KiemTraDuLieuTrong(DevComponents.DotNetBar.Controls.TextBoxX txtHoTen,
            DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgaySinh,
            DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi,
            DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai,
            myKhachHang _thongTinKhachHang)
        {
            int flag = 0;

            if (_thongTinKhachHang.STenKhachHang == "")
            {
                txtHoTen.BackColor = Color.Red;
                flag = 1;
            }

            if (_thongTinKhachHang.SNgaySinh == "")
            {
                dtNgaySinh.ForeColor = Color.Red;
                flag = 1;
            }

            if (_thongTinKhachHang.SDiaChi == "")
            {
                txtDiaChi.BackColor = Color.Red;
                flag = 1;
            }

            if (_thongTinKhachHang.SSoDienThoai == "")
            {
                txtDienThoai.BackColor = Color.Red;
                flag = 1;
            }
            if (flag == 1) return true;
            else return false;
        }            
    }
}
