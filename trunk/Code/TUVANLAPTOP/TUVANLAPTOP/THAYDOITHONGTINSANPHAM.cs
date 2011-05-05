using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EStoreBUS;
using EStoreDTO;
using EStoreDAO;

namespace TUVANLAPTOP
{
    public partial class THAYDOI_THONGTINSANPHAM : Form
    {
        public THAYDOI_THONGTINSANPHAM()
        {
            InitializeComponent();
            LoadInfor();
        }
        private myChiTietDongLaptopDTO LaptopInfor = null;
        private String fileName = "";
        /// <summary>
        /// Load các thông tin ban đầu cho combobox và textbox
        /// </summary>
        private void LoadInfor()
        {
            // Load Ram
            myChiTietDongRamBUS chiTietDongRam = new myChiTietDongRamBUS();
            List<myChiTietDongRamDTO> dsDongRam = new List<myChiTietDongRamDTO>();
            try
            {
                dsDongRam = chiTietDongRam.LayChiTietDongRam();
            }
            catch
            {
                dsDongRam = null;
            }
            if (dsDongRam != null)
            {
                foreach (myChiTietDongRamDTO ram in dsDongRam)
                {
                    cbb_ram.Items.Add(ram);
                }
                cbb_ram.DisplayMember = "STenDongRAM";
                cbb_ram.SelectedItem = cbb_ram.Items[0];
            }

            // Load CPUs
            myChiTietDongCPUBUS chiTietDongCPU = new myChiTietDongCPUBUS();
            List<myChiTietDongCPUDTO> dsDongCPU = new List<myChiTietDongCPUDTO>();
            try
            {
                dsDongCPU = chiTietDongCPU.LayChiTietDongCPU();
            }
            catch
            {
                dsDongCPU = null;
            }
            if (dsDongCPU != null)
            {
                foreach (myChiTietDongCPUDTO cpu in dsDongCPU)
                {
                    cbb_cpu.Items.Add(cpu);
                }
                cbb_cpu.DisplayMember = "STenDongCPU";
                cbb_cpu.SelectedItem = cbb_cpu.Items[0];
            }
            // Load O Cung
            myChiTietDongOCungBUS chiTietDongOCung = new myChiTietDongOCungBUS();
            List<myChiTietDongOCungDTO> dsDongOCung = new List<myChiTietDongOCungDTO>();
            try
            {
                dsDongOCung = chiTietDongOCung.LayChiTietDongOCung();
            }
            catch
            {
                dsDongOCung = null;
            }
            if (dsDongOCung != null)
            {
                foreach (myChiTietDongOCungDTO ocung in dsDongOCung)
                {
                    cbb_ocung.Items.Add(ocung);
                }
                cbb_ocung.DisplayMember = "STenDongOCung";
                cbb_ocung.SelectedItem = cbb_ocung.Items[0];
            }

            // Load Man Hinh
            myChiTietDongManHinhBUS chiTietManHinh = new myChiTietDongManHinhBUS();
            List<myChiTietDongManHinhDTO> dsManHinh = new List<myChiTietDongManHinhDTO>();
            try
            {
                dsManHinh = chiTietManHinh.LayChiTietDongManHinh();
            }
            catch 
            {
                dsManHinh = null;
            }
            if (dsManHinh != null)
            {
                foreach (myChiTietDongManHinhDTO manhinh in dsManHinh)
                {
                    cbb_manhinh.Items.Add(manhinh);
                }
                cbb_manhinh.DisplayMember = "STenDongManHinh";
                cbb_manhinh.SelectedItem = cbb_manhinh.Items[0];
            }

            // Load Card Mang Hinh
            myChiTietDongCardDoHoaBUS chiTietCardDoHoa = new myChiTietDongCardDoHoaBUS();
            List<myChiTietDongCardDoHoaDTO> dsCardDoHoa = new List<myChiTietDongCardDoHoaDTO>();
            try
            {
                dsCardDoHoa = chiTietCardDoHoa.LayChiTietDongCardDoHoa();
            }
            catch
            {
                dsCardDoHoa = null;
            }
            if (dsCardDoHoa != null)
            {
                foreach (myChiTietDongCardDoHoaDTO carddohoa in dsCardDoHoa)
                {
                    cbb_cardmanhinh.Items.Add(carddohoa);
                }
                cbb_cardmanhinh.DisplayMember = "STenDongCardDoHoa";
                cbb_cardmanhinh.SelectedItem = cbb_cardmanhinh.Items[0];
            }

            // Load Dong Loa
            myChiTietDongLoaBUS chiTietDongLoa = new myChiTietDongLoaBUS();
            List<myChiTietDongLoaDTO> dsLoa = new List<myChiTietDongLoaDTO>();
            try
            {
                dsLoa = chiTietDongLoa.LayChiTietDongLoa();
            }
            catch
            {
                dsLoa = null;
            }
            if (dsLoa != null)
            {
                foreach (myChiTietDongLoaDTO loa in dsLoa)
                {
                    cbb_loa.Items.Add(loa);
                }
                cbb_loa.DisplayMember = "STenDongLoa";
                cbb_loa.SelectedItem = cbb_loa.Items[0];
            }
            // Load O Quang
            myChiTietDongODiaQuangBUS chiTietDongDQ = new myChiTietDongODiaQuangBUS();
            List<myChiTietDongODiaQuangDTO> dsDiaQuang = new List<myChiTietDongODiaQuangDTO>();
            try
            {
                dsDiaQuang = chiTietDongDQ.LayChiTietDongODiaQuang();
            }
            catch
            {
                dsDiaQuang = null;
            }
            if (dsDongRam != null)
            {
                foreach (myChiTietDongODiaQuangDTO diaquang in dsDiaQuang)
                {
                    cbb_oquang.Items.Add(diaquang);
                }
                cbb_oquang.DisplayMember = "STenDongODiaQuang";
                cbb_oquang.SelectedItem = cbb_oquang.Items[0];
            }

            //Load HDH
            myChiTietHeDieuHanhBUS chiTietHDH = new myChiTietHeDieuHanhBUS();
            List<myChiTietHeDieuHanhDTO> dsHDH = new List<myChiTietHeDieuHanhDTO>();
            try
            {
                dsHDH = chiTietHDH.LayChiTietHeDieuHanh();
            }
            catch
            {
                dsHDH = null;
            }
            if (dsHDH != null)
            {
                foreach (myChiTietHeDieuHanhDTO hdh in dsHDH)
                {
                    cbb_hdh.Items.Add(hdh);
                }
                cbb_hdh.DisplayMember = "STenHeDieuHanh";
                cbb_hdh.SelectedItem = cbb_hdh.Items[0];
            }

            //Load Trong Luong
            myChiTietTrongLuongBUS chiTietTL = new myChiTietTrongLuongBUS();
            List<myChiTietTrongLuongDTO> dsTrongLuong = new List<myChiTietTrongLuongDTO>();
            try
            {
                dsTrongLuong = chiTietTL.LayChiTietTrongLuong();
            }
            catch 
            {
                dsTrongLuong = null;
            }
            if (dsTrongLuong != null)
            {
                foreach (myChiTietTrongLuongDTO trongluong in dsTrongLuong)
                {
                    cbb_trongluong.Items.Add(trongluong);

                }
                cbb_trongluong.DisplayMember = "FGiaTriTrongLuong";
                cbb_trongluong.SelectedItem = cbb_trongluong.Items[0];
            }

            //Load Ten Dong LapTop & Mau Sac & Thoi Gian Bao Hanh & Gia Ban

            List<myChiTietDongLaptopDTO> dsLapTop = new List<myChiTietDongLaptopDTO>();
            try
            {
                dsLapTop = myChiTietDongLaptopBUS.LayChiTietDongLaptop();
            }
            catch
            {
                dsLapTop = null;
            }
            // - Mau Sac-
            if (dsLapTop != null)
            {
                foreach (myChiTietDongLaptopDTO laptop in dsLapTop)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_mausac.Items.Count; index++)
                    {
                        if (string.Compare(cbb_mausac.Items[index].ToString().Trim(), laptop.SMauSac.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_mausac.Items.Add(laptop.SMauSac);
                }

                cbb_mausac.SelectedItem = cbb_mausac.Items[0];
                // - Thoi Gian Bao Hanh
                foreach (myChiTietDongLaptopDTO laptop in dsLapTop)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_thoigian_bh.Items.Count; index++)
                    {
                        if (string.Compare(cbb_thoigian_bh.Items[index].ToString().Trim(), laptop.IThoiGianBaoHanh.ToString().Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_thoigian_bh.Items.Add(laptop.IThoiGianBaoHanh);
                }
                cbb_thoigian_bh.SelectedItem = cbb_thoigian_bh.Items[0];
            }

            //Load Card Mạng
            myChiTietDongCardMangBUS chiTietCardMang = new myChiTietDongCardMangBUS();
            List<myChiTietDongCardMangDTO> dsCardMang = new List<myChiTietDongCardMangDTO>();
            try
            {
                dsCardMang = chiTietCardMang.LayChiTietDongCardMang();
            }
            catch 
            {
                dsCardMang = null;
            }
            if (dsCardMang != null)
            {
                foreach (myChiTietDongCardMangDTO cardmang in dsCardMang)
                {
                    cbb_cardmang.Items.Add(cardmang);
                }
                cbb_cardmang.DisplayMember = "STenDongCardMang";
                cbb_cardmang.SelectedItem = cbb_cardmang.Items[0];
            }

            //Load CardReader
            myChiTietDongCardReaderBUS chiTietCardReader = new myChiTietDongCardReaderBUS();
            List<myChiTietDongCardReaderDTO> dsCardReader = new List<myChiTietDongCardReaderDTO>();
            try
            {
                dsCardReader = chiTietCardReader.LayChiTietDongCardReader();
            }
            catch
            {
                dsCardReader = null;
            }
            if (dsCardReader != null)
            {
                foreach (myChiTietDongCardReaderDTO cardreader in dsCardReader)
                {
                    cbb_cardreader.Items.Add(cardreader);
                }
                cbb_cardreader.DisplayMember = "STenDongCardReader";
                cbb_cardreader.SelectedItem = cbb_cardreader.Items[0];
            }

            //Load WebCam
            myChiTietDongWebcamBUS chiTietWebCam = new myChiTietDongWebcamBUS();
            List<myChiTietDongWebcamDTO> dsWebcam = new List<myChiTietDongWebcamDTO>();
            try
            {
                dsWebcam = chiTietWebCam.LayChiTietDongWebcam();
            }
            catch 
            {
                dsWebcam = null;
            }
            if (dsWebcam != null)
            {
                foreach (myChiTietDongWebcamDTO webcam in dsWebcam)
                {
                    cbb_webcam.Items.Add(webcam);
                }
                cbb_webcam.DisplayMember = "STenDongWebcam";
                cbb_webcam.SelectedItem = cbb_webcam.Items[0];
            }

            //Load Pin
            myChiTietDongPinBUS chiTietPin = new myChiTietDongPinBUS();
            List<myChiTietDongPinDTO> dsPin = new List<myChiTietDongPinDTO>();
            try
            {
                dsPin = chiTietPin.LayChiTietDongPin();
            }
            catch 
            {
                dsPin = null;
            }

            if (dsPin != null)
            {
                foreach (myChiTietDongPinDTO pin in dsPin)
                {
                    cbb_pin.Items.Add(pin);

                }
                cbb_pin.DisplayMember = "FTenDongPin";
                cbb_pin.SelectedItem = cbb_pin.Items[0];
            }

            //Load Kha Nang Nhan Dang Van Tay
            cbb_vantay.Items.Add("Có");
            cbb_vantay.Items.Add("Không");
            cbb_vantay.SelectedItem = cbb_vantay.Items[0];

            //Load Cong HDMI
            cbb_hdmi.Items.Add("Có");
            cbb_hdmi.Items.Add("Không");
            cbb_hdmi.SelectedItem = cbb_hdmi.Items[0];

            // Load So Cong USB
            cbb_usb.Items.Add("1");
            cbb_usb.Items.Add("2");
            cbb_usb.Items.Add("3");
            cbb_usb.Items.Add("4");
            cbb_usb.SelectedItem = cbb_usb.Items[0];

            // Load Nha SX
            myNhaSanXuatBUS nhaSX = new myNhaSanXuatBUS();
            List<myNhaSanXuatDTO> dsNhaSX = new List<myNhaSanXuatDTO>();
            try
            {
                dsNhaSX = nhaSX.LayNhaSanXuat();
            }
            catch 
            {
                dsNhaSX = null;
            }
            if (dsNhaSX != null)
            {
                foreach (myNhaSanXuatDTO nhasx in dsNhaSX)
                {
                    cbb_nhasx.Items.Add(nhasx);
                }
                cbb_nhasx.DisplayMember = "STenNhaSanXuat";
                cbb_nhasx.SelectedItem = cbb_nhasx.Items[0];
            }
        }

        /// <summary>
        /// Kiểm tra mã sản phẩm
        /// </summary>
        /// <param name="str"> Mã sản phẩm</param>
        /// <returns></returns>

        private bool KiemtraKyTu(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 48 || str[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Thoát khỏi chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Tra cứu thông tin laptop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tracuu_Click(object sender, EventArgs e)
        {
            gb_ThayDoiThongTin.Enabled = false;
            btn_capnhat.Enabled = false;
            String textTraCuu = "";

            if (String.Compare(txt_masp.Text.Trim(), "") == 0)
            {
                MessageBox.Show("Nhập thông tin cần tra cứu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!KiemtraKyTu(txt_masp.Text.Trim()))
                {
                    MessageBox.Show("Mã sản phẩm là kiểu số. Xin vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    textTraCuu = txt_masp.Text;
                }

            }
            //lay du lieu chi tiet 1 dong laptop
            myChiTietDongLaptopDTO laptop = new myChiTietDongLaptopDTO();
            try
            {
                laptop = myChiTietDongLaptopBUS.LayChiTietDongLaptop(int.Parse(textTraCuu.ToString().Trim()));
            }
            catch 
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu. Vui lòng thực hiện lại thao tác tra cứu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LaptopInfor = laptop;
            if (laptop == null)
            {
                dtgw_LapTop.Rows.Clear();
                MessageBox.Show("Không tìm thấy kết quả tra cứu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //add dong du lieu vao datagrid view
            dtgw_LapTop.Rows.Clear();

            dtgw_LapTop.Rows.Add(
                //mã dòng lap top
                laptop.IMaDongLaptop.ToString(),
                //tên dòng lap top
                laptop.STenChiTietDongLapTop,
                //tên ram
                laptop.ChiTietDongRam.STenDongRAM,
                //CPu
                laptop.ChiTietDongCPU.STenDongCPU,
                //o cung
                laptop.ChiTietDongOCung.STenDongOCung,
                //man hinh
                laptop.ChiTietDongManHinh.STenDongManHinh,
                //card man hih
                laptop.ChiTietDongCacDoHoa.STenDongCardDoHoa,
                //dong loa
                laptop.ChiTietDongLoa.STenDongLoa,
                //o quang
                laptop.ChiTietDongODiaQuang.STenDongODiaQuang,
                //he dieu hanh
                laptop.ChiTietHeDieuHanh.STenHeDieuHanh,
                //trong luong
                laptop.ChiTietTrongLuong.ChiTietLoaiTrongLuong.STenLoaiTrongLuong,
                //mau sac
                laptop.SMauSac,
                //card mang
                laptop.ChiTietDongCardMang.STenDongCardMang,
                //card reader
                laptop.ChiTietDongCardReader.STenDongCardReader,
                //webcam
                laptop.ChiTietDongWebCam.STenDongWebCam,
                //pin
                laptop.ChiTietDongPin.FTenDongPin,
                //nhan dang van tay
                (laptop.BFingerprintReader == 1) ? "Có" : "Không",
                //usb
                laptop.ISoLuongCongUSB,
                //cong HDMI
                (laptop.BHDMI == 1) ? "Có" : "Không",
                //nha san xuat
                laptop.NhaSanXuat.STenNhaSanXuat,
                //thoi gian bao hanh
                laptop.IThoiGianBaoHanh,
                //gia ban
                laptop.FGiaBanHienHanh,
                //so luong nhap
                laptop.ISoLuongNhap,
                // Ngay nhap
                laptop.DNgayNhap.Day.ToString() + "/" + laptop.DNgayNhap.Month.ToString() + "/" + laptop.DNgayNhap.Year.ToString(),
                //mo ta them
                laptop.SMoTaThem
                );
            ResetInfor();
        }

        /// <summary>
        /// Khởi tạo các thông tin ban đầu cho các combobox và textbox
        /// </summary>
        private void ResetInfor()
        {
            // Koi tao thong tin cac textbox
            txtTenDongLapTop.Text = "";
            txt_giaban.Text = "";
            txt_SoLuong.Text = "";
            txt_MoTaThem.Text = "";
            dtp_ngaynhap.Value = DateTime.Now;
            pb_picture.ImageLocation = "../../Resources/question.png";

            //Khoi tao thong tin cac combobox
            cbb_ram.SelectedIndex = 0;
            cbb_cpu.SelectedIndex = 0;
            cbb_ocung.SelectedIndex = 0;
            cbb_manhinh.SelectedIndex = 0;
            cbb_cardmanhinh.SelectedIndex = 0;
            cbb_loa.SelectedIndex = 0;
            cbb_oquang.SelectedIndex = 0;
            cbb_hdh.SelectedIndex = 0;
            cbb_trongluong.SelectedIndex = 0;
            cbb_mausac.SelectedIndex = 0;
            cbb_cardmang.SelectedIndex = 0;
            cbb_cardreader.SelectedIndex = 0;
            cbb_webcam.SelectedIndex = 0;
            cbb_pin.SelectedIndex = 0;
            cbb_vantay.SelectedIndex = 0;
            cbb_usb.SelectedIndex = 0;
            cbb_hdmi.SelectedIndex = 0;
            cbb_nhasx.SelectedIndex = 0;
            cbb_thoigian_bh.SelectedIndex = 0;

        }

        /// <summary>
        /// Lay index cua mot item trong combobox
        /// </summary>
        /// <param name="m_cbb"> combobox can lay dia chi chi cho item</param>
        /// <param name="CompareStr">chuoi so sanh</param>
        /// <returns></returns>
        private int GetIndexItem(ComboBox m_cbb, String CompareStr)
        {

            for (int count = 0; count < m_cbb.Items.Count; count++)
            {
                string Str = "";

                if (m_cbb == cbb_ram)
                {
                    myChiTietDongRamDTO ram = (myChiTietDongRamDTO)m_cbb.Items[count];
                    Str = ram.STenDongRAM;
                }
                else if (m_cbb == cbb_cpu)
                {
                    myChiTietDongCPUDTO cpu = (myChiTietDongCPUDTO)m_cbb.Items[count];
                    Str = cpu.STenDongCPU;
                }
                else if (m_cbb == cbb_ocung)
                {
                    myChiTietDongOCungDTO ocung = (myChiTietDongOCungDTO)m_cbb.Items[count];
                    Str = ocung.STenDongOCung;
                }
                else if (m_cbb == cbb_manhinh)
                {
                    myChiTietDongManHinhDTO manhinh = (myChiTietDongManHinhDTO)m_cbb.Items[count];
                    Str = manhinh.STenDongManHinh;
                }
                else if (m_cbb == cbb_cardmanhinh)
                {
                    myChiTietDongCardDoHoaDTO carddohoa = (myChiTietDongCardDoHoaDTO)m_cbb.Items[count];
                    Str = carddohoa.STenDongCardDoHoa;
                }
                else if (m_cbb == cbb_loa)
                {
                    myChiTietDongLoaDTO loa = (myChiTietDongLoaDTO)m_cbb.Items[count];
                    Str = loa.STenDongLoa;
                }
                else if (m_cbb == cbb_oquang)
                {
                    myChiTietDongODiaQuangDTO oquang = (myChiTietDongODiaQuangDTO)m_cbb.Items[count];
                    Str = oquang.STenDongODiaQuang;
                }
                else if (m_cbb == cbb_hdh)
                {
                    myChiTietHeDieuHanhDTO hdh = (myChiTietHeDieuHanhDTO)m_cbb.Items[count];
                    Str = hdh.STenHeDieuHanh;
                }
                else if (m_cbb == cbb_trongluong)
                {
                    myChiTietTrongLuongDTO trongluong = (myChiTietTrongLuongDTO)m_cbb.Items[count];
                    Str = trongluong.FGiaTriTrongLuong.ToString();
                }
                else if (m_cbb == cbb_mausac)
                {
                    Str = m_cbb.Items[count].ToString();
                }
                else if (m_cbb == cbb_cardmang)
                {
                    myChiTietDongCardMangDTO cardmang = (myChiTietDongCardMangDTO)m_cbb.Items[count];
                    Str = cardmang.STenDongCardMang;
                }
                else if (m_cbb == cbb_cardreader)
                {
                    myChiTietDongCardReaderDTO cardreader = (myChiTietDongCardReaderDTO)m_cbb.Items[count];
                    Str = cardreader.STenDongCardReader;
                }
                else if (m_cbb == cbb_webcam)
                {
                    myChiTietDongWebcamDTO webcam = (myChiTietDongWebcamDTO)m_cbb.Items[count];
                    Str = webcam.STenDongWebCam;
                }
                else if (m_cbb == cbb_pin)
                {
                    myChiTietDongPinDTO pin = (myChiTietDongPinDTO)m_cbb.Items[count];
                    Str = pin.FTenDongPin;
                }
                else if (m_cbb == cbb_vantay)
                {
                    Str = m_cbb.Items[count].ToString();
                }
                else if (m_cbb == cbb_hdmi)
                {
                    Str = m_cbb.Items[count].ToString();
                }
                else if (m_cbb == cbb_usb)
                {
                    Str = m_cbb.Items[count].ToString();
                }
                else if (m_cbb == cbb_nhasx)
                {
                    myNhaSanXuatDTO nhasx = (myNhaSanXuatDTO)m_cbb.Items[count];
                    Str = nhasx.STenNhaSanXuat;
                }
                else if (m_cbb == cbb_thoigian_bh)
                {
                    Str = m_cbb.Items[count].ToString();
                }
                else
                    Str = m_cbb.Items[count].ToString();
                if (String.Compare(Str.Trim(), CompareStr.Trim(), true) == 0)
                    return count;
            }
            return 0;
        }

        /// <summary>
        /// Hiển thị các thông tin từ datagridview vào combobox và textbox
        /// </summary>
        private void HienThiThongTin()
        {
            if (LaptopInfor == null)
                return;
            gb_ThayDoiThongTin.Enabled = true;
            btn_capnhat.Enabled = true;
            txtTenDongLapTop.Text = LaptopInfor.STenChiTietDongLapTop;
            txt_giaban.Text = LaptopInfor.FGiaBanHienHanh.ToString().Trim();
            txt_SoLuong.Text = LaptopInfor.ISoLuongNhap.ToString().Trim();
            txt_MoTaThem.Text = LaptopInfor.SMoTaThem;
            dtp_ngaynhap.Value = LaptopInfor.DNgayNhap;


            myChiTietDongRamDTO ram = new myChiTietDongRamDTO();
            ram = LaptopInfor.ChiTietDongRam;
            cbb_ram.SelectedIndex = GetIndexItem(cbb_ram, ram.STenDongRAM);

            myChiTietDongCPUDTO cpu = new myChiTietDongCPUDTO();
            cpu = LaptopInfor.ChiTietDongCPU;
            cbb_cpu.SelectedIndex = GetIndexItem(cbb_cpu, cpu.STenDongCPU);

            myChiTietDongOCungDTO ocung = new myChiTietDongOCungDTO();
            ocung = LaptopInfor.ChiTietDongOCung;
            cbb_ocung.SelectedIndex = GetIndexItem(cbb_ocung, ocung.STenDongOCung);

            myChiTietDongManHinhDTO manhinh = new myChiTietDongManHinhDTO();
            manhinh = LaptopInfor.ChiTietDongManHinh;
            cbb_manhinh.SelectedIndex = GetIndexItem(cbb_manhinh, manhinh.STenDongManHinh);

            myChiTietDongCardDoHoaDTO carddohoa = new myChiTietDongCardDoHoaDTO();
            carddohoa = LaptopInfor.ChiTietDongCacDoHoa;
            cbb_cardmanhinh.SelectedIndex = GetIndexItem(cbb_cardmanhinh, carddohoa.STenDongCardDoHoa);

            myChiTietDongLoaDTO loa = new myChiTietDongLoaDTO();
            loa = LaptopInfor.ChiTietDongLoa;
            cbb_loa.SelectedIndex = GetIndexItem(cbb_loa, loa.STenDongLoa);

            myChiTietDongODiaQuangDTO oquang = new myChiTietDongODiaQuangDTO();
            oquang = LaptopInfor.ChiTietDongODiaQuang;
            cbb_oquang.SelectedIndex = GetIndexItem(cbb_oquang, oquang.STenDongODiaQuang);

            myChiTietHeDieuHanhDTO hdh = new myChiTietHeDieuHanhDTO();
            hdh = LaptopInfor.ChiTietHeDieuHanh;
            cbb_hdh.SelectedIndex = GetIndexItem(cbb_hdh, hdh.STenHeDieuHanh);

            myChiTietTrongLuongDTO trongluong = new myChiTietTrongLuongDTO();
            trongluong = LaptopInfor.ChiTietTrongLuong;
            cbb_trongluong.SelectedIndex = GetIndexItem(cbb_trongluong, trongluong.FGiaTriTrongLuong.ToString());

            cbb_mausac.SelectedIndex = GetIndexItem(cbb_mausac, LaptopInfor.SMauSac);

            myChiTietDongCardMangDTO cardmang = new myChiTietDongCardMangDTO();
            cardmang = LaptopInfor.ChiTietDongCardMang;
            cbb_cardmang.SelectedIndex = GetIndexItem(cbb_cardmang, cardmang.STenDongCardMang);

            myChiTietDongCardReaderDTO cardreader = new myChiTietDongCardReaderDTO();
            cardreader = LaptopInfor.ChiTietDongCardReader;
            cbb_cardreader.SelectedIndex = GetIndexItem(cbb_cardreader, cardreader.STenDongCardReader);

            myChiTietDongWebcamDTO webcam = new myChiTietDongWebcamDTO();
            webcam = LaptopInfor.ChiTietDongWebCam;
            cbb_webcam.SelectedIndex = GetIndexItem(cbb_webcam, webcam.STenDongWebCam);

            myChiTietDongPinDTO pin = new myChiTietDongPinDTO();
            pin = LaptopInfor.ChiTietDongPin;
            cbb_pin.SelectedIndex = GetIndexItem(cbb_pin, pin.FTenDongPin);

            String xn_vantay = (LaptopInfor.BFingerprintReader == 1) ? "Có" : "Không";
            cbb_vantay.SelectedIndex = GetIndexItem(cbb_vantay, xn_vantay);

            cbb_usb.SelectedIndex = GetIndexItem(cbb_usb, LaptopInfor.ISoLuongCongUSB.ToString());
            String hdmi = (LaptopInfor.BHDMI == 1) ? "Có" : "Không";
            cbb_hdmi.SelectedIndex = GetIndexItem(cbb_hdmi, hdmi);

            myNhaSanXuatDTO nhasx = new myNhaSanXuatDTO(LaptopInfor.NhaSanXuat.STenNhaSanXuat);
            cbb_nhasx.SelectedIndex = GetIndexItem(cbb_nhasx, nhasx.STenNhaSanXuat);

            cbb_thoigian_bh.SelectedIndex = GetIndexItem(cbb_thoigian_bh, LaptopInfor.IThoiGianBaoHanh.ToString());

            fileName = LaptopInfor.SHinhAnh;

            pb_picture.ImageLocation = fileName;
        }
        /// <summary>
        /// Load thông tin sản phẩm từ datagridview vào các combobox và textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgw_LapTop_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            HienThiThongTin();

        }


        private bool KiemTra_ThongTin()
        {
            if (string.Compare(txtTenDongLapTop.Text.Trim(), "") == 0 || string.Compare(txt_giaban.Text.Trim(), "") == 0 || string.Compare(txt_SoLuong.Text.Trim(), "") == 0)
            {
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Cập nhật thông tin khi click button cập nhật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (KiemTra_ThongTin() == false)
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin.Vui lòng nhập lại cho đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CHITIETDONGLAPTOP dongLaptopMoi = new CHITIETDONGLAPTOP();

            dongLaptopMoi.MaDongLapTop = LaptopInfor.IMaDongLaptop;

            //tên dòng laptop
            if ((this.txtTenDongLapTop.Text.Length < 5) || (this.txtTenDongLapTop.Text.Length > 30))
            {
                MessageBox.Show("Tên dòng laptop có chiều dài từ 5 đến 30 ký tự");
                txtTenDongLapTop.Focus();
                return;
            }
            else
            {
                dongLaptopMoi.TenChiTietDongLapTop = txtTenDongLapTop.Text;
            }

            //dòng Ram
            myChiTietDongRamDTO dongRam = (myChiTietDongRamDTO)cbb_ram.SelectedItem;
            dongLaptopMoi.MaDongRAM = dongRam.IMaDongRam;

            //dòng CPU
            myChiTietDongCPUDTO dongCPU = (myChiTietDongCPUDTO)cbb_cpu.SelectedItem;
            dongLaptopMoi.MaDongCPU = dongCPU.IMaDongCPU;

            //dòng Ổ Cứng
            myChiTietDongOCungDTO dongOCung = (myChiTietDongOCungDTO)cbb_ocung.SelectedItem;
            dongLaptopMoi.MaDongOCung = dongOCung.IMaDongOCung;

            //dòng màn hình
            myChiTietDongManHinhDTO dongManHinh = (myChiTietDongManHinhDTO)cbb_manhinh.SelectedItem;
            dongLaptopMoi.MaDongManHinh = dongManHinh.IMaDongManHinh;

            // Card Màn Hình
            myChiTietDongCardDoHoaDTO dongCardDoHoa = (myChiTietDongCardDoHoaDTO)cbb_cardmanhinh.SelectedItem;
            dongLaptopMoi.MaDongCardDoHoa = dongCardDoHoa.IMaDongCardDoHoa;

            //Dong Loa
            myChiTietDongLoaDTO dongLoa = (myChiTietDongLoaDTO)cbb_loa.SelectedItem;
            dongLaptopMoi.MaDongLoa = dongLoa.IMaDongLoa;

            //O Quang
            myChiTietDongODiaQuangDTO oDiaQuang = (myChiTietDongODiaQuangDTO)cbb_oquang.SelectedItem;
            dongLaptopMoi.MaDongODiaQuang = oDiaQuang.IMaDongODiaQuang;

            //HDH
            myChiTietHeDieuHanhDTO heDieuHanh = (myChiTietHeDieuHanhDTO)cbb_hdh.SelectedItem;
            dongLaptopMoi.MaHeDieuHanh = heDieuHanh.IMaHeDieuHanh;

            //Trong Luong
            myChiTietTrongLuongDTO trongLuong = (myChiTietTrongLuongDTO)cbb_trongluong.SelectedItem;
            dongLaptopMoi.MaChiTietTrongLuong = trongLuong.IMaCHiTietTrongLuong;

            //thời gian bảo hành
            try
            {
                dongLaptopMoi.ThoiGianBaoHanh = int.Parse(cbb_thoigian_bh.Text);
            }
            catch
            {
                MessageBox.Show("Thời gian bảo hành phải là 1 con số", "Thông báo");
                return;
            }

            //Màu sắc
            dongLaptopMoi.MauSac = cbb_mausac.Text;

            //thời gian bảo hành
            try
            {
                dongLaptopMoi.ThoiGianBaoHanh = int.Parse(cbb_thoigian_bh.Text);
            }
            catch
            {
                MessageBox.Show("Thời gian bảo hành phải là giá trị số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //giá hiện hành
            try
            {
                double giaHienHanh = double.Parse(txt_giaban.Text);
                dongLaptopMoi.GiaBanHienHanh = giaHienHanh;
            }
            catch
            {
                MessageBox.Show("Giá tiền phải là giá trị số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_giaban.Focus();
                return;
            }

            //Card Mạng
            myChiTietDongCardMangDTO cardMang = (myChiTietDongCardMangDTO)cbb_cardmang.SelectedItem;
            dongLaptopMoi.MaDongCardMang = cardMang.IMaDongCardMang;

            //CardReader
            myChiTietDongCardReaderDTO cardReader = (myChiTietDongCardReaderDTO)cbb_cardreader.SelectedItem;
            dongLaptopMoi.MaDongCardReader = cardReader.IMaDongCardReader;

            //WebCam
            myChiTietDongWebcamDTO webcam = (myChiTietDongWebcamDTO)cbb_webcam.SelectedItem;
            dongLaptopMoi.MaDongWebCam = webcam.IMaDongWebcam;

            //Pin
            myChiTietDongPinDTO pin = (myChiTietDongPinDTO)cbb_pin.SelectedItem;
            dongLaptopMoi.MaDongPin = pin.IMaDongPin;

            //Kha Nang Nhan Dang Van Tay
            if (cbb_vantay.Text == "Có")
                dongLaptopMoi.FingerprintReader = true;
            else
                dongLaptopMoi.FingerprintReader = false;

            //Cong HDMI
            if (cbb_hdmi.Text == "Có")
                dongLaptopMoi.HDMI = true;
            else
                dongLaptopMoi.HDMI = false;

            //số lượng công usb
            dongLaptopMoi.SoLuongCongUSB = int.Parse(cbb_usb.Text.Trim());

            //Nhà Sản xuất

            //Nhà Sản xuất
            myNhaSanXuatDTO nhaSanXuat = (myNhaSanXuatDTO)cbb_nhasx.SelectedItem;
            dongLaptopMoi.MaNhaSanXuat = nhaSanXuat.IMaNhaSanXuat;

            //đã xóa
            dongLaptopMoi.Deleted = false;
            //mã đánh giá
            dongLaptopMoi.MaDanhGia = 1;
            //so lượng còn lại
            dongLaptopMoi.SoLuongConLai = LaptopInfor.ISoLuongConLai;

            // mô tả thêm
            if (txt_MoTaThem.Text.Length < 512)
            {
                dongLaptopMoi.MoTaThem = txt_MoTaThem.Text;
            }
            else
            {
                MessageBox.Show("Mô tả thêm dài hơn 512 ký tự, xin nhập lại", "Thông báo");
                txt_MoTaThem.Focus();
                return;
            }

            //số lượng nhập

            try
            {
                dongLaptopMoi.SoLuongNhap = int.Parse(txt_SoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng nhập phải là số nguyên!", "Thông báo");
                txt_SoLuong.Focus();
                return;
            }

            //ngày nhập
            dongLaptopMoi.NgayNhap = dtp_ngaynhap.Value;


            // đường dẫn file hình ảnh
            if (fileName == "")
            {
                MessageBox.Show("Chưa chọn file hình ảnh laptop!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dongLaptopMoi.HinhAnh = fileName;
            }

            try
            {
                myChiTietDongLaptopBUS.CapNhatChiTietDongLaptop(dongLaptopMoi);
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fileName = "";
            }
            catch 
            {
                MessageBox.Show(" Cập thông tin sản phẩm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_chonhinh_Click(object sender, EventArgs e)
        {
            //Tạo bộ lọc các file khi mở OpenDialog
            //Filter lọc ra các file để bạn dễ dàng lựa chọn (ví dụ các fiel jpg, png,....)
            openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.PNG";
            //Tên của hộp thoại hiện lên - Không có thì sẽ là mặc định
            openFileDialog1.Title = "Chọn hình ảnh";
            //Cho phép chọn nhiều file cùng lúc - Mặc định là false
            openFileDialog1.Multiselect = false;

            openFileDialog1.InitialDirectory = Application.StartupPath + "\\image";
            openFileDialog1.Multiselect = false;
            //InitialDirectory = @"C:/";
            //Mở hộp thoại
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Lấy giá trị
                //Nếu bạn chỉ chọn một file thì giá trị trả về sẽ là một chuỗi kiểu String
                //Vd:
                String imageFile = "";
                imageFile = openFileDialog1.SafeFileName;
                fileName = @"image/" + imageFile;
                pb_picture.ImageLocation = fileName;
            }

        }
        /// <summary>
        /// Load thông tin từ datagridview vào combobox và textbox khi người dùng double click vào một dòng trong bảng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgw_LapTop_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTin();
        }
    }
}
