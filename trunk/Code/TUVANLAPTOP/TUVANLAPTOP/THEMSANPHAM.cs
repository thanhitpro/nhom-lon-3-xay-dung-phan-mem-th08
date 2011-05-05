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
            // Load Ram
            myChiTietDongRamBUS chiTietDongRam = new myChiTietDongRamBUS();
            List<myChiTietDongRamDTO> dsDongRam = new List<myChiTietDongRamDTO>();

            try
            {
                dsDongRam = chiTietDongRam.LayChiTietDongRam();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng ram", "Thông báo");
                this.Close();
            }

            foreach (myChiTietDongRamDTO ram in dsDongRam)
            {
                comboBox_Ram.Items.Add(ram);
            }
            comboBox_Ram.DisplayMember = "STenDongRAM";
            comboBox_Ram.SelectedItem = comboBox_Ram.Items[0];

            // Load CPU
            myChiTietDongCPUBUS chiTietDongCPU = new myChiTietDongCPUBUS();
            List<myChiTietDongCPUDTO> dsDongCPU = new List<myChiTietDongCPUDTO>();

            try
            {
                dsDongCPU = chiTietDongCPU.LayChiTietDongCPU();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng CPU", "Thông báo");
                this.Close();
            }

            foreach (myChiTietDongCPUDTO cpu in dsDongCPU)
                comboBox_CPU.Items.Add(cpu);
            comboBox_CPU.DisplayMember = "STenDongCPU";
            comboBox_CPU.SelectedItem = comboBox_CPU.Items[0];

            // Load O Cung
            myChiTietDongOCungBUS chiTietDongOCung = new myChiTietDongOCungBUS();
            List<myChiTietDongOCungDTO> dsDongOCung = new List<myChiTietDongOCungDTO>();

            try
            {
                dsDongOCung = chiTietDongOCung.LayChiTietDongOCung();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng ổ cứng", "Thông báo");
                this.Close();
            }

            foreach (myChiTietDongOCungDTO ocung in dsDongOCung)
                comboBox_HardDisk.Items.Add(ocung);
            comboBox_HardDisk.DisplayMember = "STenDongOCung";
            comboBox_HardDisk.SelectedItem = comboBox_HardDisk.Items[0];

            // Load Man Hinh
            myChiTietDongManHinhBUS chiTietManHinh = new myChiTietDongManHinhBUS();
            List<myChiTietDongManHinhDTO> dsManHinh = new List<myChiTietDongManHinhDTO>();

            try
            {
                dsManHinh = chiTietManHinh.LayChiTietDongManHinh();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng màn hình", "Thông báo");
                this.Close();
            }

            foreach (myChiTietDongManHinhDTO manhinh in dsManHinh)
            {
                comboBox_ManHinh.Items.Add(manhinh);
            }

            comboBox_ManHinh.DisplayMember = "STenDongManHinh";
            comboBox_ManHinh.SelectedItem = comboBox_ManHinh.Items[0];

            // Load Card Man Hinh
            myChiTietDongCardDoHoaBUS chiTietCardDoHoa = new myChiTietDongCardDoHoaBUS();
            List<myChiTietDongCardDoHoaDTO> dsCardDoHoa = new List<myChiTietDongCardDoHoaDTO>();
            try
            {
                dsCardDoHoa = chiTietCardDoHoa.LayChiTietDongCardDoHoa();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng card đồ họa", "Thông báo");
                this.Close();
            }
            foreach (myChiTietDongCardDoHoaDTO carddohoa in dsCardDoHoa)
                comboBox_CardManHinh.Items.Add(carddohoa);

            comboBox_CardManHinh.DisplayMember = "STenDongCardDoHoa";
            comboBox_CardManHinh.SelectedItem = comboBox_CardManHinh.Items[0];

            // Load Dong Loa
            myChiTietDongLoaBUS chiTietDongLoa = new myChiTietDongLoaBUS();
            List<myChiTietDongLoaDTO> dsLoa = new List<myChiTietDongLoaDTO>();
            try
            {
                dsLoa = chiTietDongLoa.LayChiTietDongLoa();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng loa", "Thông báo");
                this.Close();
            }
            foreach (myChiTietDongLoaDTO loa in dsLoa)
                comboBox_Loa.Items.Add(loa);

            comboBox_Loa.DisplayMember = "STenDongLoa";
            comboBox_Loa.SelectedItem = comboBox_Loa.Items[0];

            // Load O Quang
            myChiTietDongODiaQuangBUS chiTietDongDQ = new myChiTietDongODiaQuangBUS();
            List<myChiTietDongODiaQuangDTO> dsDiaQuang = new List<myChiTietDongODiaQuangDTO>();
            try
            {
                dsDiaQuang = chiTietDongDQ.LayChiTietDongODiaQuang();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng ổ đĩa quang", "Thông báo");
                this.Close();
            }
            foreach (myChiTietDongODiaQuangDTO diaquang in dsDiaQuang)
                comboBox_ODiaQuang.Items.Add(diaquang);
            comboBox_ODiaQuang.DisplayMember = "STenDongODiaQuang";
            comboBox_ODiaQuang.SelectedItem = comboBox_ODiaQuang.Items[0];

            //Load HDH
            myChiTietHeDieuHanhBUS chiTietHDH = new myChiTietHeDieuHanhBUS();
            List<myChiTietHeDieuHanhDTO> dsHDH = new List<myChiTietHeDieuHanhDTO>();
            try
            {
                dsHDH = chiTietHDH.LayChiTietHeDieuHanh();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết hệ điều hành", "Thông báo");
                this.Close();
            }
            foreach (myChiTietHeDieuHanhDTO hdh in dsHDH)
                comboBox_HeDieuHanh.Items.Add(hdh);

            comboBox_HeDieuHanh.DisplayMember = "STenHeDieuHanh";
            comboBox_HeDieuHanh.SelectedItem = comboBox_HeDieuHanh.Items[0];
            //Load Trong Luong
            myChiTietTrongLuongBUS chiTietTL = new myChiTietTrongLuongBUS();
            List<myChiTietTrongLuongDTO> dsTrongLuong = new List<myChiTietTrongLuongDTO>();
            try
            {
                dsTrongLuong = chiTietTL.LayChiTietTrongLuong();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết trọng lượng", "Thông báo");
                this.Close();
            }
            foreach (myChiTietTrongLuongDTO tl in dsTrongLuong)
                comboBox_TrongLuong.Items.Add(tl);
            comboBox_TrongLuong.DisplayMember = "FGiaTriTrongLuong";
            comboBox_TrongLuong.SelectedItem = comboBox_TrongLuong.Items[0];

            //Load Ten Dong LapTop & Mau Sac & Thoi Gian Bao Hanh & Gia Ban

            List<myChiTietDongLaptopDTO> dsLapTop = new List<myChiTietDongLaptopDTO>();
            try
            {
                dsLapTop = myChiTietDongLaptopBUS.LayChiTietDongLaptop();
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
                this.Close();
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
                MessageBox.Show("Lỗi khi lấy chi tiết dòng card mạng", "Thông báo");
                this.Close();
            }
            foreach (myChiTietDongCardMangDTO cardmang in dsCardMang)
            {
                comboBox_CardMang.Items.Add(cardmang);
            }
            comboBox_CardMang.DisplayMember = "STenDongCardMang";
            comboBox_CardMang.SelectedItem = comboBox_CardMang.Items[0];

            //Load CardReader
            myChiTietDongCardReaderBUS chiTietCardReader = new myChiTietDongCardReaderBUS();
            List<myChiTietDongCardReaderDTO> dsCardReader = new List<myChiTietDongCardReaderDTO>();
            try
            {
                dsCardReader = chiTietCardReader.LayChiTietDongCardReader();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng card reader", "Thông báo");
                this.Close();
            }
            foreach (myChiTietDongCardReaderDTO cardreader in dsCardReader)
                comboBox_CardReader.Items.Add(cardreader);
            comboBox_CardReader.DisplayMember = "STenDongCardReader";
            comboBox_CardReader.SelectedItem = comboBox_CardReader.Items[0];

            //Load WebCam
            myChiTietDongWebcamBUS chiTietWebCam = new myChiTietDongWebcamBUS();
            List<myChiTietDongWebcamDTO> dsWebcam = new List<myChiTietDongWebcamDTO>();
            try
            {
                dsWebcam = chiTietWebCam.LayChiTietDongWebcam();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng webcam", "Thông báo");
                this.Close();
            }
            foreach (myChiTietDongWebcamDTO webcam in dsWebcam)
                comboBox_Webcam.Items.Add(webcam);
            comboBox_Webcam.DisplayMember = "STenDongWebCam";
            comboBox_Webcam.SelectedItem = comboBox_Webcam.Items[0];

            //Load Pin
            myChiTietDongPinBUS chiTietPin = new myChiTietDongPinBUS();
            List<myChiTietDongPinDTO> dsPin = new List<myChiTietDongPinDTO>();
            try
            {
                dsPin = chiTietPin.LayChiTietDongPin();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy chi tiết dòng pin", "Thông báo");
                this.Close();
            }
            foreach (myChiTietDongPinDTO pin in dsPin)
                comboBox_Pin.Items.Add(pin);
            comboBox_Pin.DisplayMember = "FTenDongPin";
            comboBox_Pin.SelectedItem = comboBox_Pin.Items[0];

            //Load Kha Nang Nhan Dang Van Tay
            comboBox_NhanDangVanTay.Items.Add("Có");
            comboBox_NhanDangVanTay.Items.Add("Không");
            comboBox_NhanDangVanTay.SelectedItem = comboBox_NhanDangVanTay.Items[0];

            //Load Cong HDMI
            comboBox_HDMI.Items.Add("Có");
            comboBox_HDMI.Items.Add("Không");
            comboBox_HDMI.SelectedItem = comboBox_HDMI.Items[0];

            // Load So Cong USB
            comboBox_SoCongUSB.Items.Add("1");
            comboBox_SoCongUSB.Items.Add("2");
            comboBox_SoCongUSB.Items.Add("3");
            comboBox_SoCongUSB.Items.Add("4");
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
                MessageBox.Show("Lỗi khi lấy chi tiết nhà sản xuất", "Thông báo");
                this.Close();
            }
            foreach (myNhaSanXuatDTO nhasx in dsNhaSX)
            {
                comboBox_NhaSanXuat.Items.Add(nhasx);
            }
            comboBox_NhaSanXuat.DisplayMember = "STenNhaSanXuat";
            comboBox_NhaSanXuat.SelectedItem = comboBox_NhaSanXuat.Items[0];
        }

        /// <summary>
        /// Ham xu ly khi click vao button ThemSanPham
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_ThemSanPham_Click(object sender, EventArgs e)
        {
            CHITIETDONGLAPTOP dongLaptopMoi = new CHITIETDONGLAPTOP();
            //tên dòng laptop
            if ((this.textBox_TenDongLapTop.Text.Length < 5) || (this.textBox_TenDongLapTop.Text.Length > 30))
            {
                MessageBox.Show("Tên dòng laptop có chiều dài từ 5 đến 30 ký tự");
                textBox_TenDongLapTop.Focus();
                return;
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
                MessageBox.Show("Thời gian bảo hành phải là 1 con số","Thông báo");
                return;
            }

            //giá hiện hành
            try
            {
                double giaHienHanh = 0f;
                giaHienHanh = double.Parse(textBox_giaTienTrieu.Text);
                giaHienHanh *= 1000;
                giaHienHanh += double.Parse(textBox_giaTienTramNgan.Text);
                dongLaptopMoi.GiaBanHienHanh = giaHienHanh;
            }
            catch
            {
                MessageBox.Show("Giá tiền phải là số không chứa chữ","Thông báo");
                textBox_giaTienTrieu.Focus();
                return;
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
                MessageBox.Show("Mô tả thêm dài hơn 512 ký tự, xin nhập lại","Thông báo");
                richTextBox_moTaThem.Focus();
                return;
            }

            //số lượng nhập và số lượng còn lại

            try
            {
                dongLaptopMoi.SoLuongNhap = int.Parse(textBox_soLuongNhap.Text);
                dongLaptopMoi.SoLuongConLai = int.Parse(textBox_soLuongNhap.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng nhập phải là số nguyên!","Thông báo");
                textBox_soLuongNhap.Focus();
                return;
            }

            //ngày nhập
            dongLaptopMoi.NgayNhap = dateTimePicker_NgayNhap.Value;


            // đường dẫn file hình ảnh
            if (fileName == "")
            {
                MessageBox.Show("Chưa chọn file hình ảnh laptop!","Thông báo");
                return;
            }
            else
            {
                dongLaptopMoi.HinhAnh = fileName;
            }

            try
            {
                myChiTietDongLaptopBUS.ThemMoiChiTietDongLaptop(dongLaptopMoi);
                MessageBox.Show("Thêm sản phẩm mới thành công","Thông báo");
                fileName = "";
            }
            catch
            {
                MessageBox.Show("Thêm sản phẩm mới thất bại");
            }
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
            String imageFile = "";
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
    }
}
