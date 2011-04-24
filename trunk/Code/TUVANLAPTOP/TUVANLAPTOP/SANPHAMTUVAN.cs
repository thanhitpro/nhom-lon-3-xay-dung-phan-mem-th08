using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EStoreDTO;
using EStoreBUS;
using EStoreDAO;

namespace TUVANLAPTOP
{
    public partial class SANPHAMTUVAN : Form
    {
        private int m_iMaLaptopDuocChon;
        private string m_sTenLaptop = "";
        private static SANPHAMTUVAN aForm = null;

        public static SANPHAMTUVAN Instance()
        {
            if (aForm == null)
            {
                aForm = new SANPHAMTUVAN();
            }
            return aForm;
        }
        private SANPHAMTUVAN()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm xử lý khi click button BACK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
            MANHINHCHINH.KKhachHang = null;
        }

        /// <summary>
        /// Hàm xử lý sự kiện load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SANPHAMTUVAN_Load(object sender, EventArgs e)
        {
            clearData();
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
                            UC_SanPham sanPhamControl = new UC_SanPham(laptop);
                            sanPhamControl.Link_TenLaptop.Click += new EventHandler(Link_TenLaptop_Click);
                            flp_DSLaptop.Controls.Add(sanPhamControl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }

            //Disable button chọn SP:
            button_ChonLaptop.Enabled = false;
            button1.Enabled = false;
        }

        /// <summary>
        /// Xử lý sự kiện Click vào link để xem chi tiết laptop:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        myChiTietDongLaptopDTO dongLapTopTemp = new myChiTietDongLaptopDTO();

        void Link_TenLaptop_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                myChiTietDongLaptopDTO dongLaptop = (myChiTietDongLaptopDTO)((LinkLabel)sender).Tag;
                dongLapTopTemp = dongLaptop;
                if (dongLaptop != null)
                {
                    try
                    {
                        m_iMaLaptopDuocChon = dongLaptop.IMaDongLaptop;
                        m_sTenLaptop = dongLaptop.STenChiTietDongLapTop;

                        btn_TenLaptop.Text = dongLaptop.STenChiTietDongLapTop;

                        //CPU:
                        tB_CPU.Text = dongLaptop.ChiTietDongCPU.STenDongCPU;

                        //O Cung:
                        tB_OCung.Text = dongLaptop.ChiTietDongOCung.STenDongOCung;

                        //RAM:
                        tB_RAM.Text = dongLaptop.ChiTietDongRam.STenDongRAM;

                        //Card man hinh:
                        tB_CardManHinh.Text = dongLaptop.ChiTietDongCacDoHoa.STenDongCardDoHoa + "  " + dongLaptop.ChiTietDongCacDoHoa.ChiTietBoNhoCardDoHoa.STenChiTietCardDoHoa;

                        //Man hinh:
                        tB_ManHinh.Text = dongLaptop.ChiTietDongManHinh.STenDongManHinh;

                        //Trong luong:
                        tB_TrongLuong.Text = dongLaptop.ChiTietTrongLuong.ChiTietLoaiTrongLuong.STenLoaiTrongLuong;

                        //O quang:
                        tB_OQuang.Text = dongLaptop.ChiTietDongODiaQuang.STenDongODiaQuang;

                        //Webcam:
                        tB_Webcam.Text = dongLaptop.ChiTietDongWebCam.STenDongWebCam + " (độ phân giải " + dongLaptop.ChiTietDongWebCam.FDoPhanGiai.ToString() + "MG pixel)";

                        //Pin:
                        tB_Pin.Text = dongLaptop.ChiTietDongPin.ChiTietThoiLuongPin.STenThoiLuongPin;

                        //CardReader:
                        tB_CardReader.Text = dongLaptop.ChiTietDongCardReader.ChiTietCongNgheCardReader.STenCongNgheCardReader;

                        //Card mang:
                        tB_CardMang.Text = dongLaptop.ChiTietDongCardMang.ChiTietLoaiKetNoiMang.STenLoaiKetNoiCardMang;

                        //HDH:
                        tB_HDH.Text = dongLaptop.ChiTietHeDieuHanh.STenHeDieuHanh;

                        //Finger:
                        if (dongLaptop.BFingerprintReader == 1)
                            tB_Finger.Text = "Có";
                        else
                            tB_Finger.Text = "Không";

                        //HDMI:
                        if (dongLaptop.BHDMI == 1)
                            tB_HDMI.Text = "Có";
                        else
                            tB_HDMI.Text = "Không";

                        //Loa:
                        if (dongLaptop.ChiTietDongLoa.BCoMicro == 1)
                            tB_Loa.Text = dongLaptop.ChiTietDongLoa.STenDongLoa + " (có Micro)";
                        else
                            tB_Loa.Text = dongLaptop.ChiTietDongLoa.STenDongLoa + " (không có Micro)";

                        //So cong USB:
                        tB_SoCongUSB.Text = dongLaptop.ISoLuongCongUSB.ToString() + " cổng";

                        //Mau sac:
                        tB_MauSac.Text = dongLaptop.SMauSac;

                        //Danh gia:
                        tB_DanhGia.Text = dongLaptop.DanhGia.ITongDiem.ToString() + " điểm";

                        //Mo ta them:s
                        tB_MoTaThem.Text = dongLaptop.SMoTaThem;

                        //Enable button ChonLaptop:
                        button_ChonLaptop.Enabled = true;
                        button1.Enabled = true;
                    }
                    catch (NullReferenceException nullEx)
                    {
                        //Bỏ qua nếu có một thuộc tính nào đó NULL
                    }
                }
                else
                    MessageBox.Show("Không có thông tin về Laptop " + dongLaptop.STenChiTietDongLapTop + " !");
            }
        }

        /// <summary>
        /// Ham xu ly khi Khach Hang ChonMuaSP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNhapThongTin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn chọn mua Laptop " + m_sTenLaptop + " hay không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    KHACHHANG khachHang = MANHINHCHINH.KKhachHang;

                    if (myKhachHangBUS.themKhachHang(khachHang) == false)
                    {
                        MessageBox.Show("Có lỗi xảy ra ! Xin thử lại ...", "Thông báo");
                        return;
                    }

                    GIAODICH giaoDich = new GIAODICH();
                    giaoDich.MaKhachHang = khachHang.MaKhachHang;
                    giaoDich.MaDongLaptop = m_iMaLaptopDuocChon;
                    giaoDich.NgayMua = DateTime.Now;

                    if (myGiaoDichBUS.themGiaoDich(giaoDich))
                    {
                        MessageBox.Show("Bạn đã chọn Laptop " + m_sTenLaptop + "! Bạn vui lòng đến quày thu ngân làm thủ tục !", "Thông báo");

                        button_Back_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Thêm giao dịch hiện tại không thành công ! Xin thử lại ...", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }
            }
        }

        /// <summary>
        /// Hàm clear dữ liệu
        /// </summary>
        public void clearData()
        {
            flp_DSLaptop.Controls.Clear();

            //Ten Laptop
            btn_TenLaptop.Text = null;

            //CPU:
            tB_CPU.Text = null;

            //O Cung:
            tB_OCung.Text = null;

            //RAM:
            tB_RAM.Text = null;

            //Card man hinh:
            tB_CardManHinh.Text = null;

            //Man hinh:
            tB_ManHinh.Text = null;

            //Trong luong:
            tB_TrongLuong.Text = null;

            //O quang:
            tB_OQuang.Text = null;

            //Webcam:
            tB_Webcam.Text = null;

            //Pin:
            tB_Pin.Text = null;

            //CardReader:
            tB_CardReader.Text = null;

            //Card mang:
            tB_CardMang.Text = null;

            //HDH:
            tB_HDH.Text = null;

            //Finger:
            tB_Finger.Text = null;

            //HDMI:
            tB_HDMI.Text = null;

            //Loa:
            tB_Loa.Text = null;

            //So cong USB:
            tB_SoCongUSB.Text = null;

            //Mau sac:
            tB_MauSac.Text = null;

            //Danh gia:
            tB_DanhGia.Text = null;

            //Mo ta them:
            tB_MoTaThem.Text = null;

            //Enable button ChonLaptop:
            button_ChonLaptop.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dongLapTopTemp != null)
                {
                    List<myChiTietDongLaptopDTO> danhSachLapTopCungLoai = myChiTietDongLaptopBUS.LayChiTietDongLaptopMoiNhat(dongLapTopTemp);
                    SANPHAMMOI frm = new SANPHAMMOI();
                    frm.Tag = danhSachLapTopCungLoai;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn hãy chọn sản phẩm trước khi tìm sản phẩm mới hơn");
            }
        }
    }
}
