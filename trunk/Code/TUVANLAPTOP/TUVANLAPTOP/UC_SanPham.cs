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
    public partial class UC_SANPHAM : UserControl
    {
        private myChiTietDongLaptopDTO m_dLaptop = new myChiTietDongLaptopDTO();

        public UC_SANPHAM()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm khởi tạo đối tượng DongLaptop chứa trong UserControl Sản phẩm
        /// </summary>
        /// <param name="_mDongLaptop">Thông tin đối tượng DongLaptop muốn khởi tạo cho Control</param>
        public UC_SANPHAM(myChiTietDongLaptopDTO _mDongLaptop)
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
        /// <param name="sender">Control gây ra sự kiện hover</param>
        /// <param name="e">Thông tin sự kiện</param>
        private void linkLabel_TenLaptop_MouseHover(object sender, EventArgs e)
        {
            toolTip_TenLaptop.ToolTipTitle = "Xem chi tiết";
            toolTip_TenLaptop.Show(string.Format("Laptop {0}", (string)this.Tag), linkLabel_TenLaptop);
        }

        /// <summary>
        /// Hàm xử lý sự kiện load User control
        /// </summary>
        /// <param name="sender">Control gây ra sự kiện Load</param>
        /// <param name="e">Thông tin sự kiện</param>
        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            //Load hình ảnh đại diện cho laptop:
            string imagePath = Application.StartupPath + "\\" + m_dLaptop.SHinhAnh.Trim();
            if (CheckExistImagePath(imagePath))
                pictureBox_HinhSP.Image = Image.FromFile(imagePath);
            else
                pictureBox_HinhSP.Image = Properties.Resources.noImage;

            //Tên laptop:                        
            linkLabel_TenLaptop.Text = ReduceLengthString(m_dLaptop.STenChiTietDongLapTop);
            linkLabel_TenLaptop.Tag = m_dLaptop;
            this.Tag = m_dLaptop.STenChiTietDongLapTop.Trim();

            FillNSXInfo();
            FillThoiGianBHInfo();
            FillGiaBanInfo();
        }

        /// <summary>
        /// Điền thông tin Giá Bán laptop cho UCControl
        /// </summary>
        private void FillGiaBanInfo()
        {
            if (m_dLaptop.FGiaBanHienHanh > 0)
            {
                label_Gia_value.Text = m_dLaptop.FGiaBanHienHanh.ToString("###,###") + " triệu";
            }
            else
                label_Gia_value.Text = "Chưa xác định";
        }

        /// <summary>
        /// Điền thông tin Thời gian Bảo hành cho UCControl
        /// </summary>
        private void FillThoiGianBHInfo()
        {
            if (m_dLaptop.IThoiGianBaoHanh > 0)
            {
                label_BaoHanh_value.Text = m_dLaptop.IThoiGianBaoHanh.ToString("00") + "tháng";
            }
            else
                label_BaoHanh_value.Text = "Chưa xác định";
        }

        /// <summary>
        /// Điền thông tin Nhà Sản Xuất cho UCControl
        /// </summary>
        private void FillNSXInfo()
        {
            if (m_dLaptop.NhaSanXuat.STenNhaSanXuat.Trim() != "")
            {
                label_NhaSX_value.Text = m_dLaptop.NhaSanXuat.STenNhaSanXuat.Trim();
            }
            else
                linkLabel_TenLaptop.Text = "Chưa xác định";
        }

        /// <summary>
        /// Hàm rút gọn độ dài tên dòng Laptop
        /// </summary>
        /// <param name="stringNeedReduced">Chuỗi cần rút gọn</param>
        /// <returns>
        ///     Nếu độ dài > 25, trả về chuỗi từ 0 --> 25 + "..."
        ///     Nếu độ dài nhỏ hơn hoặc bằng 25, trả về chuỗi ban đầu
        /// </returns>
        public string ReduceLengthString(string stringNeedReduced)
        {
            if (stringNeedReduced.Length > 25)
            {
                stringNeedReduced = stringNeedReduced.Substring(0, 25) + "...";
            }            
            return stringNeedReduced;
        }

        /// <summary>
        /// Hàm kiểm tra đường dẫn ảnh có tồn tại hay không ?
        /// </summary>
        /// <param name="imagePath">Chuỗi đường dẫn của ảnh</param>
        /// <returns>
        ///     Tồn tại: trả về True
        ///     Không tồn tại: trả về False
        /// </returns>
        public bool CheckExistImagePath(string imagePath)
        {
            return File.Exists(imagePath);                            
        }
    }
}
