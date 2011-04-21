using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongLaptopDTO
    {
        private int m_iMaDongLaptop;
        public int IMaDongLaptop
        {
            get { return m_iMaDongLaptop; }
            set { m_iMaDongLaptop = value; }
        }

        string m_sTenChiTietDongLapTop;

        public string STenChiTietDongLapTop
        {
            get { return m_sTenChiTietDongLapTop; }
            set { m_sTenChiTietDongLapTop = value; }
        }

        private myChiTietDongRamDTO m_chiTietDongRam;

        public myChiTietDongRamDTO ChiTietDongRam
        {
            get { return m_chiTietDongRam; }
            set { m_chiTietDongRam = value; }
        }

        myChiTietDongOCungDTO m_chiTietDongOCung;

        public myChiTietDongOCungDTO ChiTietDongOCung
        {
            get { return m_chiTietDongOCung; }
            set { m_chiTietDongOCung = value; }
        }

        myChiTietDongCPUDTO m_chiTietDongCPU;

        public myChiTietDongCPUDTO ChiTietDongCPU
        {
            get { return m_chiTietDongCPU; }
            set { m_chiTietDongCPU = value; }
        }

        myChiTietDongManHinhDTO m_chiTietDongManHinh;

        public myChiTietDongManHinhDTO ChiTietDongManHinh
        {
            get { return m_chiTietDongManHinh; }
            set { m_chiTietDongManHinh = value; }
        }

        myChiTietDongCardDoHoaDTO m_chiTietDongCacDoHoa;

        public myChiTietDongCardDoHoaDTO ChiTietDongCacDoHoa
        {
            get { return m_chiTietDongCacDoHoa; }
            set { m_chiTietDongCacDoHoa = value; }
        }

        myChiTietDongLoaDTO m_chiTietDongLoa;

        public myChiTietDongLoaDTO ChiTietDongLoa
        {
            get { return m_chiTietDongLoa; }
            set { m_chiTietDongLoa = value; }
        }

        myChiTietDongODiaQuangDTO m_chiTietDongODiaQuang;

        public myChiTietDongODiaQuangDTO ChiTietDongODiaQuang
        {
            get { return m_chiTietDongODiaQuang; }
            set { m_chiTietDongODiaQuang = value; }
        }

        myChiTietDongCardMangDTO m_chiTietDongCardMang;

        public myChiTietDongCardMangDTO ChiTietDongCardMang
        {
            get { return m_chiTietDongCardMang; }
            set { m_chiTietDongCardMang = value; }
        }

        myChiTietDongCardReaderDTO m_chiTietDongCardReader;

        public myChiTietDongCardReaderDTO ChiTietDongCardReader
        {
            get { return m_chiTietDongCardReader; }
            set { m_chiTietDongCardReader = value; }
        }

        myChiTietDongWebcamDTO m_chiTietDongWebCam;

        public myChiTietDongWebcamDTO ChiTietDongWebCam
        {
            get { return m_chiTietDongWebCam; }
            set { m_chiTietDongWebCam = value; }
        }

        myChiTietDongPinDTO m_chiTietDongPin;

        public myChiTietDongPinDTO ChiTietDongPin
        {
            get { return m_chiTietDongPin; }
            set { m_chiTietDongPin = value; }
        }

        myChiTietHeDieuHanhDTO m_chiTietHeDieuHanh;

        public myChiTietHeDieuHanhDTO ChiTietHeDieuHanh
        {
            get { return m_chiTietHeDieuHanh; }
            set { m_chiTietHeDieuHanh = value; }
        }

        Byte m_bFingerprintReader;

        public Byte BFingerprintReader
        {
            get { return m_bFingerprintReader; }
            set { m_bFingerprintReader = value; }
        }

        Byte m_bHDMI;

        public Byte BHDMI
        {
            get { return m_bHDMI; }
            set { m_bHDMI = value; }
        }

        int m_iSoLuongCongUSB;

        public int ISoLuongCongUSB
        {
            get { return m_iSoLuongCongUSB; }
            set { m_iSoLuongCongUSB = value; }
        }

        myNhaSanXuatDTO m_nhaSanXuat;

        public myNhaSanXuatDTO NhaSanXuat
        {
            get { return m_nhaSanXuat; }
            set { m_nhaSanXuat = value; }
        }

        myDanhGiaDTO m_danhGia;

        public myDanhGiaDTO DanhGia
        {
            get { return m_danhGia; }
            set { m_danhGia = value; }
        }

        float m_fGiaBanHienHanh;

        public float FGiaBanHienHanh
        {
            get { return m_fGiaBanHienHanh; }
            set { m_fGiaBanHienHanh = value; }
        }

        string m_sMoTaThem;

        public string SMoTaThem
        {
            get { return m_sMoTaThem; }
            set { m_sMoTaThem = value; }
        }

        int m_iSoLuongNhap;

        public int ISoLuongNhap
        {
            get { return m_iSoLuongNhap; }
            set { m_iSoLuongNhap = value; }
        }

        int m_iSoLuongConLai;

        public int ISoLuongConLai
        {
            get { return m_iSoLuongConLai; }
            set { m_iSoLuongConLai = value; }
        }

        int m_iThoiGianBaoHanh;

        public int IThoiGianBaoHanh
        {
            get { return m_iThoiGianBaoHanh; }
            set { m_iThoiGianBaoHanh = value; }
        }

        string m_sHinhAnh;

        public string SHinhAnh
        {
            get { return m_sHinhAnh; }
            set { m_sHinhAnh = value; }
        }

        string m_sMauSac;

        public string SMauSac
        {
            get { return m_sMauSac; }
            set { m_sMauSac = value; }
        }

        private myChiTietTrongLuongDTO m_chiTietTrongLuong;

        public myChiTietTrongLuongDTO ChiTietTrongLuong
        {
            get { return m_chiTietTrongLuong; }
            set { m_chiTietTrongLuong = value; }
        }

        private bool m_bDeleted;

        public bool BDeleted
        {
            get { return m_bDeleted; }
            set { m_bDeleted = value; }
        }
    }
}
