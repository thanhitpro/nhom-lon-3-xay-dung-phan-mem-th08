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
using System.Xml;
namespace TUVANLAPTOP
{
    public partial class MANHINHCHINH : Form
    {
        public static int m_iStaticFormDuocChon;
        //0: form Quan Ly Xoa San Pham
        //1: form Them San Pham
        List<int> m_lDanhSachIDSanPhamDuocChon = new List<int>();
        private static KHACHHANG m_kKhachHang;
        public static KHACHHANG KKhachHang
        {
            get { return MANHINHCHINH.m_kKhachHang; }
            set { MANHINHCHINH.m_kKhachHang = value; }
        }

        public MANHINHCHINH()
        {
            InitializeComponent();
        }
        struct MyStruct
        {
            public double gt;
            public int id;
        }


        private void button_TuVanLapTop_Click(object sender, EventArgs e)
        {
            //Code thuật toán

            int IDNgheNghiep;
            int IDGioiTinh;
            int IDDoTuoi;
            int IDTinhThanh;
            int IDMucDich;
            int IDKhoangGia;
            string xPathNgheNghiep;
            string xPathGioiTinh;
            string xPathDoTuoi;
            string xPathTinhThanh;
            string xPathMucDich;
            string fileName = "ResultAnalyseData.xml";
            XmlNodeList nodeListNgheNghiep = null;
            XmlNodeList nodeListDoTuoi = null;
            XmlNodeList nodeListGioiTinh = null;
            XmlNodeList nodeListMucDich =null;
            XmlNodeList nodeListTinhThanh =null;
            List<MyStruct> KetQua = new List<MyStruct>();
            XmlDocument xmlDocument = new XmlDocument();
            List<CHITIETDONGLAPTOP> listLapTop = new List<CHITIETDONGLAPTOP>();
            int iSoLuongLapTopDatYeuCau = 0;
            m_lDanhSachIDSanPhamDuocChon.Clear();
            try
            {
                m_kKhachHang = new KHACHHANG();
            }
            catch
            {
                MessageBox.Show("Lỗi tạo khách hàng");
            }

            try
            {
                xmlDocument.Load(fileName);
            }
            catch (System.IO.FileNotFoundException fileNotFoundEx)
            {
                MessageBox.Show("không tìm thấy file " + fileName + "\nxin vui lòng kiểm tra lại, có thể dữ liệu hệ thống đã bị mất" + fileNotFoundEx.FileName);
            }
            catch (System.Xml.XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
                return;
            }
            catch (System.IO.FileLoadException fileLoadEx)
            {
                MessageBox.Show("có lỗi trong quá trình tải dữ liệu" + fileLoadEx.FileName);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LayDuLieuTuForm(out IDNgheNghiep, out IDGioiTinh, out IDDoTuoi, out IDTinhThanh, out IDMucDich, out IDKhoangGia);
            
            KhoiTaoKhachHang(IDNgheNghiep, IDDoTuoi, IDTinhThanh, IDMucDich);
            
            KhoiTaoXPath(IDNgheNghiep, IDGioiTinh, IDDoTuoi, IDTinhThanh, IDMucDich, out xPathNgheNghiep, out xPathGioiTinh, out xPathDoTuoi, out xPathTinhThanh, out xPathMucDich);

            LayDuLieuTuFileXML(xPathNgheNghiep, xPathGioiTinh, xPathDoTuoi, xPathTinhThanh, xPathMucDich, xmlDocument, out nodeListNgheNghiep, out nodeListDoTuoi, out nodeListGioiTinh, out nodeListMucDich, out nodeListTinhThanh);

            KetQua = ThuaNhanNaive(nodeListTinhThanh, nodeListNgheNghiep, nodeListDoTuoi, nodeListMucDich, nodeListGioiTinh);
            
            KetQua = SapXep(KetQua);

            if (KetQua==null)
            {
                return;
            }
            if (KetQua.Count > 3)
            {
                iSoLuongLapTopDatYeuCau = 3;
            }
            else
            {
                iSoLuongLapTopDatYeuCau = KetQua.Count;
            }

            for (int i = 0; i < iSoLuongLapTopDatYeuCau; i++)
            {
                if (KetQua.Count - i - 1 >= 0)
                {
                    int t = KetQua[KetQua.Count - i - 1].id;
                    m_lDanhSachIDSanPhamDuocChon.Add(t);
                }
            }

            SANPHAMTUVAN frm = SANPHAMTUVAN.Instance();
            frm.Tag = m_lDanhSachIDSanPhamDuocChon;
            frm.ShowDialog();
        }

        /// <summary>
        /// Sắp xếp list MyStruct
        /// Đầu vào là một list phần tử kiểu MyStruct
        /// </summary>
        /// <returns>
        ///     Thành công: trả về List MyStruct đã được sắp xếp tăng dần
        ///     Thất bại: throw một Exception ra màn hình
        /// </returns>
        private List<MyStruct> SapXep(List<MyStruct> listSanPham)
        {
            if (listSanPham == null)
            {
                return null;
            }
            for (int i = 0; i < listSanPham.Count; i++)
            {
                for (int j = i; j < listSanPham.Count; j++)
                {
                    if (listSanPham[i].gt > listSanPham[j].gt)
                    {
                        MyStruct temp = new MyStruct();
                        temp = listSanPham[i];
                        listSanPham[i] = listSanPham[j];
                        listSanPham[j] = temp;
                    }
                }
            }
            return listSanPham;
        }

        /// <summary>
        /// Thực thi thuật toán thừa nhận Naive
        /// Sau khi đã có được các tỉ lệ mua máy tính theo từng yếu tố
        /// Áp dụng thừa nhận Naive.
        /// Mỗi dòng máy tính tương ứng với các tỉ lệ về tỉnh thành, nghề nghiệp...
        /// Áp dụng thừa nhận naive cho mỗi dòng máy bằng cách tính tích các tỉ lệ
        /// Kết hợp với việc kiểm tra giá tiền hợp lệ
        /// Kết hợp kiểm tra máy tính có còn tồn tại trong cửa hàng hay không
        /// Lưu tích của các tỉ lệ của mỗi dòng máy vào một list kiểu MyStruct
        /// </summary>
        /// <returns>
        ///     Thành công: trả về list phần tử kiểu MyStruct
        ///     Thất bại: throw một Exception ra màn hình
        /// </returns>
        private List<MyStruct> ThuaNhanNaive(XmlNodeList nodeListTinhThanh, XmlNodeList nodeListNgheNghiep, XmlNodeList nodeListDoTuoi, XmlNodeList nodeListMucDich, XmlNodeList nodeListGioiTinh)
        {
            List<MyStruct> KetQua = new List<MyStruct>();
            for (int i = 0; i < nodeListNgheNghiep.Count; i++)
            {
                double temp = 0;
                if (nodeListTinhThanh[i].InnerText != null)
                    temp = (double.Parse(nodeListTinhThanh[i].InnerText));
                if (nodeListNgheNghiep[i].InnerText != null)
                    temp *= (double.Parse(nodeListNgheNghiep[i].InnerText));
                if (nodeListMucDich[i].InnerText != null)
                    temp *= (double.Parse(nodeListMucDich[i].InnerText));
                if (nodeListGioiTinh[i].InnerText != null)
                    temp *= (double.Parse(nodeListGioiTinh[i].InnerText));
                if (nodeListDoTuoi[i].InnerText != null)
                    temp *= (double.Parse(nodeListDoTuoi[i].InnerText));
                MyStruct myStruct = new MyStruct();
                myStruct.gt = temp;
                myStruct.id = i;
                try
                {
                    bool a = myChiTietDongLaptopBUS.KiemTraGiaTienHopLe(myStruct.id + 1, comboBoxMucGia.SelectedIndex);
                    if (a == true)
                        if (myChiTietDongLaptopBUS.KiemTraSanPhamTonTai(myStruct.id + 1) == false)
                        {
                            KetQua.Add(myStruct);
                        }

                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("kết nối bị lỗi, hoặc bạn ko có quyền thực hiện thao tác trên" + ex.Message);
                    KetQua = null;
                }
            }
            return KetQua;
            
        }

        /// <summary>
        /// Lấy các node list trong file XML dựa vào các XPath và xmlDocument(Biến toàn cục)
        /// </summary>
        /// <returns>
        ///     Thành công: lưu dữ liệu vào các node list được truyền vào
        ///     Thất bại: xuất message box exception gặp phải
        /// </returns>
        private static void LayDuLieuTuFileXML(string xPathNgheNghiep, string xPathGioiTinh, string xPathDoTuoi, string xPathTinhThanh, string xPathMucDich, XmlDocument xmlDocument, out XmlNodeList nodeListNgheNghiep, out XmlNodeList nodeListDoTuoi, out XmlNodeList nodeListGioiTinh, out XmlNodeList nodeListMucDich, out XmlNodeList nodeListTinhThanh)
        {
                string xPath = xPathNgheNghiep;
                nodeListNgheNghiep = xmlDocument.SelectNodes(xPath);
                xPath = xPathDoTuoi;
                nodeListDoTuoi = xmlDocument.SelectNodes(xPath);
                xPath = xPathGioiTinh;
                nodeListGioiTinh = xmlDocument.SelectNodes(xPath);
                xPath = xPathMucDich;
                nodeListMucDich = xmlDocument.SelectNodes(xPath);
                xPath = xPathTinhThanh;
                nodeListTinhThanh = xmlDocument.SelectNodes(xPath);
        }

        /// <summary>
        /// Khởi tạo chuỗi XPath
        /// </summary>
        /// <returns>
        ///     Thành công: lưu dữ liệu vào các chuỗi được truyền vào
        /// </returns>
        private static void KhoiTaoXPath(int IDNgheNghiep, int IDGioiTinh, int IDDoTuoi, int IDTinhThanh, int IDMucDich, out string xPathNgheNghiep, out string xPathGioiTinh, out string xPathDoTuoi, out string xPathTinhThanh, out string xPathMucDich)
        {
            xPathNgheNghiep = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_NGHE_NGHIEP/NGHE_NGHIEP/@TyLeGiaoDich[../@ID='" + IDNgheNghiep.ToString() + "']";
            xPathGioiTinh = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_GIOI_TINH/GIOI_TINH/@TyLeGiaoDich[../@ID='" + IDGioiTinh.ToString() + "']";
            xPathDoTuoi = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_DO_TUOI/DO_TUOI/@TyLeGiaoDich[../@ID='" + IDDoTuoi.ToString() + "']";
            xPathTinhThanh = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_TINH_THANH/TINH_THANH/@TyLeGiaoDich[../@ID='" + IDTinhThanh.ToString() + "']";
            xPathMucDich = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_MUC_DICH_SU_DUNG/MUC_DICH/@TyLeGiaoDich[../@ID='" + IDMucDich.ToString() + "']";
        }

        /// <summary>
        /// Khởi tạo khách hàng
        /// </summary>
        /// <returns>
        ///     Thành công: Khởi tạo đối tượng khách hàng(biến toàn cục)
        ///     Thất bại: xuất message box exception gặp phải
        /// </returns>
        private void KhoiTaoKhachHang(int IDNgheNghiep, int IDDoTuoi, int IDTinhThanh, int IDMucDich)
        {
            try
            {
                KKhachHang.MaDoTuoi = IDDoTuoi;
                KKhachHang.MaMucDichSuDung = IDMucDich;
                KKhachHang.MaNgheNghiep = IDNgheNghiep;
                KKhachHang.MaTinhThanh = IDTinhThanh;
                KKhachHang.GioiTinhNam = (1 == (comboBoxGioiTinh.SelectedIndex + 1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Lấy dữ liệu từ form chương trình
        /// </summary>
        /// <returns>
        ///     Thành công: lưu dữ liệu các tham số được truyền vào
        /// </returns>
        private void LayDuLieuTuForm(out int IDNgheNghiep, out int IDGioiTinh, out int IDDoTuoi, out int IDTinhThanh, out int IDMucDich, out int IDKhoangGia)
        {
            IDNgheNghiep = comboBoxNgheNghiep.SelectedIndex + 1;
            IDGioiTinh = comboBoxGioiTinh.SelectedIndex;
            IDDoTuoi = comboBoxDoTuoi.SelectedIndex + 1;
            IDTinhThanh = comboBoxTinhThanh.SelectedIndex + 1;
            IDMucDich = comboBoxMucDichSD.SelectedIndex + 1;
            IDKhoangGia = comboBoxMucGia.SelectedIndex + 1;
        }

        /// <summary>
        /// About
        /// </summary>
        private void AboutUsMenuItem_Click(object sender, EventArgs e)
        {
            ABOUT frm = ABOUT.Instance();
            frm.ShowDialog();
        }

        /// <summary>
        /// Help
        /// </summary>
        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            HELP frm = HELP.Instance();
            frm.ShowDialog();
        }

        /// <summary>
        /// Khởi tạo cho form giao diện
        /// </summary>
        /// <returns>
        ///     Thành công: form giao diện có các dữ liệu mặc định
        ///     Thật bại: Throw một exception lên giao diện
        /// </returns>
        private void MANHINHCHINH_Load(object sender, EventArgs e)
        {
            myNgheNghiepBUS ngheNghiepDAO = new myNgheNghiepBUS();
            List<NGHENGHIEP> listNgheNghiep = new List<NGHENGHIEP>();
            myDoTuoiBUS doTuoiDAO = new myDoTuoiBUS();
            List<DOTUOI> listDoTuoi = new List<DOTUOI>();
            myTinhThanhBUS tinhThanhDAO = new myTinhThanhBUS();
            List<TINHTHANH> listTinhThanh = new List<TINHTHANH>();
            myMucDichSuDungBUS mucDichSuDungDAO = new myMucDichSuDungBUS();
            List<MUCDICHSUDUNG> listMucDichSuDung = new List<MUCDICHSUDUNG>();

            try
            {
                listNgheNghiep = ngheNghiepDAO.LayNgheNghiep();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai"+ex.Message);
            }
            comboBoxNgheNghiep.DataSource = listNgheNghiep;
            comboBoxNgheNghiep.DisplayMember = "TenNgheNghiep";
            
            try
            {
                listDoTuoi = doTuoiDAO.LayDoTuoi();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai"+ex.Message);
            }
            comboBoxDoTuoi.DataSource = listDoTuoi;
            comboBoxDoTuoi.DisplayMember = "TenDoTuoi";
            
            try
            {
                listTinhThanh = tinhThanhDAO.LayTinhThanh();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai"+ex.Message);
            }
            comboBoxTinhThanh.DataSource = listTinhThanh;
            comboBoxTinhThanh.DisplayMember = "TenTinhThanh";
            
            try
            {
                listMucDichSuDung = mucDichSuDungDAO.LayMucDichSuDung();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai"+ex.Message);
            }
            comboBoxMucDichSD.DataSource = listMucDichSuDung;
            comboBoxMucDichSD.DisplayMember = "TenMucDichSuDung";
            comboBoxGioiTinh.SelectedIndex = 0;
            comboBoxMucGia.SelectedIndex = 0;
        }

        /// <summary>
        /// Chức năng xóa sản phẩm
        /// </summary>
        /// <returns>
        ///     Thành công: Hiện lên form xóa sản phẩm
        /// </returns>
        private void XoaSanPhamItem_Click(object sender, EventArgs e)
        {
            MANHINHCHINH.m_iStaticFormDuocChon = 0;
            DANGNHAP frm = new DANGNHAP();
                frm.ShowDialog();
        }

        /// <summary>
        /// Chức năng tra cứu sản phẩm
        /// </summary>
        /// <returns>
        ///     Thành công: Hiện lên form tra cứu sản phẩm
        /// </returns>
        private void TraCuuSanPhamItem_Click(object sender, EventArgs e)
        {
            TRACUUSANPHAM frm = new TRACUUSANPHAM();
            frm.ShowDialog();
        }

        /// <summary>
        /// Chức năng thêm mới sản phẩm
        /// </summary>
        /// <returns>
        ///     Thành công: Hiện lên form thêm mới sản phẩm
        /// </returns>
        private void ThemMoiSanPhamItem_Click(object sender, EventArgs e)
        {
            MANHINHCHINH.m_iStaticFormDuocChon = 1;
            DANGNHAP frm = new DANGNHAP();
                frm.ShowDialog();      
        }

        /// <summary>
        /// Chức năng thay đổi thông tin sản phẩm
        /// </summary>
        /// <returns>
        ///     Thành công: Hiện lên form thay đổi thông tin sản phẩm
        /// </returns>
        private void ThayDoiThongTinSP_Click(object sender, EventArgs e)
        {
            MANHINHCHINH.m_iStaticFormDuocChon = 2;
            DANGNHAP frm = new DANGNHAP();
            frm.ShowDialog();      
        }

        /// <summary>
        /// Chức năng thêm thông tin sản phẩm
        /// </summary>
        /// <returns>
        ///     Thành công: Hiện lên form thêm thông tin sản phẩm
        /// </returns>
        private void btn_ThemThongTin_Click(object sender, EventArgs e)
        {
            MANHINHCHINH.m_iStaticFormDuocChon = 3;
            DANGNHAP frm = new DANGNHAP();
            frm.ShowDialog(); 
        }
    }
}
