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

            int IDNgheNghiep, IDGioiTinh, IDDoTuoi, IDTinhThanh, IDMucDich, IDKhoangGia;
            IDNgheNghiep = comboBoxNgheNghiep.SelectedIndex + 1;
            IDGioiTinh = comboBoxGioiTinh.SelectedIndex;
            IDDoTuoi = comboBoxDoTuoi.SelectedIndex + 1;
            IDTinhThanh = comboBoxTinhThanh.SelectedIndex + 1;
            IDMucDich = comboBoxMucDichSD.SelectedIndex + 1;
            IDKhoangGia = comboBoxMucGia.SelectedIndex + 1;
            try
            {
                m_kKhachHang = new KHACHHANG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo khách hàng");
                throw;
            }
            KKhachHang.MaDoTuoi = IDDoTuoi;
            KKhachHang.MaMucDichSuDung = IDMucDich;
            KKhachHang.MaNgheNghiep = IDNgheNghiep;
            KKhachHang.MaTinhThanh = IDTinhThanh;
            KKhachHang.GioiTinhNam = (1 == (comboBoxGioiTinh.SelectedIndex + 1));

            List<CHITIETDONGLAPTOP> listLapTop = new List<CHITIETDONGLAPTOP>();

            string xPathNgheNghiep = "/NAVAS_BAYES/NHASANXUAT/TY_LE_THEO_NGHE_NGHIEP/NGHE_NGHIEP/@TyLeGiaoDich[../@ID='" + IDNgheNghiep.ToString() + "']";
            string xPathGioiTinh = "/NAVAS_BAYES/NHASANXUAT/TY_LE_THEO_GIOI_TINH/GIOI_TINH/@TyLeGiaoDich[../@ID='" + IDGioiTinh.ToString() + "']";
            string xPathDoTuoi = "/NAVAS_BAYES/NHASANXUAT/TY_LE_THEO_DO_TUOI/DO_TUOI/@TyLeGiaoDich[../@ID='" + IDDoTuoi.ToString() + "']";
            string xPathTinhThanh = "/NAVAS_BAYES/NHASANXUAT/TY_LE_THEO_TINH_THANH/TINH_THANH/@TyLeGiaoDich[../@ID='" + IDTinhThanh.ToString() + "']";
            string xPathMucDich = "/NAVAS_BAYES/NHASANXUAT/TY_LE_THEO_MUC_DICH_SU_DUNG/MUC_DICH/@TyLeGiaoDich[../@ID='" + IDMucDich.ToString() + "']";


            string fileName = "ResultAnalyseData.xml";

            XmlDocument xmlDocument = new XmlDocument();
            try
            {
                xmlDocument.Load(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không load được dữ liệu\n Kiểm tra lại file xml");
            }

            string xPath = xPathNgheNghiep;
            XmlNodeList nodeListNgheNghiep = xmlDocument.SelectNodes(xPath);
            xPath = xPathDoTuoi;
            XmlNodeList nodeListDoTuoi = xmlDocument.SelectNodes(xPath);
            xPath = xPathGioiTinh;
            XmlNodeList nodeListGioiTinh = xmlDocument.SelectNodes(xPath);
            xPath = xPathMucDich;
            XmlNodeList nodeListMucDich = xmlDocument.SelectNodes(xPath);
            xPath = xPathTinhThanh;
            XmlNodeList nodeListTinhThanh = xmlDocument.SelectNodes(xPath);

            List<MyStruct> KetQua = new List<MyStruct>();

            ///
            ///Ap dung thuat toan
            ///
            for (int i = 0; i < nodeListNgheNghiep.Count; i++)
            {
                double temp = 0;
                try
                {
                    temp = (double.Parse(nodeListTinhThanh[i].InnerText))
                        * (double.Parse(nodeListNgheNghiep[i].InnerText))
                        * (double.Parse(nodeListMucDich[i].InnerText))
                        * (double.Parse(nodeListGioiTinh[i].InnerText))
                        * (double.Parse(nodeListDoTuoi[i].InnerText));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi dữ liệu không hợp lệ");
                }
                MyStruct myStruct = new MyStruct();
                myStruct.gt = temp;
                myStruct.id = i;

                if (myChiTietDongLaptopBUS.KiemTraGiaTienHopLe(myStruct.id + 1, comboBoxMucGia.SelectedIndex) == true)
                    KetQua.Add(myStruct);
            }
            ///
            ///Sap xep theo thu tu tang dan cua diem
            ///
            for (int i = 0; i < KetQua.Count; i++)
            {
                for (int j = i; j < KetQua.Count; j++)
                {
                    if (KetQua[i].gt > KetQua[j].gt)
                    {
                        MyStruct temp = new MyStruct();
                        temp = KetQua[i];
                        KetQua[i] = KetQua[j];
                        KetQua[j] = temp;
                    }
                }
            }
            ///
            ///Lay ra 3 id cua 3 san pham co so diem cao nhat o cuoi list
            ///Do la cac san pham se duoc tu van cho khach hang
            ///Vi li do csdl hien tai rat it nen chi su ung 3 la cao nhat
            ///

            int iSoLuongLapTopDatYeuCau = 0;
            if (KetQua.Count > 3)
            {
                iSoLuongLapTopDatYeuCau = 3;
            }
            else
            {
                iSoLuongLapTopDatYeuCau = KetQua.Count;
            }

            m_lDanhSachIDSanPhamDuocChon.Clear();
            //Dua ID cua san pham duoc chon vao list
            for (int i = 0; i < iSoLuongLapTopDatYeuCau; i++)
            {
                if (KetQua.Count - i - 1 >= 0)
                {
                    int t = KetQua[KetQua.Count - i - 1].id;
                    m_lDanhSachIDSanPhamDuocChon.Add(t);
                }
            }

            ///////////////////////////////////////////////////////////////////
            ///      Danh sach id cac san pham se duoc hien thi la          ///
            ///             DanhSachIDSanPhamDuocChon                       ///
            ///////////////////////////////////////////////////////////////////


            SANPHAMTUVAN frm = SANPHAMTUVAN.Instance();
            frm.Tag = m_lDanhSachIDSanPhamDuocChon;
            frm.ShowDialog();
        }

        private void AboutUsMenuItem_Click(object sender, EventArgs e)
        {
            ABOUT frm = ABOUT.Instance();
            frm.ShowDialog();
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            HELP frm = HELP.Instance();
            frm.ShowDialog();
        }

        private void MANHINHCHINH_Load(object sender, EventArgs e)
        {
            myNgheNghiepBUS ngheNghiepDAO = new myNgheNghiepBUS();
            List<NGHENGHIEP> listNgheNghiep = new List<NGHENGHIEP>();
            try
            {
                listNgheNghiep = ngheNghiepDAO.LayNgheNghiep();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai");
                throw;
            }
            comboBoxNgheNghiep.DataSource = listNgheNghiep;
            comboBoxNgheNghiep.DisplayMember = "TenNgheNghiep";
            myDoTuoiBUS doTuoiDAO = new myDoTuoiBUS();
            List<DOTUOI> listDoTuoi = new List<DOTUOI>();
            try
            {
                listDoTuoi = doTuoiDAO.LayDoTuoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai");
                throw;
            }
            comboBoxDoTuoi.DataSource = listDoTuoi;
            comboBoxDoTuoi.DisplayMember = "TenDoTuoi";
            myTinhThanhBUS tinhThanhDAO = new myTinhThanhBUS();
            List<TINHTHANH> listTinhThanh = new List<TINHTHANH>();
            try
            {
                listTinhThanh = tinhThanhDAO.LayTinhThanh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai");
                throw;
            }
            comboBoxTinhThanh.DataSource = listTinhThanh;
            comboBoxTinhThanh.DisplayMember = "TenTinhThanh";

            myMucDichSuDungBUS mucDichSuDungDAO = new myMucDichSuDungBUS();
            List<MUCDICHSUDUNG> listMucDichSuDung = new List<MUCDICHSUDUNG>();
            try
            {
                listMucDichSuDung = mucDichSuDungDAO.LayMucDichSuDung();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong ket noi duoc csdl\nVui long kiem tra lai");
                throw;
            }
            comboBoxMucDichSD.DataSource = listMucDichSuDung;
            comboBoxMucDichSD.DisplayMember = "TenMucDichSuDung";
            comboBoxGioiTinh.SelectedIndex = 0;
            comboBoxMucGia.SelectedIndex = 0;
        }

        private void button_CapNhatCSDL_Click(object sender, EventArgs e)
        {
            AlgorithmNavasBayes.AnalyseData();
        }

        private void XoaSanPhamItem_Click(object sender, EventArgs e)
        {
            if (DANGNHAP.m_bIsLogin == false)
            {
                DANGNHAP frm = new DANGNHAP();
                frm.Show();
            }
            //CAPNHATXOASANPHAM frm = CAPNHATXOASANPHAM.Instance();
            //frm.ShowDialog();
        }

        private void TraCuuSanPhamItem_Click(object sender, EventArgs e)
        {
            TRACUUSANPHAM frm = new TRACUUSANPHAM();
            frm.ShowDialog();
        }
    }
}
