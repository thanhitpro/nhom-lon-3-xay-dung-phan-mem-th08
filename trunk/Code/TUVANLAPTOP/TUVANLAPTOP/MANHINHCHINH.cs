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
        public static KHACHHANG m_kKhachHang;
        public static KHACHHANG KKhachHang
        {
            get { return MANHINHCHINH.m_kKhachHang; }
            set { MANHINHCHINH.m_kKhachHang = value; }
        }

        public MANHINHCHINH()
        {
            InitializeComponent();
        }
        public struct MyStruct
        {
            public double gt;
            public int id;
        }

        public void button_TuVanLapTop_Click(object sender, EventArgs e)
        {
            int IDNgheNghiep = -1;
            int IDGioiTinh = -1;
            int IDDoTuoi = -1;
            int IDTinhThanh = -1;
            int IDMucDich = -1;
            int IDKhoangGia = -1;
            int iSoLuongLapTopDatYeuCau = 3;
            AlgorithmNavasBayes thuatToan = new AlgorithmNavasBayes();
            List<EStoreBUS.MyStruct> listSanPham = new List<EStoreBUS.MyStruct>();

            try
            {
                LayDuLieuTuForm(out IDNgheNghiep, out IDGioiTinh, out IDDoTuoi, out IDTinhThanh, out IDMucDich, out IDKhoangGia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            KKhachHang = new KHACHHANG();
            KKhachHang.MaDoTuoi = IDDoTuoi;
            KKhachHang.MaMucDichSuDung = IDMucDich;
            KKhachHang.MaNgheNghiep = IDNgheNghiep;
            KKhachHang.MaTinhThanh = IDTinhThanh;
            if (IDGioiTinh == 0)
            {
                KKhachHang.GioiTinhNam = false;
            }
            else
                KKhachHang.GioiTinhNam = true;
            listSanPham = thuatToan.ThuatToanNaiveBayes(IDNgheNghiep, IDGioiTinh, IDDoTuoi, IDTinhThanh, IDMucDich, IDKhoangGia);
            iSoLuongLapTopDatYeuCau = listSanPham.Count;
            m_lDanhSachIDSanPhamDuocChon.Clear();
            for (int i = 0; i < iSoLuongLapTopDatYeuCau; i++)
            {
                int t = listSanPham[i].id;
                m_lDanhSachIDSanPhamDuocChon.Add(t);
            }

            SANPHAMTUVAN frm = SANPHAMTUVAN.Instance();
            frm.Tag = m_lDanhSachIDSanPhamDuocChon;
            frm.ShowDialog();
        }

        /// <summary>
        /// Lấy dữ liệu từ form chương trình
        /// </summary>
        /// <returns>
        ///     Thành công: trả về các tham số đã được truyền vào
        ///     Thất bại: throw một Exception ra màn hình
        /// </returns>
        public void LayDuLieuTuForm(out int IDNgheNghiep, out int IDGioiTinh, out int IDDoTuoi, out int IDTinhThanh, out int IDMucDich, out int IDKhoangGia)
        {
            IDNgheNghiep = -1;
            IDGioiTinh = -1;
            IDDoTuoi = -1;
            IDTinhThanh = -1;
            IDMucDich = -1;
            IDKhoangGia = -1;
            try
            {
                IDNgheNghiep = comboBoxNgheNghiep.SelectedIndex + 1;
                IDGioiTinh = comboBoxGioiTinh.SelectedIndex;
                IDDoTuoi = comboBoxDoTuoi.SelectedIndex + 1;
                IDTinhThanh = comboBoxTinhThanh.SelectedIndex + 1;
                IDMucDich = comboBoxMucDichSD.SelectedIndex + 1;
                IDKhoangGia = comboBoxMucGia.SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// About
        /// </summary>
        public void AboutUsMenuItem_Click(object sender, EventArgs e)
        {
            ABOUT frm = ABOUT.Instance();
            frm.ShowDialog();
        }

        /// <summary>
        /// Help
        /// </summary>
        public void HelpMenuItem_Click(object sender, EventArgs e)
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
        public void MANHINHCHINH_Load(object sender, EventArgs e)
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
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai" + ex.Message);
            }
            comboBoxNgheNghiep.DataSource = listNgheNghiep;
            comboBoxNgheNghiep.DisplayMember = "TenNgheNghiep";

            try
            {
                listDoTuoi = doTuoiDAO.LayDoTuoi();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai" + ex.Message);
            }
            comboBoxDoTuoi.DataSource = listDoTuoi;
            comboBoxDoTuoi.DisplayMember = "TenDoTuoi";

            try
            {
                listTinhThanh = tinhThanhDAO.LayTinhThanh();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai" + ex.Message);
            }
            comboBoxTinhThanh.DataSource = listTinhThanh;
            comboBoxTinhThanh.DisplayMember = "TenTinhThanh";

            try
            {
                listMucDichSuDung = mucDichSuDungDAO.LayMucDichSuDung();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai" + ex.Message);
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
        public void XoaSanPhamItem_Click(object sender, EventArgs e)
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
        public void TraCuuSanPhamItem_Click(object sender, EventArgs e)
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
        public void ThemMoiSanPhamItem_Click(object sender, EventArgs e)
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
        public void ThayDoiThongTinSP_Click(object sender, EventArgs e)
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
        public void btn_ThemThongTin_Click(object sender, EventArgs e)
        {
            MANHINHCHINH.m_iStaticFormDuocChon = 3;
            DANGNHAP frm = new DANGNHAP();
            frm.ShowDialog();
        }
    }
}
