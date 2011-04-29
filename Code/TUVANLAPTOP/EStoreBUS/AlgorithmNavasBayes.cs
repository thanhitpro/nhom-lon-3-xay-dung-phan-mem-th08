using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class AlgorithmNavasBayes
    {
        // dựa vào dữ liệu khách hàng đã giao dịch dử dụng 1 phần thuật toán navas bayes phân tích ra kết quả đánh giá ban đầu

        public static void AnalyseData()
        {
            XmlDocument ResultAnalyseData = new XmlDocument();
            try
            {
                ResultAnalyseData.Load("ResultAnalyseData.xml");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            XmlNode NavasBayes = ResultAnalyseData.DocumentElement;
            NavasBayes.RemoveAll();
            List<NGHENGHIEP> DSNgheNgiep;
            List<MUCDICHSUDUNG> DSMucDichSuDung;
            List<DOTUOI> DSDoTuoi;
            List<TINHTHANH> DSTinhThanh;
           // List<GIAODICH> DSTatCaGiaoDich;
            int TongSoLuongGiaoDich = 0;
            //-- List<> DSNhaSanXuat;
            List<CHITIETDONGLAPTOP> DSDongLaptop;
            try
            {
                DSNgheNgiep = myNgheNghiepDAO.LayNgheNghiep();
                DSMucDichSuDung = myMucDichSuDungDAO.LayMucDichSuDung();
                DSDoTuoi = myDoTuoiDAO.LayDoTuoi();
                DSTinhThanh = myTinhThanhDAO.LayTinhThanh();
              //  DSTatCaGiaoDich = myGiaoDichDAO.LayGiaoDich();
                TongSoLuongGiaoDich = myGiaoDichDAO.LaySoLuongGiaoDich();
                // DSNhaSanXuat = myNhaSanXuatDAO.LayNhaSanXuat();
                DSDongLaptop = myChiTietDongLaptopDAO.LayTatCaChiTietDongLaptop();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            for (int i = 0; i < DSDongLaptop.Count; ++i)
            {
                List<GIAODICH> DSGiaoDichTheoDongLaptop;
                try
                {
                    DSGiaoDichTheoDongLaptop = myGiaoDichDAO.LayDanhSachGiaoDichTheoMaDongLapTop(DSDongLaptop[i].MaDongLapTop);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                // create thẻ xml
                XmlNode DongLapTop = ResultAnalyseData.CreateElement("DONGLAPTOP");
                XmlAttribute MaDongLapTop = ResultAnalyseData.CreateAttribute("ID");
                XmlAttribute TenDongLapTop = ResultAnalyseData.CreateAttribute("TenDongLaptop");
                XmlAttribute SoLuongDaBan = ResultAnalyseData.CreateAttribute("SoLuongDaBan");
                MaDongLapTop.Value = DSDongLaptop[i].MaDongLapTop.ToString();
                TenDongLapTop.Value = DSDongLaptop[i].TenChiTietDongLapTop;
                SoLuongDaBan.Value = DSGiaoDichTheoDongLaptop.Count.ToString();
                try
                {
                    DongLapTop.Attributes.Append(MaDongLapTop);
                    DongLapTop.Attributes.Append(TenDongLapTop);
                    DongLapTop.Attributes.Append(SoLuongDaBan);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                int k = 0;
                int SLCoGiaoDich = 0;
                int SLKhongGiaoDich = 0;
                // thong ke theo nghe nghiep
                XmlNode TyLeTheoNgheNghiep = ResultAnalyseData.CreateElement("TY_LE_THEO_NGHE_NGHIEP");
                for (k = 0; k < DSNgheNgiep.Count; ++k)
                {
                    SLCoGiaoDich = SLKhongGiaoDich = 0;
                    XmlNode NgheNgiep = ResultAnalyseData.CreateElement("NGHE_NGHIEP");
                    XmlAttribute MaNgheNghiep = ResultAnalyseData.CreateAttribute("ID");
                    XmlAttribute TenNgheNghiep = ResultAnalyseData.CreateAttribute("TenNgheNghiep");
                    XmlAttribute TyLeGiaoDich = ResultAnalyseData.CreateAttribute("TyLeGiaoDich");
                    XmlAttribute TyLeKhongGiaoDich = ResultAnalyseData.CreateAttribute("TyLeKhongGiaoDich");
                    MaNgheNghiep.Value = DSNgheNgiep[k].MaNgheNghiep.ToString();
                    TenNgheNghiep.Value = DSNgheNgiep[k].TenNgheNghiep;

                    //****************
                    int SoLuongKhachHangTheoNgheNghiep;
                    try
                    {
                        SoLuongKhachHangTheoNgheNghiep = myKhachHangDAO.SLKhachHangTheoNgheNghiep(DSNgheNgiep[k].MaNgheNghiep);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    for (int j = 0; j < DSGiaoDichTheoDongLaptop.Count; ++j)
                    {

                        if (DSNgheNgiep[k].MaNgheNghiep == DSGiaoDichTheoDongLaptop[j].KHACHHANG.MaNgheNghiep)
                            SLCoGiaoDich++;
                    }

                    double a;
                    try
                    {
                        a = (float)((float)SLCoGiaoDich / (float)DSGiaoDichTheoDongLaptop.Count) * 100;
                        TyLeGiaoDich.Value = a.ToString();
                        SLKhongGiaoDich = SoLuongKhachHangTheoNgheNghiep - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = (((float)SLKhongGiaoDich / ((float)TongSoLuongGiaoDich - (float)DSGiaoDichTheoDongLaptop.Count)) * 100).ToString();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    try
                    {
                        NgheNgiep.Attributes.Append(MaNgheNghiep);
                        NgheNgiep.Attributes.Append(TenNgheNghiep);
                        NgheNgiep.Attributes.Append(TyLeGiaoDich);
                        NgheNgiep.Attributes.Append(TyLeKhongGiaoDich);
                        TyLeTheoNgheNghiep.AppendChild(NgheNgiep);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                DongLapTop.AppendChild(TyLeTheoNgheNghiep);

                // thong ke theo muc dich su dung

                XmlNode TyLeTheoMucDichSuDung = ResultAnalyseData.CreateElement("TY_LE_THEO_MUC_DICH_SU_DUNG");

                for (k = 0; k < DSMucDichSuDung.Count; ++k)
                {
                    SLCoGiaoDich = SLKhongGiaoDich = 0;
                    XmlNode MucDich = ResultAnalyseData.CreateElement("MUC_DICH");
                    XmlAttribute MaMucDich = ResultAnalyseData.CreateAttribute("ID");
                    XmlAttribute TenMucDich = ResultAnalyseData.CreateAttribute("TenMucDich");
                    XmlAttribute TyLeGiaoDich = ResultAnalyseData.CreateAttribute("TyLeGiaoDich");
                    XmlAttribute TyLeKhongGiaoDich = ResultAnalyseData.CreateAttribute("TyLeKhongGiaoDich");
                    MaMucDich.Value = DSMucDichSuDung[k].MaMucDichSuDung.ToString();
                    TenMucDich.Value = DSMucDichSuDung[k].TenMucDichSuDung;
                    int SLKhachHangTheoMucDich;
                    try
                    {
                        SLKhachHangTheoMucDich = myKhachHangDAO.SLKhachHangTheoMucDich(DSMucDichSuDung[k].MaMucDichSuDung);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    for (int j = 0; j < DSGiaoDichTheoDongLaptop.Count; ++j)
                    {
                        if (DSMucDichSuDung[k].MaMucDichSuDung == DSGiaoDichTheoDongLaptop[j].KHACHHANG.MaMucDichSuDung)
                            SLCoGiaoDich++;
                    }

                    try
                    {
                        TyLeGiaoDich.Value = ((float)((float)SLCoGiaoDich / (float)DSGiaoDichTheoDongLaptop.Count) * 100).ToString();
                        SLKhongGiaoDich = SLKhachHangTheoMucDich - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = (((float)SLKhongGiaoDich / ((float)TongSoLuongGiaoDich - (float)DSGiaoDichTheoDongLaptop.Count)) * 100).ToString();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    try
                    {

                        MucDich.Attributes.Append(MaMucDich);
                        MucDich.Attributes.Append(TenMucDich);
                        MucDich.Attributes.Append(TyLeGiaoDich);
                        MucDich.Attributes.Append(TyLeKhongGiaoDich);
                        TyLeTheoMucDichSuDung.AppendChild(MucDich);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                DongLapTop.AppendChild(TyLeTheoMucDichSuDung);
                // thong ke theo do tuoi
                XmlNode TyLeTheoDoTuoi = ResultAnalyseData.CreateElement("TY_LE_THEO_DO_TUOI");

                for (k = 0; k < DSDoTuoi.Count; ++k)
                {
                    SLCoGiaoDich = SLKhongGiaoDich = 0;
                    XmlNode DoTuoi = ResultAnalyseData.CreateElement("DO_TUOI");
                    XmlAttribute MaDoTuoi = ResultAnalyseData.CreateAttribute("ID");
                    XmlAttribute TenDoTuoi = ResultAnalyseData.CreateAttribute("TenDoTuoi");
                    XmlAttribute TyLeGiaoDich = ResultAnalyseData.CreateAttribute("TyLeGiaoDich");
                    XmlAttribute TyLeKhongGiaoDich = ResultAnalyseData.CreateAttribute("TyLeKhongGiaoDich");
                    MaDoTuoi.Value = DSDoTuoi[k].MaDoTuoi.ToString();
                    TenDoTuoi.Value = DSDoTuoi[k].TenDoTuoi;
                    int SLKhachHangTheoDoTuoi;
                    try
                    {
                        SLKhachHangTheoDoTuoi = myKhachHangDAO.SLKhachHangTheoDoTuoi(DSDoTuoi[k].MaDoTuoi);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    for (int j = 0; j < DSGiaoDichTheoDongLaptop.Count; ++j)
                    {

                        if (DSDoTuoi[k].MaDoTuoi == DSGiaoDichTheoDongLaptop[j].KHACHHANG.MaDoTuoi)
                            SLCoGiaoDich++;
                    }

                    try
                    {
                        TyLeGiaoDich.Value = (((float)SLCoGiaoDich / ((float)DSGiaoDichTheoDongLaptop.Count)) * 100).ToString();
                        SLKhongGiaoDich = SLKhachHangTheoDoTuoi - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = (((float)SLKhongGiaoDich / ((float)TongSoLuongGiaoDich - (float)DSGiaoDichTheoDongLaptop.Count)) * 100).ToString();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    try
                    {
                        DoTuoi.Attributes.Append(MaDoTuoi);
                        DoTuoi.Attributes.Append(TenDoTuoi);
                        DoTuoi.Attributes.Append(TyLeGiaoDich);
                        DoTuoi.Attributes.Append(TyLeKhongGiaoDich);
                        TyLeTheoDoTuoi.AppendChild(DoTuoi);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                DongLapTop.AppendChild(TyLeTheoDoTuoi);
                //THONG KE THEO TINH THANH

                XmlNode TyLeTheoTinhThanh = ResultAnalyseData.CreateElement("TY_LE_THEO_TINH_THANH");

                for (k = 0; k < DSTinhThanh.Count; ++k)
                {
                    SLCoGiaoDich = SLKhongGiaoDich = 0;
                    XmlNode TinhThanh = ResultAnalyseData.CreateElement("TINH_THANH");
                    XmlAttribute MaTinhThanh = ResultAnalyseData.CreateAttribute("ID");
                    XmlAttribute TenTinhThanh = ResultAnalyseData.CreateAttribute("TenTinhThanh");
                    XmlAttribute TyLeGiaoDich = ResultAnalyseData.CreateAttribute("TyLeGiaoDich");
                    XmlAttribute TyLeKhongGiaoDich = ResultAnalyseData.CreateAttribute("TyLeKhongGiaoDich");
                    MaTinhThanh.Value = DSTinhThanh[k].MaTinhThanh.ToString();
                    TenTinhThanh.Value = DSTinhThanh[k].TenTinhThanh;
                    int SLKhachHangTheoTinhThanh;
                    try
                    {
                        SLKhachHangTheoTinhThanh = myKhachHangDAO.SLKhachHangTheoTinhThanh(DSTinhThanh[k].MaTinhThanh);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    for (int j = 0; j < DSGiaoDichTheoDongLaptop.Count; ++j)
                    {

                        if (DSTinhThanh[k].MaTinhThanh == DSGiaoDichTheoDongLaptop[j].KHACHHANG.MaTinhThanh)
                            SLCoGiaoDich++;
                    }
                    //if (SLCoGiaoDich == 0)
                    //{
                    //    continue;
                    //}
                    try
                    {
                        TyLeGiaoDich.Value = (((float)SLCoGiaoDich / ((float)DSGiaoDichTheoDongLaptop.Count)) * 100).ToString();
                        SLKhongGiaoDich = SLKhachHangTheoTinhThanh - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = (((float)SLKhongGiaoDich / ((float)TongSoLuongGiaoDich - (float)DSGiaoDichTheoDongLaptop.Count)) * 100).ToString();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    try
                    {
                        TinhThanh.Attributes.Append(MaTinhThanh);
                        TinhThanh.Attributes.Append(TenTinhThanh);
                        TinhThanh.Attributes.Append(TyLeGiaoDich);
                        TinhThanh.Attributes.Append(TyLeKhongGiaoDich);
                        TyLeTheoTinhThanh.AppendChild(TinhThanh);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                DongLapTop.AppendChild(TyLeTheoTinhThanh);
                // THONG KE THEO GIOI TINH
                XmlNode TyLeTheoGioiTinh = ResultAnalyseData.CreateElement("TY_LE_THEO_GIOI_TINH");
                for (k = 0; k < 2; ++k)
                {
                    SLCoGiaoDich = SLKhongGiaoDich = 0;
                    XmlNode GioiTinh = ResultAnalyseData.CreateElement("GIOI_TINH");
                    XmlAttribute MaGioiTinh = ResultAnalyseData.CreateAttribute("ID");
                    XmlAttribute TenGioiTinh = ResultAnalyseData.CreateAttribute("TenGioiTinh");
                    XmlAttribute TyLeGiaoDich = ResultAnalyseData.CreateAttribute("TyLeGiaoDich");
                    XmlAttribute TyLeKhongGiaoDich = ResultAnalyseData.CreateAttribute("TyLeKhongGiaoDich");
                    if (k == 1)
                        TenGioiTinh.Value = "NAM";
                    else
                        TenGioiTinh.Value = "NU";
                    MaGioiTinh.Value = k.ToString();

                    int SLKhachHangTheoGioiTinh;
                    try
                    {
                        if (k == 0)
                            SLKhachHangTheoGioiTinh = myKhachHangDAO.SLKhachHangTheoGioiTinh(false);
                        else
                            SLKhachHangTheoGioiTinh = myKhachHangDAO.SLKhachHangTheoGioiTinh(true);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    for (int j = 0; j < DSGiaoDichTheoDongLaptop.Count; ++j)
                    {

                        if ((DSGiaoDichTheoDongLaptop[j].KHACHHANG.GioiTinhNam == true && k == 1) || (DSGiaoDichTheoDongLaptop[j].KHACHHANG.GioiTinhNam == false && k == 0))
                            SLCoGiaoDich++;
                    }
                    //if (SLCoGiaoDich == 0)
                    //{
                    //    continue;
                    //}
                    try
                    {
                        TyLeGiaoDich.Value = (((float)SLCoGiaoDich / ((float)DSGiaoDichTheoDongLaptop.Count)) * 100).ToString();
                        SLKhongGiaoDich = SLKhachHangTheoGioiTinh - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = (((float)SLKhongGiaoDich / ((float)TongSoLuongGiaoDich - (float)DSGiaoDichTheoDongLaptop.Count)) * 100).ToString();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    try
                    {
                        GioiTinh.Attributes.Append(MaGioiTinh);
                        GioiTinh.Attributes.Append(TenGioiTinh);
                        GioiTinh.Attributes.Append(TyLeGiaoDich);
                        GioiTinh.Attributes.Append(TyLeKhongGiaoDich);
                        TyLeTheoGioiTinh.AppendChild(GioiTinh);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                DongLapTop.AppendChild(TyLeTheoGioiTinh);
                NavasBayes.AppendChild(DongLapTop);
            }
            ResultAnalyseData.Save("ResultAnalyseData.xml");
        }
    }
}
