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

namespace TUVANLAPTOP
{
    public partial class TRACUUSANPHAM : Form
    {
        public TRACUUSANPHAM()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Đóng form màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Back_XoaSanPham_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Khởi tạo danh sách các sản phẩm ban đầu cho từng combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRACUUSANPHAM_Load(object sender, EventArgs e)
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
            comboBox_Ram.Items.Add("--Không quan tâm--");
            if (dsDongRam != null)
            {
                foreach (myChiTietDongRamDTO ram in dsDongRam)
                    comboBox_Ram.Items.Add(ram.STenDongRAM);
                comboBox_Ram.SelectedItem = comboBox_Ram.Items[0];
            }

            // Load CPU
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
            comboBox_CPU.Items.Add("--Không quan tâm--");
            if (dsDongCPU != null)
            {
                foreach (myChiTietDongCPUDTO cpu in dsDongCPU)
                    comboBox_CPU.Items.Add(cpu.STenDongCPU);
                comboBox_CPU.SelectedItem = comboBox_CPU.Items[0];
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
            comboBox_HardDisk.Items.Add("--Không quan tâm--");
            if (dsDongOCung != null)
            {
                foreach (myChiTietDongOCungDTO ocung in dsDongOCung)
                {
                    bool trace = true;
                    for (int index = 0; index < comboBox_HardDisk.Items.Count; index++)
                    {
                        if (string.Compare(comboBox_HardDisk.Items[index].ToString().Trim(), ocung.STenDongOCung.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        comboBox_HardDisk.Items.Add(ocung.STenDongOCung);
                    comboBox_HardDisk.SelectedItem = comboBox_HardDisk.Items[0];
                }
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
            comboBox_ManHinh.Items.Add("--Không quan tâm--");
            if (dsManHinh != null)
            {
                foreach (myChiTietDongManHinhDTO manhinh in dsManHinh)
                    comboBox_ManHinh.Items.Add(manhinh.STenDongManHinh);
                comboBox_ManHinh.SelectedItem = comboBox_ManHinh.Items[0];
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
            comboBox_CardManHinh.Items.Add("--Không quan tâm--");
            if (dsCardDoHoa != null)
            {
                foreach (myChiTietDongCardDoHoaDTO carddohoa in dsCardDoHoa)
                    comboBox_CardManHinh.Items.Add(carddohoa.STenDongCardDoHoa);
                comboBox_CardManHinh.SelectedItem = comboBox_CardManHinh.Items[0];
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
            comboBox_Loa.Items.Add("--Không quan tâm--");
            if (dsLoa != null)
            {
                foreach (myChiTietDongLoaDTO loa in dsLoa)
                    comboBox_Loa.Items.Add(loa.STenDongLoa);
                comboBox_Loa.SelectedItem = comboBox_Loa.Items[0];
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
            comboBox_ODiaQuang.Items.Add("--Không quan tâm--");
            if (dsDiaQuang != null)
            {
                foreach (myChiTietDongODiaQuangDTO diaquang in dsDiaQuang)
                {
                    bool trace = true;
                    for (int index = 0; index < comboBox_ODiaQuang.Items.Count; index++)
                    {
                        if (string.Compare(comboBox_ODiaQuang.Items[index].ToString().Trim(), diaquang.STenDongODiaQuang.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        comboBox_ODiaQuang.Items.Add(diaquang.STenDongODiaQuang);
                }
                comboBox_ODiaQuang.SelectedItem = comboBox_ODiaQuang.Items[0];
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
            comboBox_HeDieuHanh.Items.Add("--Không quan tâm--");
            if (dsHDH != null)
            {
                foreach (myChiTietHeDieuHanhDTO hdh in dsHDH)
                    comboBox_HeDieuHanh.Items.Add(hdh.STenHeDieuHanh);
                comboBox_HeDieuHanh.SelectedItem = comboBox_HeDieuHanh.Items[0];
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
            comboBox_TrongLuong.Items.Add("--Không quan tâm--");
            if (dsTrongLuong != null)
            {
                foreach (myChiTietTrongLuongDTO tl in dsTrongLuong)
                    comboBox_TrongLuong.Items.Add(tl.FGiaTriTrongLuong);
                comboBox_TrongLuong.SelectedItem = comboBox_TrongLuong.Items[0];
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
            // - Ten Dong LapTop
            Combobox_TenDongLapTop.Items.Add("--Không quan tâm--");
            if (dsLapTop != null)
            {
                foreach (myChiTietDongLaptopDTO laptop in dsLapTop)
                {
                    bool trace = true;
                    for (int index = 0; index < Combobox_TenDongLapTop.Items.Count; index++)
                    {
                        if (string.Compare(Combobox_TenDongLapTop.Items[index].ToString().Trim(), laptop.STenChiTietDongLapTop.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        Combobox_TenDongLapTop.Items.Add(laptop.STenChiTietDongLapTop);
                }
                Combobox_TenDongLapTop.SelectedItem = Combobox_TenDongLapTop.Items[0];

                // - Mau Sac-
                comboBox_MauSac.Items.Add("--Không quan tâm--");
                foreach (myChiTietDongLaptopDTO laptop in dsLapTop)
                {
                    bool trace = true;
                    for (int index = 0; index < comboBox_MauSac.Items.Count; index++)
                    {
                        if (string.Compare(comboBox_MauSac.Items[index].ToString().Trim(), laptop.SMauSac.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        comboBox_MauSac.Items.Add(laptop.SMauSac);
                }

                comboBox_MauSac.SelectedItem = comboBox_MauSac.Items[0];
                // - Thoi Gian Bao Hanh
                comboBox_ThoiGianBaoHanh.Items.Add("--Không quan tâm--");
                foreach (myChiTietDongLaptopDTO laptop in dsLapTop)
                {
                    bool trace = true;
                    for (int index = 0; index < comboBox_ThoiGianBaoHanh.Items.Count; index++)
                    {
                        if (string.Compare(comboBox_ThoiGianBaoHanh.Items[index].ToString().Trim(), laptop.IThoiGianBaoHanh.ToString().Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        comboBox_ThoiGianBaoHanh.Items.Add(laptop.IThoiGianBaoHanh);
                }
                comboBox_ThoiGianBaoHanh.SelectedItem = comboBox_ThoiGianBaoHanh.Items[0];
                // - Gia Ban Hien Hanh
                comboBox_GiaBan.Items.Add("--Không quan tâm--");
                foreach (myChiTietDongLaptopDTO laptop in dsLapTop)
                {
                    bool trace = true;
                    for (int index = 0; index < comboBox_GiaBan.Items.Count; index++)
                    {
                        if (string.Compare(comboBox_GiaBan.Items[index].ToString().Trim(), laptop.FGiaBanHienHanh.ToString().Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        comboBox_GiaBan.Items.Add(laptop.FGiaBanHienHanh + " triệu đồng");
                }
                comboBox_GiaBan.SelectedItem = comboBox_GiaBan.Items[0];
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
            comboBox_CardMang.Items.Add("--Không quan tâm--");
            if (dsCardMang != null)
            {
                foreach (myChiTietDongCardMangDTO cardmang in dsCardMang)
                {
                    comboBox_CardMang.Items.Add(cardmang.STenDongCardMang);
                }
                comboBox_CardMang.SelectedItem = comboBox_CardMang.Items[0];
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
            comboBox_CardReader.Items.Add("--Không quan tâm--");
            if (dsCardReader != null)
            {
                foreach (myChiTietDongCardReaderDTO cardreader in dsCardReader)
                    comboBox_CardReader.Items.Add(cardreader.STenDongCardReader);
                comboBox_CardReader.SelectedItem = comboBox_CardReader.Items[0];
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
            comboBox_Webcam.Items.Add("--Không quan tâm--");
            if (dsWebcam != null)
            {
                foreach (myChiTietDongWebcamDTO webcam in dsWebcam)
                    comboBox_Webcam.Items.Add(webcam.STenDongWebCam);
                comboBox_Webcam.SelectedItem = comboBox_Webcam.Items[0];
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

            comboBox_Pin.Items.Add("--Không quan tâm--");
            if (dsPin != null)
            {
                foreach (myChiTietDongPinDTO pin in dsPin)
                {
                    bool trace = true;
                    for (int index = 0; index < comboBox_Pin.Items.Count; index++)
                    {
                        if (string.Compare(comboBox_Pin.Items[index].ToString().Trim(), pin.FTenDongPin.Trim(), true) == 0)
                        {

                            trace = false;
                        }
                    }
                    if (trace == true)
                        comboBox_Pin.Items.Add(pin.FTenDongPin);
                }

                comboBox_Pin.SelectedItem = comboBox_Pin.Items[0];
            }

            //Load Kha Nang Nhan Dang Van Tay
            comboBox_NhanDangVanTay.Items.Add("--Không quan tâm--");
            comboBox_NhanDangVanTay.Items.Add("Có");
            comboBox_NhanDangVanTay.Items.Add("Không");
            comboBox_NhanDangVanTay.SelectedItem = comboBox_NhanDangVanTay.Items[0];

            //Load Cong HDMI
            comboBox_HDMI.Items.Add("--Không quan tâm--");
            comboBox_HDMI.Items.Add("Có");
            comboBox_HDMI.Items.Add("Không");
            comboBox_HDMI.SelectedItem = comboBox_HDMI.Items[0];

            // Load So Cong USB
            comboBox_SoCongUSB.Items.Add("--Không quan tâm--");
            comboBox_SoCongUSB.Items.Add("1");
            comboBox_SoCongUSB.Items.Add("2");
            comboBox_SoCongUSB.Items.Add("3");
            comboBox_SoCongUSB.SelectedItem = comboBox_SoCongUSB.Items[0];

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
            comboBox_NhaSanXuat.Items.Add("--Không quan tâm--");
            if (dsNhaSX != null)
            {
                foreach (myNhaSanXuatDTO nhasx in dsNhaSX)
                {
                    comboBox_NhaSanXuat.Items.Add(nhasx.STenNhaSanXuat);
                }
                comboBox_NhaSanXuat.SelectedItem = comboBox_NhaSanXuat.Items[0];
            }
        }

        /// <summary>
        /// Xóa 1  số dòng Laptop trùng nhau trong danh sách kết quả tra cứu
        /// </summary>
        /// <param name="?"></param>
        private void RutGonDanhSach(List<myChiTietDongLaptopDTO> dsDongLapTop)
        {
            for (int i = 0; i < dsDongLapTop.Count - 1; i++)
                for (int j = i + 1; j < dsDongLapTop.Count; j++)
                    if (string.Compare(dsDongLapTop[i].STenChiTietDongLapTop, dsDongLapTop[j].STenChiTietDongLapTop, true) == 0)
                        dsDongLapTop.RemoveAt(j);
        }
        /// <summary>
        /// Xử lý việc tra cứu sản phẩm từ CSDL lên DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_XoaSanPham_Click(object sender, EventArgs e)
        {
            myChiTietDongLaptopBUS ChiTietDongLapTop = new myChiTietDongLaptopBUS();
            List<myChiTietDongLaptopDTO> dsLapTop = new List<myChiTietDongLaptopDTO>();
            InfoComboboxOfFormTraCuu Infocombobox = new InfoComboboxOfFormTraCuu();

            // Kiểm tra thông tin các combobox
            #region Info Combobox
            if (string.Compare(Combobox_TenDongLapTop.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.STendongLapTop = Combobox_TenDongLapTop.Text;
            }
            if (string.Compare(comboBox_Ram.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SRam = comboBox_Ram.Text;
            }
            if (string.Compare(comboBox_CPU.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SCPU = comboBox_CPU.Text;
            }
            if (string.Compare(comboBox_HardDisk.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SOCung = comboBox_HardDisk.Text;
            }
            if (string.Compare(comboBox_ManHinh.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SManHinh = comboBox_ManHinh.Text;
            }
            if (string.Compare(comboBox_CardManHinh.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SCardManHinh = comboBox_CardManHinh.Text;
            }
            if (string.Compare(comboBox_Loa.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SDongLoa = comboBox_Loa.Text;
            }
            if (string.Compare(comboBox_ODiaQuang.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SOQuang = comboBox_ODiaQuang.Text;
            }
            if (string.Compare(comboBox_HeDieuHanh.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SHeDieuHanh = comboBox_HeDieuHanh.Text;
            }
            if (string.Compare(comboBox_TrongLuong.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.FTrongLuong = float.Parse(comboBox_TrongLuong.Text);
            }
            if (string.Compare(comboBox_MauSac.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SMauSac = comboBox_MauSac.Text;
            }
            if (string.Compare(comboBox_CardMang.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SCardMang = comboBox_CardMang.Text;
            }
            if (string.Compare(comboBox_CardReader.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SCardReader = comboBox_CardReader.Text;
            }
            if (string.Compare(comboBox_Webcam.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SWebCam = comboBox_Webcam.Text;
            }
            if (string.Compare(comboBox_Pin.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SPin = comboBox_Pin.Text;
            }
            if (string.Compare(comboBox_NhanDangVanTay.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SNhanDangVanTay = comboBox_NhanDangVanTay.Text;
            }
            if (string.Compare(comboBox_HDMI.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SCongHDMI = comboBox_HDMI.Text;
            }
            if (string.Compare(comboBox_SoCongUSB.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.ISoCongUSB = int.Parse(comboBox_SoCongUSB.Text);
            }
            if (string.Compare(comboBox_NhaSanXuat.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SNhaSanXuat = comboBox_NhaSanXuat.Text;
            }
            if (string.Compare(comboBox_GiaBan.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.SGiaBan = comboBox_GiaBan.Text;
            }
            if (string.Compare(comboBox_ThoiGianBaoHanh.Text, "--Không quan tâm--") != 0)
            {
                Infocombobox.IThoigianBH = int.Parse(comboBox_ThoiGianBaoHanh.Text);
            }
            #endregion
            if (string.Compare(Infocombobox.STendongLapTop, null) == 0 && string.Compare(Infocombobox.SRam, null) == 0 &&
                string.Compare(Infocombobox.SCPU, null) == 0 && string.Compare(Infocombobox.SOCung, null) == 0 &&
                string.Compare(Infocombobox.SManHinh, null) == 0 && string.Compare(Infocombobox.SCardManHinh, null) == 0 &&
                string.Compare(Infocombobox.SDongLoa, null) == 0 && string.Compare(Infocombobox.SOQuang, null) == 0 &&
                string.Compare(Infocombobox.SHeDieuHanh, null) == 0 && Infocombobox.FTrongLuong == 0 &&
                string.Compare(Infocombobox.SMauSac, null) == 0 && string.Compare(Infocombobox.SCardMang, null) == 0 &&
                string.Compare(Infocombobox.SCardReader, null) == 0 && string.Compare(Infocombobox.SWebCam, null) == 0 &&
                string.Compare(Infocombobox.SPin, null) == 0 && string.Compare(Infocombobox.SNhanDangVanTay, null) == 0 &&
                string.Compare(Infocombobox.SCongHDMI, null) == 0 && Infocombobox.ISoCongUSB == 0 &&
                string.Compare(Infocombobox.SNhaSanXuat, null) == 0 && string.Compare(Infocombobox.SGiaBan, null) == 0 &&
                Infocombobox.IThoigianBH == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin trước khi tra cứu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dsLapTop = ChiTietDongLapTop.TraCuu(Infocombobox);
            gridTraCuu.Rows.Clear();
            if (dsLapTop == null || dsLapTop.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin tra cứu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RutGonDanhSach(dsLapTop);
            for (int i = 0; i < dsLapTop.Count; i++)
            {
                #region DataGridview Tra Cứu
                gridTraCuu.Rows.Add(dsLapTop[i].STenChiTietDongLapTop, dsLapTop[i].ChiTietDongRam.STenDongRAM, dsLapTop[i].ChiTietDongCPU.STenDongCPU, dsLapTop[i].ChiTietDongOCung.STenDongOCung,
                                    dsLapTop[i].ChiTietDongManHinh.STenDongManHinh, dsLapTop[i].ChiTietDongCacDoHoa.STenDongCardDoHoa,
                                    dsLapTop[i].ChiTietDongLoa.STenDongLoa, dsLapTop[i].ChiTietDongODiaQuang.STenDongODiaQuang, dsLapTop[i].ChiTietHeDieuHanh.STenHeDieuHanh, dsLapTop[i].ChiTietTrongLuong.FGiaTriTrongLuong,
                                    dsLapTop[i].SMauSac, dsLapTop[i].ChiTietDongCardMang.STenDongCardMang,
                                    dsLapTop[i].ChiTietDongCardReader.STenDongCardReader, dsLapTop[i].ChiTietDongWebCam.STenDongWebCam,
                                    dsLapTop[i].ChiTietDongPin.FThoiGianSuDung, Convert.ToBoolean(dsLapTop[i].BFingerprintReader), Convert.ToBoolean(dsLapTop[i].BHDMI),
                                    dsLapTop[i].ISoLuongCongUSB, dsLapTop[i].NhaSanXuat.STenNhaSanXuat,
                                    dsLapTop[i].FGiaBanHienHanh, dsLapTop[i].IThoiGianBaoHanh, dsLapTop[i].DanhGia.ITongDiem);
                #endregion
            }

        }

    }
}
