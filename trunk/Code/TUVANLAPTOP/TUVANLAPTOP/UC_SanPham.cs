using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using EStoreBUS;
using EStoreDTO;

namespace TUVANLAPTOP
{
    public partial class UC_SanPham : UserControl
    {
        private myChiTietDongLaptopDTO m_dLaptop = new myChiTietDongLaptopDTO();

        /// <summary>
        /// Hàm khởi tạo đối tượng DongLaptop chứa trong UserControl Sản phẩm
        /// </summary>
        /// <param name="_mDongLaptop"></param>
        public UC_SanPham(myChiTietDongLaptopDTO _mDongLaptop)
        {
            InitializeComponent();
            m_dLaptop = _mDongLaptop;
        }

        /// <summary>
        /// Hàm lấy về đối tượng LinkLabel TenSP
        /// </summary>
        public LinkLabel Link_TenLaptop
        {
            get { return linkLabel_TenLaptop; }
        }

        /// <summary>
        /// Hàm xử lý sự kiện chuột hover qua label Tên Laptop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel_TenLaptop_MouseHover(object sender, EventArgs e)
        {
            toolTip_TenLaptop.ToolTipTitle = "Xem chi tiết";
            toolTip_TenLaptop.Show(string.Format("Laptop {0}", (string)this.Tag), linkLabel_TenLaptop);
        }

        /// <summary>
        /// Hàm xử lý sự kiện load User control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            //Load hình ảnh đại diện cho laptop:
            string imagePath = Application.StartupPath + "\\" + m_dLaptop.SHinhAnh.Trim();
            if (File.Exists(imagePath))
                pictureBox_HinhSP.Image = Image.FromFile(imagePath);

            //Tên laptop:
            string nameLaptop = m_dLaptop.STenChiTietDongLapTop.Trim();
            if (nameLaptop.Length > 25)
            {
                nameLaptop = nameLaptop.Substring(0, 25) + "...";
            }
            linkLabel_TenLaptop.Text = nameLaptop;
            linkLabel_TenLaptop.Tag = m_dLaptop;

            // Thông tin chung về laptop:
            //Tên nhà SX:
            if (m_dLaptop.NhaSanXuat.STenNhaSanXuat.Trim() != "")
            {
                label_NhaSX_value.Text = m_dLaptop.NhaSanXuat.STenNhaSanXuat.Trim();
            }
            else
                linkLabel_TenLaptop.Text = "Chưa xác định";

            //Thời gian bảo hành:
            if (m_dLaptop.IThoiGianBaoHanh > 0)
            {
                label_BaoHanh_value.Text = m_dLaptop.IThoiGianBaoHanh.ToString("00") + "tháng";
            }
            else
                label_BaoHanh_value.Text = "Chưa xác định";

            //Giá hiện hành:
            if (m_dLaptop.FGiaBanHienHanh > 0)
            {
                label_Gia_value.Text = m_dLaptop.FGiaBanHienHanh.ToString() + " triệu";
            }
            else
                label_Gia_value.Text = "Chưa xác định";

            this.Tag = m_dLaptop.STenChiTietDongLapTop.Trim();
        }
    }
}
