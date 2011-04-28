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
            catch (Exception ex)
            {
                dsDongRam = null;
            }
            cbb_ram.Items.Add("----");
            if (dsDongRam != null)
            {
                foreach (myChiTietDongRamDTO ram in dsDongRam)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_ram.Items.Count; index++)
                    {
                        if (string.Compare(cbb_ram.Items[index].ToString().Trim(), ram.STenDongRAM.Trim(), true) == 0)
                        {
                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_ram.Items.Add(ram.STenDongRAM);
                }
                cbb_ram.SelectedItem = cbb_ram.Items[0];
            }

            // Load CPUs
            myChiTietDongCPUBUS chiTietDongCPU = new myChiTietDongCPUBUS();
            List<myChiTietDongCPUDTO> dsDongCPU = new List<myChiTietDongCPUDTO>();
            try
            {
                dsDongCPU = chiTietDongCPU.LayChiTietDongCPU();
            }
            catch (Exception ex)
            {
                dsDongCPU = null;
            }
            cbb_cpu.Items.Add("----");
            if (dsDongCPU != null)
            {
                foreach (myChiTietDongCPUDTO cpu in dsDongCPU)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_cpu.Items.Count; index++)
                    {
                        if (string.Compare(cbb_cpu.Items[index].ToString().Trim(), cpu.STenDongCPU.Trim(), true) == 0)
                        {
                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_cpu.Items.Add(cpu.STenDongCPU);        
                }
                cbb_cpu.SelectedItem = cbb_cpu.Items[0];
            }
            // Load O Cung
            myChiTietDongOCungBUS chiTietDongOCung = new myChiTietDongOCungBUS();
            List<myChiTietDongOCungDTO> dsDongOCung = new List<myChiTietDongOCungDTO>();
            try
            {
                dsDongOCung = chiTietDongOCung.LayChiTietDongOCung();
            }
            catch (Exception ex)
            {
                dsDongOCung = null;
            }
            cbb_ocung.Items.Add("----");
            if (dsDongOCung != null)
            {
                foreach (myChiTietDongOCungDTO ocung in dsDongOCung)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_ocung.Items.Count; index++)
                    {
                        if (string.Compare(cbb_ocung.Items[index].ToString().Trim(), ocung.STenDongOCung.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_ocung.Items.Add(ocung.STenDongOCung);
                }
                cbb_ocung.SelectedItem = cbb_ocung.Items[0];
            }

            // Load Man Hinh
            myChiTietDongManHinhBUS chiTietManHinh = new myChiTietDongManHinhBUS();
            List<myChiTietDongManHinhDTO> dsManHinh = new List<myChiTietDongManHinhDTO>();
            try
            {
                dsManHinh = chiTietManHinh.LayChiTietDongManHinh();
            }
            catch (Exception ex)
            {
                dsManHinh = null;
            }
            cbb_manhinh.Items.Add("----");
            if (dsManHinh != null)
            {
                foreach (myChiTietDongManHinhDTO manhinh in dsManHinh)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_manhinh.Items.Count; index++)
                    {
                        if (string.Compare(cbb_manhinh.Items[index].ToString().Trim(), manhinh.STenDongManHinh.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_manhinh.Items.Add(manhinh.STenDongManHinh);    
                }
                cbb_manhinh.SelectedItem = cbb_manhinh.Items[0];
            }

            // Load Card Mang Hinh
            myChiTietDongCardDoHoaBUS chiTietCardDoHoa = new myChiTietDongCardDoHoaBUS();
            List<myChiTietDongCardDoHoaDTO> dsCardDoHoa = new List<myChiTietDongCardDoHoaDTO>();
            try
            {
                dsCardDoHoa = chiTietCardDoHoa.LayChiTietDongCardDoHoa();
            }
            catch (Exception ex)
            {
                dsCardDoHoa = null;
            }
            cbb_cardmanhinh.Items.Add("----");
            if (dsCardDoHoa != null)
            {
                foreach (myChiTietDongCardDoHoaDTO carddohoa in dsCardDoHoa)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_cardmanhinh.Items.Count; index++)
                    {
                        if (string.Compare(cbb_cardmanhinh.Items[index].ToString().Trim(), carddohoa.STenDongCardDoHoa.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_cardmanhinh.Items.Add(carddohoa.STenDongCardDoHoa);    
                }
                cbb_cardmanhinh.SelectedItem = cbb_cardmanhinh.Items[0];
            }

            // Load Dong Loa
            myChiTietDongLoaBUS chiTietDongLoa = new myChiTietDongLoaBUS();
            List<myChiTietDongLoaDTO> dsLoa = new List<myChiTietDongLoaDTO>();
            try
            {
                dsLoa = chiTietDongLoa.LayChiTietDongLoa();
            }
            catch (Exception ex)
            {
                dsLoa = null;
            }
            cbb_loa.Items.Add("----");
            if (dsLoa != null)
            {
                foreach (myChiTietDongLoaDTO loa in dsLoa)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_loa.Items.Count; index++)
                    {
                        if (string.Compare(cbb_loa.Items[index].ToString().Trim(), loa.STenDongLoa.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_loa.Items.Add(loa.STenDongLoa);    
                }
                cbb_loa.SelectedItem = cbb_loa.Items[0];
            }

            // Load O Quang
            myChiTietDongODiaQuangBUS chiTietDongDQ = new myChiTietDongODiaQuangBUS();
            List<myChiTietDongODiaQuangDTO> dsDiaQuang = new List<myChiTietDongODiaQuangDTO>();
            try
            {
                dsDiaQuang = chiTietDongDQ.LayChiTietDongODiaQuang();
            }
            catch (Exception ex)
            {
                dsDiaQuang = null;
            }
            cbb_oquang.Items.Add("----");
            if (dsDiaQuang != null)
            {
                foreach (myChiTietDongODiaQuangDTO diaquang in dsDiaQuang)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_oquang.Items.Count; index++)
                    {
                        if (string.Compare(cbb_oquang.Items[index].ToString().Trim(), diaquang.STenDongODiaQuang.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_oquang.Items.Add(diaquang.STenDongODiaQuang);
                }
                cbb_oquang.SelectedItem = cbb_oquang.Items[0];
            }

            //Load HDH
            myChiTietHeDieuHanhBUS chiTietHDH = new myChiTietHeDieuHanhBUS();
            List<myChiTietHeDieuHanhDTO> dsHDH = new List<myChiTietHeDieuHanhDTO>();
            try
            {
                dsHDH = chiTietHDH.LayChiTietHeDieuHanh();
            }
            catch (Exception ex)
            {
                dsHDH = null;
            }
            cbb_hdh.Items.Add("----");
            if (dsHDH != null)
            {
                foreach (myChiTietHeDieuHanhDTO hdh in dsHDH)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_hdh.Items.Count; index++)
                    {
                        if (string.Compare(cbb_hdh.Items[index].ToString().Trim(), hdh.STenHeDieuHanh.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_hdh.Items.Add(hdh.STenHeDieuHanh);    
                }
                cbb_hdh.SelectedItem = cbb_hdh.Items[0];
            }

            //Load Trong Luong
            myChiTietTrongLuongBUS chiTietTL = new myChiTietTrongLuongBUS();
            List<myChiTietTrongLuongDTO> dsTrongLuong = new List<myChiTietTrongLuongDTO>();
            try
            {
                dsTrongLuong = chiTietTL.LayChiTietTrongLuong();
            }
            catch (Exception ex)
            {
                dsTrongLuong = null;
            }
            cbb_trongluong.Items.Add("----");
            if (dsTrongLuong != null)
            {
                foreach (myChiTietTrongLuongDTO tl in dsTrongLuong)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_trongluong.Items.Count; index++)
                    {
                        if (string.Compare(cbb_trongluong.Items[index].ToString().Trim(), tl.FGiaTriTrongLuong.ToString().Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_trongluong.Items.Add(tl.FGiaTriTrongLuong);        
                }
                    
                cbb_trongluong.SelectedItem = cbb_trongluong.Items[0];
            }

            //Load Ten Dong LapTop & Mau Sac & Thoi Gian Bao Hanh & Gia Ban

            List<myChiTietDongLaptopDTO> dsLapTop = new List<myChiTietDongLaptopDTO>();
            try
            {
                dsLapTop = myChiTietDongLaptopBUS.LayChiTietDongLaptop();
            }
            catch (Exception ex)
            {
                dsLapTop = null;
            }
            // - Mau Sac-
            cbb_mausac.Items.Add("----");
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
                cbb_thoigian_bh.Items.Add("----");
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

            //Load Card Mạng
            myChiTietDongCardMangBUS chiTietCardMang = new myChiTietDongCardMangBUS();
            List<myChiTietDongCardMangDTO> dsCardMang = new List<myChiTietDongCardMangDTO>();
            try
            {
                dsCardMang = chiTietCardMang.LayChiTietDongCardMang();
            }
            catch (Exception ex)
            {
                dsCardMang = null;
            }
            cbb_cardmang.Items.Add("----");
            if (dsCardMang != null)
            {
                foreach (myChiTietDongCardMangDTO cardmang in dsCardMang)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_cardmang.Items.Count; index++)
                    {
                        if (string.Compare(cbb_cardmang.Items[index].ToString().Trim(), cardmang.STenDongCardMang.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_cardmang.Items.Add(cardmang.STenDongCardMang);   
                }
                cbb_cardmang.SelectedItem = cbb_cardmang.Items[0];
            }

            //Load CardReader
            myChiTietDongCardReaderBUS chiTietCardReader = new myChiTietDongCardReaderBUS();
            List<myChiTietDongCardReaderDTO> dsCardReader = new List<myChiTietDongCardReaderDTO>();
            try
            {
                dsCardReader = chiTietCardReader.LayChiTietDongCardReader();
            }
            catch (Exception ex)
            {
                dsCardReader = null;
            }
            cbb_cardreader.Items.Add("----");
            if (dsCardReader != null)
            {
                foreach (myChiTietDongCardReaderDTO cardreader in dsCardReader)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_cardreader.Items.Count; index++)
                    {
                        if (string.Compare(cbb_cardreader.Items[index].ToString().Trim(), cardreader.STenDongCardReader.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_cardreader.Items.Add(cardreader.STenDongCardReader);    
                }
                cbb_cardreader.SelectedItem = cbb_cardreader.Items[0];
            }

            //Load WebCam
            myChiTietDongWebcamBUS chiTietWebCam = new myChiTietDongWebcamBUS();
            List<myChiTietDongWebcamDTO> dsWebcam = new List<myChiTietDongWebcamDTO>();
            try
            {
                dsWebcam = chiTietWebCam.LayChiTietDongWebcam();
            }
            catch (Exception ex)
            {
                dsWebcam = null;
            }
            cbb_webcam.Items.Add("----");
            if (dsWebcam != null)
            {
                foreach (myChiTietDongWebcamDTO webcam in dsWebcam)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_webcam.Items.Count; index++)
                    {
                        if (string.Compare(cbb_webcam.Items[index].ToString().Trim(), webcam.STenDongWebCam.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_webcam.Items.Add(webcam.STenDongWebCam);    
                }
                cbb_webcam.SelectedItem = cbb_webcam.Items[0];
            }

            //Load Pin
            myChiTietDongPinBUS chiTietPin = new myChiTietDongPinBUS();
            List<myChiTietDongPinDTO> dsPin = new List<myChiTietDongPinDTO>();
            try
            {
                dsPin = chiTietPin.LayChiTietDongPin();
            }
            catch (Exception ex)
            {
                dsPin = null;
            }

            cbb_pin.Items.Add("----");
            if (dsPin != null)
            {
                foreach (myChiTietDongPinDTO pin in dsPin)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_pin.Items.Count; index++)
                    {
                        if (string.Compare(cbb_pin.Items[index].ToString().Trim(), pin.FTenDongPin.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_pin.Items.Add(pin.FTenDongPin);
                }

                cbb_pin.SelectedItem = cbb_pin.Items[0];
            }

            //Load Kha Nang Nhan Dang Van Tay
            cbb_vantay.Items.Add("----");
            cbb_vantay.Items.Add("Có");
            cbb_vantay.Items.Add("Không");
            cbb_vantay.SelectedItem = cbb_vantay.Items[0];

            //Load Cong HDMI
            cbb_hdmi.Items.Add("----");
            cbb_hdmi.Items.Add("Có");
            cbb_hdmi.Items.Add("Không");
            cbb_hdmi.SelectedItem = cbb_hdmi.Items[0];

            // Load So Cong USB
            cbb_usb.Items.Add("----");
            cbb_usb.Items.Add("1");
            cbb_usb.Items.Add("2");
            cbb_usb.Items.Add("3");
            cbb_usb.SelectedItem = cbb_usb.Items[0];

            // Load Nha SX
            myNhaSanXuatBUS nhaSX = new myNhaSanXuatBUS();
            List<myNhaSanXuatDTO> dsNhaSX = new List<myNhaSanXuatDTO>();
            try
            {
                dsNhaSX = nhaSX.LayNhaSanXuat();
            }
            catch (Exception ex)
            {
                dsNhaSX = null;
            }
            cbb_nhasx.Items.Add("----");
            if (dsNhaSX != null)
            {
                foreach (myNhaSanXuatDTO nhasx in dsNhaSX)
                {
                    bool trace = true;
                    for (int index = 0; index < cbb_nhasx.Items.Count; index++)
                    {
                        if (string.Compare(cbb_nhasx.Items[index].ToString().Trim(), nhasx.STenNhaSanXuat.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        cbb_nhasx.Items.Add(nhasx.STenNhaSanXuat);    
                    
                }
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu. Vui lòng thực hiện lại thao tác tra cứu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                (laptop.BFingerprintReader==1)?"Có":"Không",
                //usb
                laptop.ISoLuongCongUSB,
                //cong HDMI
                (laptop.BHDMI==1)?"Có":"Không",
                //nha san xuat
                laptop.NhaSanXuat.STenNhaSanXuat,
                //thoi gian bao hanh
                laptop.IThoiGianBaoHanh,
                //gia ban
                laptop.FGiaBanHienHanh,
                //so luong nhap
                laptop.ISoLuongNhap,
                // Ngay nhap
                laptop.DNgayNhap.Day.ToString()+"/"+laptop.DNgayNhap.Month.ToString()+"/"+laptop.DNgayNhap.Year.ToString(),
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
        private int GetIndexItem( ComboBox m_cbb, String CompareStr)
        {
            for (int count = 0; count < m_cbb.Items.Count; count++)
            {
                if(String.Compare(m_cbb.Items[count].ToString().Trim(),CompareStr.Trim(),true)==0)
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
            else if (
                    cbb_ram.SelectedIndex == 0 || cbb_cpu.SelectedIndex == 0 || cbb_ocung.SelectedIndex == 0 || cbb_manhinh.SelectedIndex == 0 ||
                    cbb_cardmanhinh.SelectedIndex == 0 || cbb_loa.SelectedIndex == 0 || cbb_oquang.SelectedIndex == 0 || cbb_hdh.SelectedIndex == 0 ||
                    cbb_trongluong.SelectedIndex == 0 || cbb_mausac.SelectedIndex == 0 || cbb_cardmang.SelectedIndex == 0 || cbb_cardreader.SelectedIndex == 0 ||
                    cbb_webcam.SelectedIndex == 0 || cbb_pin.SelectedIndex == 0 || cbb_vantay.SelectedIndex == 0 || cbb_usb.SelectedIndex == 0 ||
                    cbb_hdmi.SelectedIndex == 0 || cbb_nhasx.SelectedIndex == 0 || cbb_thoigian_bh.SelectedIndex == 0)
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
                MessageBox.Show("Chưa điền đầy đủ thông tin.Vui lòng nhập lại cho đầy đủ thông tin","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
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

            //dòng ram
            int maRam = -1;
            myChiTietDongRamBUS ramBus = new myChiTietDongRamBUS();
            try
            {
                maRam = ramBus.LayChiTietDongRam(cbb_ram.Text.Trim());
            }
            catch
            {
                maRam = -1;
            }
            dongLaptopMoi.MaDongRAM = maRam;

            //dòng CPU
            myChiTietDongCPUBUS cpuBus = new myChiTietDongCPUBUS();
            int maCpu = -1;
            try
            {
                maCpu = cpuBus.LayChiTietDongCPU(cbb_cpu.Text.Trim());
            }
            catch
            {
                maCpu = -1;
            }
            dongLaptopMoi.MaDongCPU = maCpu;

            //dòng ô cứng

            myChiTietDongOCungBUS ocungBus = new myChiTietDongOCungBUS();
            int maOCung = -1;
            try
            {
                maOCung = ocungBus.LayChiTietDongOCung(cbb_ocung.Text.Trim());
            }
            catch
            {
                maOCung = -1;
            }
            dongLaptopMoi.MaDongOCung = maOCung;

            //dòng màn hình

            myChiTietDongManHinhBUS manHinhBus = new myChiTietDongManHinhBUS();
            int maManHinh = -1;
            try
            {
                maManHinh = manHinhBus.LayChiTietDongManHinh(cbb_manhinh.Text.Trim());
            }
            catch
            {
                maManHinh = -1;
            }
            dongLaptopMoi.MaDongManHinh = maManHinh ;

            // Card Man Hinh
            myChiTietDongCardDoHoaBUS cardDHBus = new myChiTietDongCardDoHoaBUS();
            int maCardDH = -1;
            try
            {
                maCardDH = cardDHBus.LayChiTietDongCardDoHoa(cbb_cardmanhinh.Text.Trim());
            }
            catch
            {
                maCardDH = -1;
            }
            dongLaptopMoi.MaDongCardDoHoa = maCardDH;

            //Dong Loa
            myChiTietDongLoaBUS loaBus = new myChiTietDongLoaBUS();
            int maLoa = -1;
            try
            {
                maLoa = loaBus.LayChiTietDongLoa(cbb_loa.Text.Trim());
            }
            catch
            {
                maLoa = -1;
            }
            dongLaptopMoi.MaDongLoa = maLoa;

            //O Quang
            myChiTietDongODiaQuangBUS diaQuangBus = new myChiTietDongODiaQuangBUS();
            int maOQuang = -1;
            try
            {
                maOQuang = diaQuangBus.LayChiTietDongODiaQuang(cbb_oquang.Text.Trim());
            }
            catch
            {
                maOQuang = -1;
            }
            dongLaptopMoi.MaDongODiaQuang = maOQuang;
            //HDH

            myChiTietHeDieuHanhBUS hdhBus = new myChiTietHeDieuHanhBUS();
            int maHDH = -1;
            try
            {
                maHDH = hdhBus.LayChiTietHeDieuHanh(cbb_hdh.Text.Trim());
            }
            catch
            {
                maHDH = -1;
            }
            dongLaptopMoi.MaHeDieuHanh = maHDH ;

            //Trong Luong

            myChiTietTrongLuongBUS tlBus = new myChiTietTrongLuongBUS();
            int maTrongLuong = -1;
            try
            {
                maTrongLuong = tlBus.LayChiTietTrongLuong(cbb_trongluong.Text.Trim());
            }
            catch
            {
                maTrongLuong = -1;
            }
            dongLaptopMoi.MaChiTietTrongLuong = maTrongLuong ;
            //Màu sắc
            dongLaptopMoi.MauSac = cbb_mausac.Text;

            //thời gian bảo hành
            try
            {
                dongLaptopMoi.ThoiGianBaoHanh = int.Parse(cbb_thoigian_bh.Text);
            }
            catch
            {
                MessageBox.Show("Thời gian bảo hành phải là giá trị số", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                MessageBox.Show("Giá tiền phải là giá trị số", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_giaban.Focus();
                return;
            }
            
            //card mạng
            int maCardMang = -1;
            myChiTietDongCardMangBUS cardMangBus = new myChiTietDongCardMangBUS();
            try
            {
                maCardMang = cardMangBus.LayChiTietDongCardMang(cbb_cardmang.Text.Trim());
            }
            catch
            {
                maCardMang = -1;
            }
            dongLaptopMoi.MaDongCardMang = maCardMang;

            //CardReader
            int maCardReader = -1;
            myChiTietDongCardReaderBUS cardReaderBus = new myChiTietDongCardReaderBUS();
            try
            {
                maCardReader = cardReaderBus.LayChiTietDongCardReader(cbb_cardreader.Text.Trim());
            }
            catch
            {
                maCardReader = -1;
            }
            dongLaptopMoi.MaDongCardReader = maCardReader;
            //WebCam

            int maWebcam = -1;
            myChiTietDongWebcamBUS webCamBus = new myChiTietDongWebcamBUS();
            try
            {
                maWebcam =  webCamBus.LayChiTietDongWebcam(cbb_webcam.Text.Trim());
            }
            catch
            {
                maWebcam = -1;
            }
            dongLaptopMoi.MaDongWebCam = maWebcam;

            //Pin
            myChiTietDongPinBUS pinBus = new myChiTietDongPinBUS();
            int maPin = -1;
            try
            {
                pinBus.LayChiTietDongPin(cbb_pin.Text.Trim());
            }
            catch
            {
                maPin = -1;
            }
            dongLaptopMoi.MaDongPin = maPin;

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

            myNhaSanXuatBUS nhasxBus = new myNhaSanXuatBUS();
            int maNhaSX = -1;
            try
            {
                maNhaSX = nhasxBus.LayNhaSanXuat(cbb_nhasx.Text.Trim());
            }
            catch
            {
                maNhaSX = -1;
            }
            dongLaptopMoi.MaNhaSanXuat = maNhaSX;

            //đã xóa
            dongLaptopMoi.Deleted = LaptopInfor.BDeleted;
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
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                fileName = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(" Cập thông tin sản phẩm mới thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            if(result == DialogResult.OK)
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
