using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TUVANLAPTOP
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void ThemMoiSanPham_Click(object sender, EventArgs e)
        {
            THEMSANPHAM frm = new THEMSANPHAM();
            frm.ShowDialog();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CAPNHATDULIEUKHACHHANG frm = new CAPNHATDULIEUKHACHHANG();
            frm.ShowDialog();
        }

        private void ThemDacTinhSanPham_Click(object sender, EventArgs e)
        {
            THEMDACTINHSANPHAM themThongTin = new THEMDACTINHSANPHAM();
            themThongTin.ShowDialog();
        }

        private void ThayDoiThongTinSP_Click(object sender, EventArgs e)
        {
            THAYDOI_THONGTINSANPHAM frm = new THAYDOI_THONGTINSANPHAM();
            frm.ShowDialog();
        }

        private void QuanLyXoaSP_Click(object sender, EventArgs e)
        {
            CAPNHATXOASANPHAM frm = CAPNHATXOASANPHAM.Instance();
            frm.ShowDialog();
        }
    }
}
