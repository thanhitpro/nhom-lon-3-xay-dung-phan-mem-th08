using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLKS
{
    public partial class UC_SANPHAM : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_SANPHAM()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm khởi tạo User Control
        /// </summary>
        public UC_SANPHAM(string _sTenSP,string _sDuongDanHinhAnh, string _sTenNhaSX,string _sMauSac, float _fGiaBan, int _iThoiGianBH)
        {
            InitializeComponent();
            groupPanel_ContenSP.Text = _sTenSP;
            rImage_Avatar.Image = Image.FromFile(_sDuongDanHinhAnh);
            value_nhaSX.Text = _sTenNhaSX;
            value_MauSac.Text = _sMauSac;
            value_GiaHienHanh.Text = _fGiaBan.ToString();
            value_TGBH.Text = _iThoiGianBH.ToString();
        }
    }
}
