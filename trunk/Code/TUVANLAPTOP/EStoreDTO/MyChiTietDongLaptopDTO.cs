using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongLaptopDTO
    {
        private int m_iMaDongLaptop;
        public int IMaDongLaptop
        {
            get { return this.m_iMaDongLaptop; }
            set { this.m_iMaDongLaptop = value; }
        }

        string m_sTenChiTietDongLapTop;

        public string STenChiTietDongLapTop
        {
            get { return this.m_sTenChiTietDongLapTop; }
            set { this.m_sTenChiTietDongLapTop = value; }
        }

        private MyChiTietDongRamDTO m_chiTietDongRam;

        public MyChiTietDongRamDTO ChiTietDongRam
        {
            get { return this.m_chiTietDongRam; }
            set { this.m_chiTietDongRam = value; }
        }

        MyChiTietDongOCungDTO m_chiTietDongOCung;

        public MyChiTietDongOCungDTO ChiTietDongOCung
        {
            get { return this.m_chiTietDongOCung; }
            set { this.m_chiTietDongOCung = value; }
        }

        MyChiTietDongCPUDTO m_chiTietDongCPU;

        public MyChiTietDongCPUDTO ChiTietDongCPU
        {
            get { return this.m_chiTietDongCPU; }
            set { this.m_chiTietDongCPU = value; }
        }

        MyChiTietDongManHinhDTO m_chiTietDongManHinh;

        public MyChiTietDongManHinhDTO ChiTietDongManHinh
        {
            get { return this.m_chiTietDongManHinh; }
            set { this.m_chiTietDongManHinh = value; }
        }

        MyChiTietDongCardDoHoaDTO m_chiTietDongCacDoHoa;

        public MyChiTietDongCardDoHoaDTO ChiTietDongCacDoHoa
        {
            get { return this.m_chiTietDongCacDoHoa; }
            set { this.m_chiTietDongCacDoHoa = value; }
        }

        MyChiTietDongLoaDTO m_chiTietDongLoa;

        public MyChiTietDongLoaDTO ChiTietDongLoa
        {
            get { return this.m_chiTietDongLoa; }
            set { this.m_chiTietDongLoa = value; }
        }

        MyChiTietDongODiaQuangDTO m_chiTietDongODiaQuang;

        public MyChiTietDongODiaQuangDTO ChiTietDongODiaQuang
        {
            get { return this.m_chiTietDongODiaQuang; }
            set { this.m_chiTietDongODiaQuang = value; }
        }

        MyChiTietDongCardMangDTO m_chiTietDongCardMang;

        public MyChiTietDongCardMangDTO ChiTietDongCardMang
        {
            get { return this.m_chiTietDongCardMang; }
            set { this.m_chiTietDongCardMang = value; }
        }

        MyChiTietDongCardReaderDTO m_chiTietDongCardReader;

        public MyChiTietDongCardReaderDTO ChiTietDongCardReader
        {
            get { return this.m_chiTietDongCardReader; }
            set { this.m_chiTietDongCardReader = value; }
        }

        MyChiTietDongWebcamDTO m_chiTietDongWebCam;

        public MyChiTietDongWebcamDTO ChiTietDongWebCam
        {
            get { return this.m_chiTietDongWebCam; }
            set { this.m_chiTietDongWebCam = value; }
        }

        MyChiTietDongPinDTO m_chiTietDongPin;

        public MyChiTietDongPinDTO ChiTietDongPin
        {
            get { return this.m_chiTietDongPin; }
            set { this.m_chiTietDongPin = value; }
        }

        MyChiTietHeDieuHanhDTO m_chiTietHeDieuHanh;

        public MyChiTietHeDieuHanhDTO ChiTietHeDieuHanh
        {
            get { return this.m_chiTietHeDieuHanh; }
            set { this.m_chiTietHeDieuHanh = value; }
        }

        Byte m_bFingerprintReader;

        public Byte BFingerprintReader
        {
            get { return this.m_bFingerprintReader; }
            set { this.m_bFingerprintReader = value; }
        }

        Byte m_bHDMI;

        public Byte BHDMI
        {
            get { return this.m_bHDMI; }
            set { this.m_bHDMI = value; }
        }

        int m_iSoLuongCongUSB;

        public int ISoLuongCongUSB
        {
            get { return this.m_iSoLuongCongUSB; }
            set { this.m_iSoLuongCongUSB = value; }
        }

        MyNhaSanXuatDTO m_nhaSanXuat;

        public MyNhaSanXuatDTO NhaSanXuat
        {
            get { return this.m_nhaSanXuat; }
            set { this.m_nhaSanXuat = value; }
        }

        MyDanhGiaDTO m_danhGia;

        public MyDanhGiaDTO DanhGia
        {
            get { return this.m_danhGia; }
            set { this.m_danhGia = value; }
        }

        float m_fGiaBanHienHanh;

        public float FGiaBanHienHanh
        {
            get { return this.m_fGiaBanHienHanh; }
            set { this.m_fGiaBanHienHanh = value; }
        }

        string m_sMoTaThem;

        public string SMoTaThem
        {
            get { return this.m_sMoTaThem; }
            set { this.m_sMoTaThem = value; }
        }

        int m_iSoLuongNhap;

        public int ISoLuongNhap
        {
            get { return this.m_iSoLuongNhap; }
            set { this.m_iSoLuongNhap = value; }
        }

        DateTime m_dNgayNhap;

        public DateTime DNgayNhap
        {
            get { return this.m_dNgayNhap; }
            set { this.m_dNgayNhap = value; }
        }
        int m_iSoLuongConLai;

        public int ISoLuongConLai
        {
            get { return this.m_iSoLuongConLai; }
            set { this.m_iSoLuongConLai = value; }
        }

        int m_iThoiGianBaoHanh;

        public int IThoiGianBaoHanh
        {
            get { return this.m_iThoiGianBaoHanh; }
            set { this.m_iThoiGianBaoHanh = value; }
        }

        string m_sHinhAnh;

        public string SHinhAnh
        {
            get { return this.m_sHinhAnh; }
            set { this.m_sHinhAnh = value; }
        }

        string m_sMauSac;

        public string SMauSac
        {
            get { return this.m_sMauSac; }
            set { this.m_sMauSac = value; }
        }

        private MyChiTietTrongLuongDTO m_chiTietTrongLuong;

        public MyChiTietTrongLuongDTO ChiTietTrongLuong
        {
            get { return this.m_chiTietTrongLuong; }
            set { this.m_chiTietTrongLuong = value; }
        }

        private bool m_bDeleted;

        public bool BDeleted
        {
            get { return this.m_bDeleted; }
            set { this.m_bDeleted = value; }
        }
    }
}
