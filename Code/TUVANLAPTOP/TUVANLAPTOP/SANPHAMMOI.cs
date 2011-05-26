using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EStoreBUS;
using EStoreDAO;
using EStoreDTO;

namespace TUVANLAPTOP
{
    public partial class SANPHAMMOI : Form
    {
        private int iMaLaptopDuocChon;
        private string sTenLaptop = String.Empty;

        /// <summary>
        /// Hàm khởi tạo Form SANPHAMMOI
        /// </summary>
        public SANPHAMMOI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm xử lý sự kiện Click button Back
        /// </summary>
        /// <param name="sender">Control phát sinh sự kiện</param>
        /// <param name="e">Thông tin sự kiện</param>
        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Hàm xử lý sự kiện Form SANPHAMMOI được load lên
        /// </summary>
        /// <param name="sender">Control phát sinh sự kiện</param>
        /// <param name="e">Thông tin sự kiện</param>
        private void SANPHAMMOI_Load(object sender, EventArgs e)
        {
            List<myChiTietDongLaptopDTO> listIDLaptopTuVan = new List<myChiTietDongLaptopDTO>();
            listIDLaptopTuVan = (List<myChiTietDongLaptopDTO>)this.Tag;
            if (listIDLaptopTuVan.Count == 0)
            {
                btn_SoSP.Text = "KHÔNG CÓ LAPTOP NÀO PHÙ HỢP VỚI BẠN ! THỬ LẠI...";
            }
            else
            {
                btn_SoSP.Text = string.Format("CÓ {0} LAPTOP PHÙ HỢP VỚI BẠN !", listIDLaptopTuVan.Count);
                foreach (myChiTietDongLaptopDTO laptop in listIDLaptopTuVan)
                {
                    if (laptop != null)
                    {
                        UC_SANPHAM sanPhamControl = new UC_SANPHAM(laptop);
                        sanPhamControl.Link_TenLaptop.Click += new EventHandler(this.Link_TenLaptop_Click);
                        flp_DSLaptop.Controls.Add(sanPhamControl);
                    }
                }
            }

            button_ChonLaptop.Enabled = false;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click vào link để xem thông tin chi tiết Laptop
        /// </summary>
        /// <param name="sender">Control phát sinh sự kiện</param>
        /// <param name="e">Thông tin sự kiện</param>
        void Link_TenLaptop_Click(object sender, EventArgs e)
        {
            myChiTietDongLaptopDTO dongLaptop = (myChiTietDongLaptopDTO)((LinkLabel)sender).Tag;
            if (dongLaptop != null)
            {
                this.iMaLaptopDuocChon = dongLaptop.IMaDongLaptop;
                this.sTenLaptop = dongLaptop.STenChiTietDongLapTop;
                this.FillLaptopInfo(dongLaptop);
                button_ChonLaptop.Enabled = true;
            }
        }

        /// <summary>
        /// Hàm đổ dữ liệu vào các control tương ứng thể hiện thông tin Laptop
        /// </summary>
        /// <param name="dongLaptop">Thông tin dongLaptop để thể hiện thông tin</param>
        private void FillLaptopInfo(myChiTietDongLaptopDTO dongLaptop)
        {
            btn_TenLaptop.Text = dongLaptop.STenChiTietDongLapTop;

            // CPU:
            tB_CPU.Text = dongLaptop.ChiTietDongCPU.STenDongCPU;

            // Ổ Cứng:
            tB_OCung.Text = dongLaptop.ChiTietDongOCung.STenDongOCung;

            // RAM:
            tB_RAM.Text = dongLaptop.ChiTietDongRam.STenDongRAM;

            // Card màn hình:
            tB_CardManHinh.Text = dongLaptop.ChiTietDongCacDoHoa.STenDongCardDoHoa + "  " + dongLaptop.ChiTietDongCacDoHoa.ChiTietBoNhoCardDoHoa.STenChiTietCardDoHoa;

            // Màn hình:
            tB_ManHinh.Text = dongLaptop.ChiTietDongManHinh.STenDongManHinh;

            // Trọng lượng:
            tB_TrongLuong.Text = dongLaptop.ChiTietTrongLuong.ChiTietLoaiTrongLuong.STenLoaiTrongLuong;

            // Ổ quang:
            tB_OQuang.Text = dongLaptop.ChiTietDongODiaQuang.STenDongODiaQuang;

            // Webcam:
            tB_Webcam.Text = dongLaptop.ChiTietDongWebCam.STenDongWebCam + " (độ phân giải " + dongLaptop.ChiTietDongWebCam.FDoPhanGiai.ToString() + "MG pixel)";

            // Pin:
            tB_Pin.Text = dongLaptop.ChiTietDongPin.ChiTietThoiLuongPin.STenThoiLuongPin;

            // CardReader:
            tB_CardReader.Text = dongLaptop.ChiTietDongCardReader.ChiTietCongNgheCardReader.STenCongNgheCardReader;

            // Card mạng:
            tB_CardMang.Text = dongLaptop.ChiTietDongCardMang.ChiTietLoaiKetNoiMang.STenLoaiKetNoiCardMang;

            // Hệ điều hành:
            tB_HDH.Text = dongLaptop.ChiTietHeDieuHanh.STenHeDieuHanh;

            // Finger:
            if (dongLaptop.BFingerprintReader == 1)
            {
                tB_Finger.Text = "Có";
            }
            else
            {
                tB_Finger.Text = "Không";
            }

            // HDMI:
            if (dongLaptop.BHDMI == 1)
            {
                tB_HDMI.Text = "Có";
            }
            else
            {
                tB_HDMI.Text = "Không";
            }

            // Loa:
            if (dongLaptop.ChiTietDongLoa.BCoMicro == 1)
            {
                tB_Loa.Text = dongLaptop.ChiTietDongLoa.STenDongLoa + " (có Micro)";
            }
            else
            {
                tB_Loa.Text = dongLaptop.ChiTietDongLoa.STenDongLoa + " (không có Micro)";
            }

            // So cong USB:
            tB_SoCongUSB.Text = dongLaptop.ISoLuongCongUSB.ToString() + " cổng";

            // Mau sac:
            tB_MauSac.Text = dongLaptop.SMauSac;

            // Danh gia:
            tB_DanhGia.Text = dongLaptop.DanhGia.ITongDiem.ToString() + " điểm";

            // Mo ta them:s
            tB_MoTaThem.Text = dongLaptop.SMoTaThem;
        }

        /// <summary>
        /// Hàm xử lý sự kiện người dùng chọn mua sản phẩm
        /// </summary>
        /// <param name="sender">Control gây ra sự kiện Click</param>
        /// <param name="e">Thông tin sự kiện</param>
        private void button_ChonLaptop_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chọn mua Laptop " + this.sTenLaptop + " hay không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    bool isThemGD = MyGiaoDichBUS.ThemGiaoDich(this.LayGiaoDichHienTai());
                    if (isThemGD)
                    {
                        MessageBox.Show("Bạn đã chọn Laptop " + this.sTenLaptop + "! Bạn vui lòng đến quày thu ngân làm thủ tục !", "Thông báo");

                        this.button_Back_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Giao dịch thành công !", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }
            }
        }

        /// <summary>
        /// Lấy giao dịch hiện tại
        /// </summary>
        /// <returns>
        ///     Trả về đối tượng GIAODICH hiện tại 
        /// </returns>
        private GIAODICH LayGiaoDichHienTai()
        {
            GIAODICH giaoDich = new GIAODICH();
            giaoDich.KHACHHANG = MANHINHCHINH.KKhachHang;
            giaoDich.MaDongLaptop = this.iMaLaptopDuocChon;
            giaoDich.NgayMua = DateTime.Now;

            return giaoDich;
        }
    }
}
