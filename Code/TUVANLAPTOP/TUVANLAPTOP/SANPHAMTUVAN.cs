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
    public partial class SANPHAMTUVAN : Form
    {
        private static SANPHAMTUVAN curForm = null;
        private int intMaLaptopDuocChon;
        private string tenLaptop = String.Empty;
        myChiTietDongLaptopDTO dongLapTopTemp = new myChiTietDongLaptopDTO();

        private SANPHAMTUVAN()
        {
            InitializeComponent();
        }

        public static SANPHAMTUVAN Instance()
        {
            if (curForm == null)
            {
                curForm = new SANPHAMTUVAN();
            }

            return curForm;
        }

        /// <summary>
        /// Hàm xử lý khi click button BACK
        /// </summary>
        /// <param name="sender">Control phát sinh sự kiện</param>
        /// <param name="e">Thông tin sự kiện</param>
        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
            MANHINHCHINH.KKhachHang = null;
        }

        /// <summary>
        /// Hàm xử lý sự kiện load Form
        /// </summary>
        /// <param name="sender">Đối tượng gây ra sự kiện</param>
        /// <param name="e">Thông tin sự kiện</param>
        private void SANPHAMTUVAN_Load(object sender, EventArgs e)
        {
            this.ClearData();
            List<int> listIDLaptopTuVan = new List<int>();
            try
            {
                listIDLaptopTuVan = (List<int>)this.Tag;
                if (listIDLaptopTuVan.Count == 0)
                {
                    btn_SoSP.Text = "KHÔNG CÓ LAPTOP NÀO PHÙ HỢP VỚI BẠN ! THỬ LẠI...";
                }
                else
                {
                    btn_SoSP.Text = string.Format("CÓ {0} LAPTOP PHÙ HỢP VỚI BẠN !", listIDLaptopTuVan.Count);
                    foreach (int laptopID in listIDLaptopTuVan)
                    {
                        myChiTietDongLaptopDTO laptop = myChiTietDongLaptopBUS.LayChiTietDongLaptop(laptopID + 1);
                        if (laptop != null)
                        {
                            UC_SANPHAM sanPhamControl = new UC_SANPHAM(laptop);
                            sanPhamControl.Link_TenLaptop.Click += new EventHandler(this.Link_TenLaptop_Click);
                            flp_DSLaptop.Controls.Add(sanPhamControl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }

            // Disable button chọn SP:
            button_ChonLaptop.Enabled = false;
            BtnSanPhamMoi.Enabled = false;
        }

        /// <summary>
        /// Xử lý sự kiện Click vào link để xem chi tiết laptop:
        /// </summary>
        /// <param name="sender">Control gây ra sự kiện Click</param>
        /// <param name="e">Thông tin sự kiện</param>
        void Link_TenLaptop_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                myChiTietDongLaptopDTO dongLaptop = (myChiTietDongLaptopDTO)((LinkLabel)sender).Tag;
                this.dongLapTopTemp = dongLaptop;
                if (dongLaptop != null)
                {
                    try
                    {
                        this.intMaLaptopDuocChon = dongLaptop.IMaDongLaptop;
                        this.tenLaptop = dongLaptop.STenChiTietDongLapTop;
                        this.FillLaptopInfo(dongLaptop);

                        // Enable button ChonLaptop:
                        button_ChonLaptop.Enabled = true;
                        BtnSanPhamMoi.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Có một số thông tin về Laptop này chưa có !", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Không có thông tin về Laptop " + dongLaptop.STenChiTietDongLapTop + " !");
                }
            }
        }

        /// <summary>
        /// Hàm đổ dữ liệu của dòng Laptop chỉ định lên các control để hiện thị nội dung chi tiết dòng Laptop
        /// </summary>
        /// <param name="dongLaptop">Thông tin dòng Laptop cần thể hiện thông tin chi tiết</param>
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
        private void buttonNhapThongTin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chọn mua Laptop " + this.tenLaptop + " hay không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    bool isThemGD = myGiaoDichBUS.themGiaoDich(this.LayGiaoDichHienTai());
                    if (isThemGD)
                    {
                        MessageBox.Show("Bạn đã chọn Laptop " + this.tenLaptop + "! Bạn vui lòng đến quày thu ngân làm thủ tục !", "Thông báo");

                        this.button_Back_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm giao dịch hiện tại không thành công ! Xin thử lại ...", "Thông báo");
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
            giaoDich.MaDongLaptop = this.intMaLaptopDuocChon;
            giaoDich.NgayMua = DateTime.Now;

            return giaoDich;
        }

        /// <summary>
        /// Hàm clear dữ liệu
        /// </summary>
        private void ClearData()
        {
            flp_DSLaptop.Controls.Clear();

            // Ten Laptop
            btn_TenLaptop.Text = null;

            // CPU:
            tB_CPU.Text = null;

            // O Cung:
            tB_OCung.Text = null;

            // RAM:
            tB_RAM.Text = null;

            // Card man hinh:
            tB_CardManHinh.Text = null;

            // Man hinh:
            tB_ManHinh.Text = null;

            // Trong luong:
            tB_TrongLuong.Text = null;

            // O quang:
            tB_OQuang.Text = null;

            // Webcam:
            tB_Webcam.Text = null;

            // Pin:
            tB_Pin.Text = null;

            // CardReader:
            tB_CardReader.Text = null;

            // Card mang:
            tB_CardMang.Text = null;

            // HDH:
            tB_HDH.Text = null;

            // Finger:
            tB_Finger.Text = null;

            // HDMI:
            tB_HDMI.Text = null;

            // Loa:
            tB_Loa.Text = null;

            // So cong USB:
            tB_SoCongUSB.Text = null;

            // Mau sac:
            tB_MauSac.Text = null;

            // Danh gia:
            tB_DanhGia.Text = null;

            // Mo ta them:
            tB_MoTaThem.Text = null;

            // Enable button ChonLaptop:
            button_ChonLaptop.Enabled = false;
        }

        /// <summary>
        /// Hàm xử lý sự kiện lấy sản phẩm mới cùng loại
        /// </summary>
        /// <param name="sender">Control phát sinh sự kiện</param>
        /// <param name="e">Thông tin sự kiện</param>
        private void BtnSanPhamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dongLapTopTemp != null)
                {
                    List<myChiTietDongLaptopDTO> danhSachLapTopCungLoai = myChiTietDongLaptopBUS.LayChiTietDongLaptopMoiNhat(this.dongLapTopTemp);
                    SANPHAMMOI frm = new SANPHAMMOI();
                    frm.Tag = danhSachLapTopCungLoai;
                    frm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Bạn hãy chọn sản phẩm trước khi tìm sản phẩm mới hơn");
            }
        }
    }
}
