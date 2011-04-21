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
            List<GIAODICH> DSTatCaGiaoDich;
            List<NHASANXUAT> DSNhaSanXuat;
            try
            {
                DSNgheNgiep = myNgheNghiepDAO.LayNgheNghiep();
                DSMucDichSuDung = myMucDichSuDungDAO.LayMucDichSuDung();
                DSDoTuoi = myDoTuoiDAO.LayDoTuoi();
                DSTinhThanh = myTinhThanhDAO.LayTinhThanh();
                DSTatCaGiaoDich = myGiaoDichDAO.LayGiaoDich();
                DSNhaSanXuat = myNhaSanXuatDAO.LayNhaSanXuat();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            for (int i = 0; i < DSNhaSanXuat.Count; ++i)
            {
                List<GIAODICH> DSGiaoDichTheoNhaSanXuat;
                try
                {
                    DSGiaoDichTheoNhaSanXuat = myGiaoDichDAO.LayDanhSachGiaoDichTheoNhaSanXuat(DSNhaSanXuat[i].MaNhaSanXuat);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                if (DSGiaoDichTheoNhaSanXuat.Count == 0)
                {
                    continue;
                }
                // create thẻ xml
                XmlNode NhaSanXuat = ResultAnalyseData.CreateElement("NHASANXUAT");
                XmlAttribute MaNhaSanXuat = ResultAnalyseData.CreateAttribute("ID");
                XmlAttribute TenNhaSanXuat = ResultAnalyseData.CreateAttribute("TenNhaSanXuat");
                XmlAttribute SoLuongDaBan = ResultAnalyseData.CreateAttribute("SoLuongDaBan");
                MaNhaSanXuat.Value = DSNhaSanXuat[i].MaNhaSanXuat.ToString();
                TenNhaSanXuat.Value = DSNhaSanXuat[i].TenNhaSanXuat;
                SoLuongDaBan.Value = DSGiaoDichTheoNhaSanXuat.Count.ToString();
                try
                {
                    NhaSanXuat.Attributes.Append(MaNhaSanXuat);
                    NhaSanXuat.Attributes.Append(TenNhaSanXuat);
                    NhaSanXuat.Attributes.Append(SoLuongDaBan);
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
                    for (int j = 0; j < DSGiaoDichTheoNhaSanXuat.Count; ++j)
                    {
                   
                        if (DSNgheNgiep[k].MaNgheNghiep== DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.MaNgheNghiep)
                            SLCoGiaoDich++;
                    }
                    if (SLCoGiaoDich == 0)
                    {
                        continue;
                    }
                    double a;
                    try
                    {
                        a = (float)((float)SLCoGiaoDich / (float)DSGiaoDichTheoNhaSanXuat.Count) * 100;
                        TyLeGiaoDich.Value = a.ToString();
                        SLKhongGiaoDich = SoLuongKhachHangTheoNgheNghiep - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = (((float)SLKhongGiaoDich / ((float)DSTatCaGiaoDich.Count - (float)DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
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
               NhaSanXuat.AppendChild(TyLeTheoNgheNghiep);

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
                    for (int j = 0; j < DSGiaoDichTheoNhaSanXuat.Count; ++j)
                    {
                        if (DSMucDichSuDung[k].MaMucDichSuDung == DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.MaMucDichSuDung)
                            SLCoGiaoDich++;
                    }
                    if (SLCoGiaoDich == 0)
                    {
                        continue;
                    }
                    try
                    {
                        TyLeGiaoDich.Value = ((float)((float)SLCoGiaoDich / (float)DSGiaoDichTheoNhaSanXuat.Count) * 100).ToString();
                        SLKhongGiaoDich = SLKhachHangTheoMucDich - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = (((float)SLKhongGiaoDich / ((float)DSTatCaGiaoDich.Count - (float)DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
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
                NhaSanXuat.AppendChild(TyLeTheoMucDichSuDung);
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

                    for (int j = 0; j < DSGiaoDichTheoNhaSanXuat.Count; ++j)
                    {
                       
                        if (DSDoTuoi[k].MaDoTuoi == DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.MaDoTuoi)
                            SLCoGiaoDich++;
                    }
                    if (SLCoGiaoDich == 0)
                    {
                        continue;
                    }
                    try
                    {
                        TyLeGiaoDich.Value = (((float)SLCoGiaoDich / ((float)DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
                        SLKhongGiaoDich = SLKhachHangTheoDoTuoi - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = (((float)SLKhongGiaoDich / ((float)DSTatCaGiaoDich.Count - (float)DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
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
                NhaSanXuat.AppendChild(TyLeTheoDoTuoi);
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
                    catch(Exception ex)
                    {
                        throw ex;
                    }

                    for (int j = 0; j < DSGiaoDichTheoNhaSanXuat.Count; ++j)
                    {
                      
                        if (DSTinhThanh[k].MaTinhThanh == DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.MaTinhThanh)
                            SLCoGiaoDich++;
                    }
                    if (SLCoGiaoDich == 0)
                    {
                        continue;
                    }
                    try
                    {
                        TyLeGiaoDich.Value = (((float)SLCoGiaoDich / ((float)DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
                        SLKhongGiaoDich = SLKhachHangTheoTinhThanh - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = (((float)SLKhongGiaoDich / ((float)DSTatCaGiaoDich.Count - (float)DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
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
                NhaSanXuat.AppendChild(TyLeTheoTinhThanh);
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
                    if(k==1)                    
                    TenGioiTinh.Value ="NAM";
                    else
                        TenGioiTinh.Value="NU";
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
                    for (int j = 0; j < DSGiaoDichTheoNhaSanXuat.Count; ++j)
                    {
                       
                        if ((DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.GioiTinhNam==true && k == 1)||(DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.GioiTinhNam==false && k == 0))
                            SLCoGiaoDich++;
                    }
                    if (SLCoGiaoDich == 0)
                    {
                        continue;
                    }
                    try
                    {
                        TyLeGiaoDich.Value = (((float)SLCoGiaoDich / ((float)DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
                        SLKhongGiaoDich = SLKhachHangTheoGioiTinh - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = (((float)SLKhongGiaoDich / ((float)DSTatCaGiaoDich.Count - (float)DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
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
                NhaSanXuat.AppendChild(TyLeTheoGioiTinh);
                NavasBayes.AppendChild(NhaSanXuat);
            }
            ResultAnalyseData.Save("ResultAnalyseData.xml");
        }
    }
}
