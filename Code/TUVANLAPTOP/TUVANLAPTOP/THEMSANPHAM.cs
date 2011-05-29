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
using System.Drawing.Imaging;

namespace TUVANLAPTOP
{
    public partial class THEMSANPHAM : Form
    {
        public THEMSANPHAM()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load thong tin chi tiet cua laptop len cac combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void THEMSANPHAM_Load(object sender, EventArgs e)
        {
            LoadRAM();
            LoadCPU();
            LoadOCung();
            LoadManHinh();
            LoadCardManHinh();
            LoadDongLoa();
            LoadODiaQuang();
            LoadHeDieuHanh();
            LoadTrongLuong();
            LoadTenVaMauSac();
            LoadCardMang();
            LoadCardReader();
            LoadWebcam();
            LoadPin();
            LoadKhaNangNhanDangVanTay();
            LoadCongHDMI();
            LoadSoCongUSB();
            LoadNhaSX();
        }

        /// <summary>
        /// load RAM từ csdl lên form
        /// </summary>
        /// <returns>true: thanh cong - false: that bai.</returns>

        public bool LoadRAM()
        {
            MyChiTietDongRamBUS chiTietDongRam = new MyChiTietDongRamBUS();
            List<myChiTietDongRamDTO> dsDongRam = new List<myChiTietDongRamDTO>();

            try
            {
                dsDongRam = chiTietDongRam.LayChiTietDongRam();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng ram", "Thông báo");
                return false;
            }

            foreach (myChiTietDongRamDTO ram in dsDongRam)
            {
                comboBox_Ram.Items.Add(ram);
            }
            comboBox_Ram.DisplayMember = "STenDongRAM";
            comboBox_Ram.SelectedItem = comboBox_Ram.Items[0];
            return true;
        }

        /// <summary>
        /// load CPU từ csdl lên form
        /// </summary>
        public bool LoadCPU()
        {
            MyChiTietDongCPUBUS chiTietDongCPU = new MyChiTietDongCPUBUS();
            List<myChiTietDongCPUDTO> dsDongCPU = new List<myChiTietDongCPUDTO>();

            try
            {
                dsDongCPU = chiTietDongCPU.LayChiTietDongCPU();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng CPU", "Thông báo");
                return false;
            }

            foreach (myChiTietDongCPUDTO cpu in dsDongCPU)
                comboBox_CPU.Items.Add(cpu);
            comboBox_CPU.DisplayMember = "STenDongCPU";
            comboBox_CPU.SelectedItem = comboBox_CPU.Items[0];
            return true;
        }

        /// <summary>
        /// load ổ cứng từ csdl lên form
        /// </summary>
        public bool LoadOCung()
        {
            MyChiTietDongOCungBUS chiTietDongOCung = new MyChiTietDongOCungBUS();
            List<myChiTietDongOCungDTO> dsDongOCung = new List<myChiTietDongOCungDTO>();

            try
            {
                dsDongOCung = chiTietDongOCung.LayChiTietDongOCung();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng ổ cứng", "Thông báo");
                return false;
            }

            foreach (myChiTietDongOCungDTO ocung in dsDongOCung)
                comboBox_HardDisk.Items.Add(ocung);
            comboBox_HardDisk.DisplayMember = "STenDongOCung";
            comboBox_HardDisk.SelectedItem = comboBox_HardDisk.Items[0];
            return true;
        }

        /// <summary>
        /// load màn hình từ csdl lên form
        /// </summary>
        public bool LoadManHinh()
        {
            MyChiTietDongManHinhBUS chiTietManHinh = new MyChiTietDongManHinhBUS();
            List<myChiTietDongManHinhDTO> dsManHinh = new List<myChiTietDongManHinhDTO>();

            try
            {
                dsManHinh = chiTietManHinh.LayChiTietDongManHinh();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng màn hình", "Thông báo");
                return false;
            }

            foreach (myChiTietDongManHinhDTO manhinh in dsManHinh)
            {
                comboBox_ManHinh.Items.Add(manhinh);
            }

            comboBox_ManHinh.DisplayMember = "STenDongManHinh";
            comboBox_ManHinh.SelectedItem = comboBox_ManHinh.Items[0];
            return true;
        }

        /// <summary>
        /// load card màn hình từ csdl lên form
        /// </summary>
        public bool LoadCardManHinh()
        {
            MyChiTietDongCardDoHoaBUS chiTietCardDoHoa = new MyChiTietDongCardDoHoaBUS();
            List<myChiTietDongCardDoHoaDTO> dsCardDoHoa = new List<myChiTietDongCardDoHoaDTO>();
            try
            {
                dsCardDoHoa = chiTietCardDoHoa.LayChiTietDongCardDoHoa();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng card đồ họa", "Thông báo");
                return false;
            }
            foreach (myChiTietDongCardDoHoaDTO carddohoa in dsCardDoHoa)
                comboBox_CardManHinh.Items.Add(carddohoa);

            comboBox_CardManHinh.DisplayMember = "STenDongCardDoHoa";
            comboBox_CardManHinh.SelectedItem = comboBox_CardManHinh.Items[0];
            return true;
        }

        /// <summary>
        /// load dòng loa từ csdl lên form
        /// </summary>
        public bool LoadDongLoa()
        {
            MyChiTietDongLoaBUS chiTietDongLoa = new MyChiTietDongLoaBUS();
            List<myChiTietDongLoaDTO> dsLoa = new List<myChiTietDongLoaDTO>();
            try
            {
                dsLoa = chiTietDongLoa.LayChiTietDongLoa();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng loa", "Thông báo");
                return false;
            }
            foreach (myChiTietDongLoaDTO loa in dsLoa)
                comboBox_Loa.Items.Add(loa);

            comboBox_Loa.DisplayMember = "STenDongLoa";
            comboBox_Loa.SelectedItem = comboBox_Loa.Items[0];
            return true;
        }

        /// <summary>
        /// load ổ đĩa quang từ csdl lên form
        /// </summary>
        public bool LoadODiaQuang()
        {
            MyChiTietDongODiaQuangBUS chiTietDongDQ = new MyChiTietDongODiaQuangBUS();
            List<myChiTietDongODiaQuangDTO> dsDiaQuang = new List<myChiTietDongODiaQuangDTO>();
            try
            {
                dsDiaQuang = chiTietDongDQ.LayChiTietDongODiaQuang();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng ổ đĩa quang", "Thông báo");
                return false;
            }
            foreach (myChiTietDongODiaQuangDTO diaquang in dsDiaQuang)
                comboBox_ODiaQuang.Items.Add(diaquang);
            comboBox_ODiaQuang.DisplayMember = "STenDongODiaQuang";
            comboBox_ODiaQuang.SelectedItem = comboBox_ODiaQuang.Items[0];
            return true;
        }

        /// <summary>
        /// load hệ điều hành từ csdl lên form
        /// </summary>
        public bool LoadHeDieuHanh()
        {
            MyChiTietHeDieuHanhBUS chiTietHDH = new MyChiTietHeDieuHanhBUS();
            List<myChiTietHeDieuHanhDTO> dsHDH = new List<myChiTietHeDieuHanhDTO>();
            try
            {
                dsHDH = chiTietHDH.LayChiTietHeDieuHanh();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết hệ điều hành", "Thông báo");
                return false;
            }
            foreach (myChiTietHeDieuHanhDTO hdh in dsHDH)
                comboBox_HeDieuHanh.Items.Add(hdh);

            comboBox_HeDieuHanh.DisplayMember = "STenHeDieuHanh";
            comboBox_HeDieuHanh.SelectedItem = comboBox_HeDieuHanh.Items[0];
            return true;
        }

        /// <summary>
        /// load trọng lượng từ csdl lên form
        /// </summary>
        public bool LoadTrongLuong()
        {
            MyChiTietTrongLuongBUS chiTietTL = new MyChiTietTrongLuongBUS();
            List<myChiTietTrongLuongDTO> dsTrongLuong = new List<myChiTietTrongLuongDTO>();
            try
            {
                dsTrongLuong = chiTietTL.LayChiTietTrongLuong();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết trọng lượng", "Thông báo");
                return false;
            }
            foreach (myChiTietTrongLuongDTO tl in dsTrongLuong)
                comboBox_TrongLuong.Items.Add(tl);
            comboBox_TrongLuong.DisplayMember = "FGiaTriTrongLuong";
            comboBox_TrongLuong.SelectedItem = comboBox_TrongLuong.Items[0];
            return true;
        }

        /// <summary>
        /// load tên, màu sắc, giá tiền từ csdl lên form
        /// </summary>
        public bool LoadTenVaMauSac()
        {
            List<myChiTietDongLaptopDTO> dsLapTop = new List<myChiTietDongLaptopDTO>();
            try
            {
                dsLapTop = MyChiTietDongLaptopBUS.LayDanhSachChiTietDongLaptop();
                // - Mau Sac-
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice");
                return false;
            }

            return true;
        }

        /// <summary>
        /// load card mạng từ csdl lên form
        /// </summary>
        public bool LoadCardMang()
        {
            MyChiTietDongCardMangBUS chiTietCardMang = new MyChiTietDongCardMangBUS();
            List<myChiTietDongCardMangDTO> dsCardMang = new List<myChiTietDongCardMangDTO>();
            try
            {
                dsCardMang = chiTietCardMang.LayChiTietDongCardMang();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng card mạng", "Thông báo");
                return false;
            }
            foreach (myChiTietDongCardMangDTO cardmang in dsCardMang)
            {
                comboBox_CardMang.Items.Add(cardmang);
            }
            comboBox_CardMang.DisplayMember = "STenDongCardMang";
            comboBox_CardMang.SelectedItem = comboBox_CardMang.Items[0];
            return true;
        }

        /// <summary>
        /// load card reader từ csdl lên form
        /// </summary>
        public bool LoadCardReader()
        {
            MyChiTietDongCardReaderBUS chiTietCardReader = new MyChiTietDongCardReaderBUS();
            List<myChiTietDongCardReaderDTO> dsCardReader = new List<myChiTietDongCardReaderDTO>();
            try
            {
                dsCardReader = chiTietCardReader.LayChiTietDongCardReader();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng card reader", "Thông báo");
                return false;
            }
            foreach (myChiTietDongCardReaderDTO cardreader in dsCardReader)
                comboBox_CardReader.Items.Add(cardreader);
            comboBox_CardReader.DisplayMember = "STenDongCardReader";
            comboBox_CardReader.SelectedItem = comboBox_CardReader.Items[0];
            return true;
        }

        /// <summary>
        /// load webcam từ csdl lên form
        /// </summary>
        public bool LoadWebcam()
        {
            MyChiTietDongWebcamBUS chiTietWebCam = new MyChiTietDongWebcamBUS();
            List<myChiTietDongWebcamDTO> dsWebcam = new List<myChiTietDongWebcamDTO>();
            try
            {
                dsWebcam = chiTietWebCam.LayChiTietDongWebcam();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng webcam", "Thông báo");
                return false;
            }
            foreach (myChiTietDongWebcamDTO webcam in dsWebcam)
                comboBox_Webcam.Items.Add(webcam);
            comboBox_Webcam.DisplayMember = "STenDongWebCam";
            comboBox_Webcam.SelectedItem = comboBox_Webcam.Items[0];
            return true;
        }

        /// <summary>
        /// load pin từ csdl lên form
        /// </summary>
        public bool LoadPin()
        {
            MyChiTietDongPinBUS chiTietPin = new MyChiTietDongPinBUS();
            List<myChiTietDongPinDTO> dsPin = new List<myChiTietDongPinDTO>();
            try
            {
                dsPin = chiTietPin.LayChiTietDongPin();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng pin", "Thông báo");
                return false;
            }
            foreach (myChiTietDongPinDTO pin in dsPin)
                comboBox_Pin.Items.Add(pin);
            comboBox_Pin.DisplayMember = "FTenDongPin";
            comboBox_Pin.SelectedItem = comboBox_Pin.Items[0];
            return true;
        }

        /// <summary>
        /// load khả năng nhận dạng vân tay từ csdl lên form
        /// </summary>
        public bool LoadKhaNangNhanDangVanTay()
        {
            try
            {
                comboBox_NhanDangVanTay.Items.Add("Có");
                comboBox_NhanDangVanTay.Items.Add("Không");
                comboBox_NhanDangVanTay.SelectedItem = comboBox_NhanDangVanTay.Items[0];
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

            return true;

        }

        /// <summary>
        /// load cổng HDMI từ csdl lên form
        /// </summary>
        public bool LoadCongHDMI()
        {
            try
            {
                comboBox_HDMI.Items.Add("Có");
                comboBox_HDMI.Items.Add("Không");
                comboBox_HDMI.SelectedItem = comboBox_HDMI.Items[0];
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

            return true;
        }

        /// <summary>
        /// load cổng usb từ csdl lên form
        /// </summary>
        public bool LoadSoCongUSB()
        {
            try
            {
                comboBox_SoCongUSB.Items.Add("1");
                comboBox_SoCongUSB.Items.Add("2");
                comboBox_SoCongUSB.Items.Add("3");
                comboBox_SoCongUSB.Items.Add("4");
                comboBox_SoCongUSB.SelectedItem = comboBox_SoCongUSB.Items[0];
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

            return true;
        }

        /// <summary>
        /// load nhà sx từ csdl lên form
        /// </summary>
        public bool LoadNhaSX()
        {
            MyNhaSanXuatBUS nhaSX = new MyNhaSanXuatBUS();
            List<myNhaSanXuatDTO> dsNhaSX = new List<myNhaSanXuatDTO>();
            try
            {
                dsNhaSX = nhaSX.LayNhaSanXuat();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết nhà sản xuất", "Thông báo");
                return false;
            }
            foreach (myNhaSanXuatDTO nhasx in dsNhaSX)
            {
                comboBox_NhaSanXuat.Items.Add(nhasx);
            }
            comboBox_NhaSanXuat.DisplayMember = "STenNhaSanXuat";
            comboBox_NhaSanXuat.SelectedItem = comboBox_NhaSanXuat.Items[0];
            return true;
        }


        /// <summary>
        /// Ham xu ly khi click vao button ThemSanPham
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_ThemSanPham_Click(object sender, EventArgs e)
        {
            CHITIETDONGLAPTOP dongLaptopMoi = new CHITIETDONGLAPTOP();
            dongLaptopMoi = LayThongTinLaptopMoi();

            if (ThemSanPhamMoi(dongLaptopMoi))
            {
                MessageBox.Show("Thêm sản phẩm mới thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm mới thất bại");
            }


        }

        /// <summary>
        /// lấy thông tin laptop mới từ form
        /// </summary>
        /// <returns>trả về một laptop mới</returns>
        public CHITIETDONGLAPTOP LayThongTinLaptopMoi()
        {
            CHITIETDONGLAPTOP dongLaptopMoi = new CHITIETDONGLAPTOP();
            //tên dòng laptop
            if ((this.textBox_TenDongLapTop.Text.Trim().Length < 5) || (this.textBox_TenDongLapTop.Text.Trim().Length > 30))
            {
                MessageBox.Show("Tên dòng laptop có chiều dài từ 5 đến 30 ký tự");
                textBox_TenDongLapTop.Focus();
                return null;
            }
            else
            {
                dongLaptopMoi.TenChiTietDongLapTop = textBox_TenDongLapTop.Text;
            }

            //dòng ram
            myChiTietDongRamDTO dongRam = (myChiTietDongRamDTO)comboBox_Ram.SelectedItem;
            dongLaptopMoi.MaDongRAM = dongRam.IMaDongRam;

            //dòng CPU
            myChiTietDongCPUDTO dongCPU = (myChiTietDongCPUDTO)comboBox_CPU.SelectedItem;
            dongLaptopMoi.MaDongCPU = dongCPU.IMaDongCPU;

            //dòng ô cứng
            myChiTietDongOCungDTO dongOCung = (myChiTietDongOCungDTO)comboBox_HardDisk.SelectedItem;
            dongLaptopMoi.MaDongOCung = dongOCung.IMaDongOCung;

            //dòng màn hình
            myChiTietDongManHinhDTO dongManHinh = (myChiTietDongManHinhDTO)comboBox_ManHinh.SelectedItem;
            dongLaptopMoi.MaDongManHinh = dongManHinh.IMaDongManHinh;

            // Card Man Hinh
            myChiTietDongCardDoHoaDTO dongCardDoHoa = (myChiTietDongCardDoHoaDTO)comboBox_CardManHinh.SelectedItem;
            dongLaptopMoi.MaDongCardDoHoa = dongCardDoHoa.IMaDongCardDoHoa;

            //Dong Loa
            myChiTietDongLoaDTO dongLoa = (myChiTietDongLoaDTO)comboBox_Loa.SelectedItem;
            dongLaptopMoi.MaDongLoa = dongLoa.IMaDongLoa;

            //O Quang
            myChiTietDongODiaQuangDTO oDiaQuang = (myChiTietDongODiaQuangDTO)comboBox_ODiaQuang.SelectedItem;
            dongLaptopMoi.MaDongODiaQuang = oDiaQuang.IMaDongODiaQuang;

            //HDH
            myChiTietHeDieuHanhDTO heDieuHanh = (myChiTietHeDieuHanhDTO)comboBox_HeDieuHanh.SelectedItem;
            dongLaptopMoi.MaHeDieuHanh = heDieuHanh.IMaHeDieuHanh;

            //Trong Luong
            myChiTietTrongLuongDTO trongLuong = (myChiTietTrongLuongDTO)comboBox_TrongLuong.SelectedItem;
            dongLaptopMoi.MaChiTietTrongLuong = trongLuong.IMaCHiTietTrongLuong;

            //Màu sắc
            dongLaptopMoi.MauSac = comboBox_MauSac.Text;

            //thời gian bảo hành
            try
            {
                dongLaptopMoi.ThoiGianBaoHanh = int.Parse(comboBox_ThoiGianBaoHanh.Text);
            }
            catch
            {
                MessageBox.Show("Thời gian bảo hành phải là 1 con số", "Thông báo");
                return null;
            }

            //giá hiện hành
            try
            {
                double giaHienHanh = 0f;
                giaHienHanh = double.Parse(textBox_giaTienTrieu.Text);
                giaHienHanh *= 1000;
                if (textBox_giaTienTramNgan.Text.Length != 0)
                {
                    giaHienHanh += double.Parse(textBox_giaTienTramNgan.Text);
                }
                dongLaptopMoi.GiaBanHienHanh = giaHienHanh;
            }
            catch
            {
                MessageBox.Show("Giá tiền phải là số không chứa chữ", "Thông báo");
                textBox_giaTienTrieu.Focus();
                return null;
            }

            //card mạng
            myChiTietDongCardMangDTO cardMang = (myChiTietDongCardMangDTO)comboBox_CardMang.SelectedItem;
            dongLaptopMoi.MaDongCardMang = cardMang.IMaDongCardMang;

            //CardReader
            myChiTietDongCardReaderDTO cardReader = (myChiTietDongCardReaderDTO)comboBox_CardReader.SelectedItem;
            dongLaptopMoi.MaDongCardReader = cardReader.IMaDongCardReader;

            //WebCam
            myChiTietDongWebcamDTO webcam = (myChiTietDongWebcamDTO)comboBox_Webcam.SelectedItem;
            dongLaptopMoi.MaDongWebCam = webcam.IMaDongWebcam;

            //Pin
            myChiTietDongPinDTO pin = (myChiTietDongPinDTO)comboBox_Pin.SelectedItem;
            dongLaptopMoi.MaDongPin = pin.IMaDongPin;

            //Kha Nang Nhan Dang Van Tay
            if (comboBox_NhanDangVanTay.Text == "Có")
                dongLaptopMoi.FingerprintReader = true;
            else
                dongLaptopMoi.FingerprintReader = false;

            //Cong HDMI
            if (comboBox_HDMI.Text == "Có")
                dongLaptopMoi.HDMI = true;
            else
                dongLaptopMoi.HDMI = false;

            //số lượng công usb
            dongLaptopMoi.SoLuongCongUSB = comboBox_SoCongUSB.SelectedIndex + 1;

            //Nhà Sản xuất
            myNhaSanXuatDTO nhaSanXuat = (myNhaSanXuatDTO)comboBox_NhaSanXuat.SelectedItem;
            dongLaptopMoi.MaNhaSanXuat = nhaSanXuat.IMaNhaSanXuat;
            //đã xóa
            dongLaptopMoi.Deleted = false;
            //mã đánh giá
            dongLaptopMoi.MaDanhGia = 1;

            // mô tả thêm
            if (richTextBox_moTaThem.Text.Length < 512)
            {
                dongLaptopMoi.MoTaThem = richTextBox_moTaThem.Text;
            }
            else
            {
                MessageBox.Show("Mô tả thêm dài hơn 512 ký tự, xin nhập lại", "Thông báo");
                richTextBox_moTaThem.Focus();
                return null;
            }

            //số lượng nhập và số lượng còn lại

            try
            {
                dongLaptopMoi.SoLuongNhap = int.Parse(textBox_soLuongNhap.Text);
                dongLaptopMoi.SoLuongConLai = int.Parse(textBox_soLuongNhap.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng nhập phải là số nguyên!", "Thông báo");
                textBox_soLuongNhap.Focus();
                return null;
            }

            //ngày nhập
            dongLaptopMoi.NgayNhap = dateTimePicker_NgayNhap.Value;


            // đường dẫn file hình ảnh
            if (fileName == "")
            {
                MessageBox.Show("Chưa chọn file hình ảnh laptop!", "Thông báo");
                return null;
            }
            else
            {
                dongLaptopMoi.HinhAnh = fileName;
            }

            return dongLaptopMoi;
        }

        /// <summary>
        /// Ham set du lieu tren text box, chi dung cho test
        /// </summary>
        /// <param name="tenLaptop"></param>
        public void GanThongTinTextBox_Test(string tenLaptop, string soLuongNhap, string giaBan, string hinhAnh)
        {
            textBox_TenDongLapTop.Text = tenLaptop;
            textBox_soLuongNhap.Text = soLuongNhap;
            textBox_giaTienTrieu.Text = giaBan;
            fileName = hinhAnh;
        }

        /// <summary>
        /// thêm một laptop mới vào cơ sở dữ liệu
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>true: thêm thành công - false: thêm thất bại</returns>
        public bool ThemSanPhamMoi(CHITIETDONGLAPTOP dongLaptopMoi)
        {
            try
            {
                MyChiTietDongLaptopBUS.ThemMoiChiTietDongLaptop(dongLaptopMoi);
                fileName = "";
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Ham xu ly textbox_giaTienTrieu chi duoc nhap ky tu so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_giaTienTrieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);

            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
                return;
            }
            if ((int)e.KeyChar == (int)Keys.Delete || (int)e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
                return;
            }
        }

        /// <summary>
        /// Ham xu ly textbox_giaTienTramNgan chi duoc nhap ky tu so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_giaTienTramNgan_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);

            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
                return;
            }
            if ((int)e.KeyChar == (int)Keys.Delete || (int)e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
                return;
            }
        }

        /// <summary>
        /// Ham xu ly textbox_soLuongNhap chi duoc nhap ky tu so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_soLuongNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);

            if ((int)e.KeyChar == 46)
            {
                e.Handled = true;
                return;
            }
            if ((int)e.KeyChar == (int)Keys.Delete || (int)e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
                return;
            }
        }

        String fileName = "";

        /// <summary>
        /// Ham xu ly khi click vao button Chon Hinh Anh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ChonHinhAnh_Click(object sender, EventArgs e)
        {
            //Tạo bộ lọc các file khi mở OpenDialog
            //Filter lọc ra các file để bạn dễ dàng lựa chọn (ví dụ các fiel jpg, png,....)
            openFileDialog1.Filter = "PNG Files|*.PNG|JPG Files|*.jpg";
            //Tên của hộp thoại hiện lên - Không có thì sẽ là mặc định
            openFileDialog1.Title = "Chọn hình ảnh";
            //Cho phép chọn nhiều file cùng lúc - Mặc định là false
            openFileDialog1.Multiselect = false;

            openFileDialog1.InitialDirectory = Application.StartupPath + "\\image";

            //InitialDirectory = @"C:/";
            //Mở hộp thoại
            openFileDialog1.ShowDialog();

            //Lấy giá trị
            //Nếu bạn chỉ chọn một file thì giá trị trả về sẽ là một chuỗi kiểu String
            //Vd:
            String imageFile = string.Empty;

            imageFile = openFileDialog1.FileName;
            //Kiểm tra xem file đúng định dạng
            if (!CheckImageFormat(imageFile))
            {
                MessageBox.Show("File bạn vừa chọn không đúng định dạng ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            imageFile = openFileDialog1.SafeFileName;
            String fileType = "";
            fileType = imageFile.Substring(imageFile.Length - 3, 3);
            //MessageBox.Show(fileType);
            if (fileType == "jpg" || fileType == "png")
            {
                DateTime dateTime = DateTime.Now;
                string codeFileName = dateTime.Day.ToString() + dateTime.Month.ToString() + dateTime.Year.ToString() + dateTime.Hour.ToString()
                    + dateTime.Minute.ToString() + dateTime.Second.ToString();
                System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath + "\\image\\" + codeFileName + imageFile);
                fileName = @"image/" + codeFileName + imageFile;
            }
            else
                MessageBox.Show("Chương trình chỉ hỗ trợ file JPG và PNG.");
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckImageFormat(string fileName)
        {
            try
            {
                using (Image image = Image.FromFile(fileName))

                    if (image.RawFormat.Equals(ImageFormat.Jpeg))
                    {
                        return true;
                    }
                    else if (image.RawFormat.Equals(ImageFormat.Png))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice");
                return false;
            }
        }
    }
}
