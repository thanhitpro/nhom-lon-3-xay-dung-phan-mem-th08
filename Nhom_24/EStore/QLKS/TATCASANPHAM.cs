using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EStoreDTO;
using EStoreBUS;

namespace QLKS
{
    public partial class TATCASP : DevComponents.DotNetBar.Office2007Form
    {
        private myDongLaptopBUS m_dLaptopBus = new myDongLaptopBUS();
        public TATCASP()
        {
            InitializeComponent();
        }

        private void TATCASP_Load(object sender, EventArgs e)
        {          
            flp_TatCaSanPham.Controls.Clear();

            List<myDongLaptop> dsSP = m_dLaptopBus.LayDSDongLaptop();
            foreach (myDongLaptop dongLT in dsSP)
            {
                UC_SANPHAM sanPham = new UC_SANPHAM(dongLT.STenDong, dongLT.SHinhAnh, dongLT.NMaNhaSX.STenNhaSX, dongLT.SMauSac, dongLT.FGiaBanHienHanh, dongLT.IThoiGianBaoHanh);
                flp_TatCaSanPham.Controls.Add(sanPham);
            }
        }
    }
}