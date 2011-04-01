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
            ResultAnalyseData.Load("ResultAnalyseData.xml");
            XmlNode NavasBayes = ResultAnalyseData.DocumentElement;
            NavasBayes.RemoveAll();
            
            List<NGHENGHIEP> DSNgheNgiep = myNgheNghiepDAO.LayNgheNghiep();
            List<MUCDICHSUDUNG> DSMucDichSuDung = myMucDichSuDungDAO.LayMucDichSuDung();
            List<DOTUOI> DSDoTuoi = myDoTuoiDAO.LayDoTuoi();
            List<TINHTHANH> DSTinhThanh = myTinhThanhDAO.LayTinhThanh();
            List<GIAODICH> DSTatCaGiaoDich = myGiaoDichDAO.LayGiaoDich();

            //****
            List<NHASANXUAT> DSNhaSanXuat = myNhaSanXuatDAO.LayNhaSanXuat();
            for (int i = 0; i < DSNhaSanXuat.Count; ++i)
            {
                List<GIAODICH> DSGiaoDichTheoNhaSanXuat = myGiaoDichDAO.LayDanhSachGiaoDichTheoNhaSanXuat(DSNhaSanXuat[i].MaNhaSanXuat);
                // create thẻ xml
                XmlNode NhaSanXuat = ResultAnalyseData.CreateElement("NHASANXUAT");
                XmlAttribute MaNhaSanXuat = ResultAnalyseData.CreateAttribute("ID");
                XmlAttribute TenNhaSanXuat = ResultAnalyseData.CreateAttribute("TenNhaSanXuat");
                XmlAttribute SoLuongDaBan = ResultAnalyseData.CreateAttribute("SoLuongDaBan");
                MaNhaSanXuat.Value = DSNhaSanXuat[i].MaNhaSanXuat.ToString();
                TenNhaSanXuat.Value = DSNhaSanXuat[i].TenNhaSanXuat;
                SoLuongDaBan.Value = DSGiaoDichTheoNhaSanXuat.Count.ToString();

                NhaSanXuat.Attributes.Append(MaNhaSanXuat);
                NhaSanXuat.Attributes.Append(TenNhaSanXuat);
                NhaSanXuat.Attributes.Append(SoLuongDaBan);
              
                                           
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
                    int SoLuongKhachHangTheoNgheNghiep = myKhachHangDAO.SLKhachHangTheoNgheNghiep(DSNgheNgiep[k].MaNgheNghiep);
                    for (int j = 0; j < DSGiaoDichTheoNhaSanXuat.Count; ++j)
                    {
                   
                        if (DSNgheNgiep[k].MaNgheNghiep== DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.MaNgheNghiep)
                            SLCoGiaoDich++;
                    }

                    TyLeGiaoDich.Value = ((SLCoGiaoDich / DSGiaoDichTheoNhaSanXuat.Count) * 100).ToString();
                    SLKhongGiaoDich = SoLuongKhachHangTheoNgheNghiep - SLCoGiaoDich;
                    TyLeKhongGiaoDich.Value = ((SLKhongGiaoDich / (DSTatCaGiaoDich.Count - DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
                    NgheNgiep.Attributes.Append(MaNgheNghiep);
                    NgheNgiep.Attributes.Append(TenNgheNghiep);
                    NgheNgiep.Attributes.Append(TyLeGiaoDich);
                    NgheNgiep.Attributes.Append(TyLeKhongGiaoDich);
                    TyLeTheoNgheNghiep.AppendChild(NgheNgiep);
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

                    int SLKhachHangTheoMucDich = myKhachHangDAO.SLKhachHangTheoMucDich(DSMucDichSuDung[k].MaMucDichSuDung);
                    for (int j = 0; j < DSGiaoDichTheoNhaSanXuat.Count; ++j)
                    {
                        if (DSMucDichSuDung[k].MaMucDichSuDung == DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.MaMucDichSuDung)
                            SLCoGiaoDich++;
                    }

                    TyLeGiaoDich.Value = ((SLCoGiaoDich / DSGiaoDichTheoNhaSanXuat.Count) * 100).ToString();
                    SLKhongGiaoDich = SLKhachHangTheoMucDich - SLCoGiaoDich;
                    TyLeKhongGiaoDich.Value = ((SLKhongGiaoDich / (DSTatCaGiaoDich.Count - DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
                    MucDich.Attributes.Append(MaMucDich);
                    MucDich.Attributes.Append(TenMucDich);
                    MucDich.Attributes.Append(TyLeGiaoDich);
                    MucDich.Attributes.Append(TyLeKhongGiaoDich);
                    TyLeTheoMucDichSuDung.AppendChild(MucDich);
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

                    int SLKhachHangTheoDoTuoi = myKhachHangDAO.SLKhachHangTheoDoTuoi(DSDoTuoi[k].MaDoTuoi);

                    for (int j = 0; j < DSGiaoDichTheoNhaSanXuat.Count; ++j)
                    {
                       
                        if (DSDoTuoi[k].MaDoTuoi == DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.MaDoTuoi)
                            SLCoGiaoDich++;
                    }

                    TyLeGiaoDich.Value = ((SLCoGiaoDich / DSGiaoDichTheoNhaSanXuat.Count) * 100).ToString();
                    SLKhongGiaoDich = SLKhachHangTheoDoTuoi - SLCoGiaoDich;
                    TyLeKhongGiaoDich.Value = ((SLKhongGiaoDich / (DSTatCaGiaoDich.Count - DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
                    DoTuoi.Attributes.Append(MaDoTuoi);
                    DoTuoi.Attributes.Append(TenDoTuoi);
                    DoTuoi.Attributes.Append(TyLeGiaoDich);
                    DoTuoi.Attributes.Append(TyLeKhongGiaoDich);
                    TyLeTheoDoTuoi.AppendChild(DoTuoi);
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

                    int SLKhachHangTheoTinhThanh = myKhachHangDAO.SLKhachHangTheoTinhThanh(DSTinhThanh[k].MaTinhThanh);

                    for (int j = 0; j < DSGiaoDichTheoNhaSanXuat.Count; ++j)
                    {
                      
                        if (DSTinhThanh[k].MaTinhThanh == DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.MaTinhThanh)
                            SLCoGiaoDich++;
                    }

                    TyLeGiaoDich.Value = ((SLCoGiaoDich / DSGiaoDichTheoNhaSanXuat.Count) * 100).ToString();
                    SLKhongGiaoDich = SLKhachHangTheoTinhThanh - SLCoGiaoDich;
                    TyLeKhongGiaoDich.Value = ((SLKhongGiaoDich / (DSTatCaGiaoDich.Count - DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
                    TinhThanh.Attributes.Append(MaTinhThanh);
                    TinhThanh.Attributes.Append(TenTinhThanh);
                    TinhThanh.Attributes.Append(TyLeGiaoDich);
                    TinhThanh.Attributes.Append(TyLeKhongGiaoDich);
                    TyLeTheoTinhThanh.AppendChild(TinhThanh);
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
                    if(k==0)
                    SLKhachHangTheoGioiTinh = myKhachHangDAO.SLKhachHangTheoGioiTinh(false);
                    else
                    SLKhachHangTheoGioiTinh = myKhachHangDAO.SLKhachHangTheoGioiTinh(true);

                    for (int j = 0; j < DSGiaoDichTheoNhaSanXuat.Count; ++j)
                    {
                       
                        if ((DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.GioiTinhNam==true && k == 1)||(DSGiaoDichTheoNhaSanXuat[j].KHACHHANG.GioiTinhNam==false && k == 0))
                            SLCoGiaoDich++;
                    }

                    TyLeGiaoDich.Value = ((SLCoGiaoDich / DSGiaoDichTheoNhaSanXuat.Count) * 100).ToString();
                    SLKhongGiaoDich = SLKhachHangTheoGioiTinh - SLCoGiaoDich;
                    TyLeKhongGiaoDich.Value = ((SLKhongGiaoDich / (DSTatCaGiaoDich.Count - DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
                    GioiTinh.Attributes.Append(MaGioiTinh);
                    GioiTinh.Attributes.Append(TenGioiTinh);
                    GioiTinh.Attributes.Append(TyLeGiaoDich);
                    GioiTinh.Attributes.Append(TyLeKhongGiaoDich);
                    TyLeTheoGioiTinh.AppendChild(GioiTinh);
                }
                NhaSanXuat.AppendChild(TyLeTheoGioiTinh);
                NavasBayes.AppendChild(NhaSanXuat);
            }
            ResultAnalyseData.Save("ResultAnalyseData.xml");
        }


      /*  public void AnalyseData()
        {
            XmlDocument ResultAnalyseData = new XmlDocument();
            ResultAnalyseData.Load("ResultAnalyseData.xml");
            XmlNode NavasBayes = ResultAnalyseData.DocumentElement;
            NavasBayes.RemoveAll();
            //khai baos bien 
            myNhaSanXuatDAO _MyNhaSanXuat= new myNhaSanXuatDAO ();
            myChiTietDongLaptopDAO _ChiTietDongLaptop=new myChiTietDongLaptopDAO ();
            myGiaoDichDAO _GiaoDich=new myGiaoDichDAO ();
            myKhachHangDAO _KhachHang=new myKhachHangDAO ();
            myNgheNghiepDAO _NgheNghiep = new myNgheNghiepDAO();

            List<myNgheNghiepDTO> DSNgheNgiep = _NgheNghiep.LayNgheNghiep();
            List<myGiaoDichDTO> DSTatCaGiaoDich = _GiaoDich.LayGiaoDich();

            //****
            List<myNhaSanXuatDTO> DSNhaSanXuat = _MyNhaSanXuat.LayNhaSanXuat();
            for (int i = 0; i < DSNhaSanXuat.Count; ++i)
            {
                // create thẻ xml " NHASANXUAT" có thuộc tính tên "TenNhaSanXuat"
                XmlNode NhaSanXuat = ResultAnalyseData.CreateElement("NHASANXUAT");
                XmlAttribute TenNhaSanXuat = ResultAnalyseData.CreateAttribute("TenNhaSanXuat");
                TenNhaSanXuat.Value = DSNhaSanXuat[i].STenNhaSanXuat;
                XmlAttribute SoLuongDaBan = ResultAnalyseData.CreateAttribute("SoLuongDaBan");

                
                NhaSanXuat.Attributes.Append(TenNhaSanXuat);

                NavasBayes.AppendChild(NhaSanXuat);

                XmlNode TyLeTheoNgheNghiep = ResultAnalyseData.CreateElement("TY_LE_THEO_NGHE_NGHIEP");
                NhaSanXuat.AppendChild(TyLeTheoNgheNghiep);
       

                //*****
               // List<myChiTietDongLaptopDTO> DSDongLaptop = _ChiTietDongLaptop.LayChiTietDongLaptop(DSNhaSanXuat[i].iMaNhaSanXuat);
                List<myGiaoDichDTO> DSGiaoDichTheoNhaSanXuat = _GiaoDich.LayGiaoDichTheoNhaSanXuat(DSNhaSanXuat[i].iMaNhaSanXuat);
               
                SoLuongDaBan.Value = DSGiaoDichTheoNhaSanXuat.Count;
                for(int j=0;j<DSGiaoDichTheoNhaSanXuat.Count;++j)
                {
                    List<myKhachHangDTO> DSKhachHangDaGiaoDich = _KhachHang.LayKhachHang(DSGiaoDichTheoNhaSanXuat[j].KhachHang.IMaKhachHang);                 
                    int k=0;
                    int q=0;
                    int SLCoGiaoDich = 0;
                    int SLKhongGiaoDich = 0;
                    for (k = 0; k < DSNgheNgiep.Count; ++k)
                    {
                        XmlNode NgheNgiep = ResultAnalyseData.CreateElement("NGHE_NGHIEP");
                        XmlAttribute TenNgheNghiep = ResultAnalyseData.CreateAttribute("TenNgheNghiep");
                        XmlAttribute TyLeGiaoDich = ResultAnalyseData.CreateAttribute("TyLeGiaoDich");
                        XmlAttribute TyLeKhongGiaoDich = ResultAnalyseData.CreateAttribute("TyLeKhongGiaoDich");
                        TenNgheNghiep.Value = DSNgheNgiep[k].STenNgheNghiep;
                        //****************
                        int SoLuongKhachHangTheoNgheNghiep = _KhachHang.SLKhachHangTheoNgheNghiep(DSNgheNgiep[k].IMaNgheNghiep);
                        for (q = 0; q < DSKhachHangDaGiaoDich.Count; ++q)
                            if (DSNgheNgiep[k].IMaNgheNghiep == DSKhachHangDaGiaoDich[q].NgheNghiep.IMaNgheNghiep)
                             SLCoGiaoDich++;
                       
                        TyLeGiaoDich.Value = ((SLCoGiaoDich / DSGiaoDichTheoNhaSanXuat.Count) * 100).ToString();
                        SLKhongGiaoDich = SoLuongKhachHangTheoNgheNghiep - SLCoGiaoDich;
                        TyLeKhongGiaoDich.Value = ((SLKhongGiaoDich / (DSTatCaGiaoDich.Count - DSGiaoDichTheoNhaSanXuat.Count)) * 100).ToString();
                        NgheNgiep.Attributes.Append(TenNgheNghiep);
                        NgheNgiep.Attributes.Append(TyLeGiaoDich);
                        NgheNgiep.Attributes.Append(TyLeKhongGiaoDich);
                        TyLeTheoNgheNghiep.AppendChild(NgheNgiep);
                    }
              

                }

            }
        }*/
    }
}
