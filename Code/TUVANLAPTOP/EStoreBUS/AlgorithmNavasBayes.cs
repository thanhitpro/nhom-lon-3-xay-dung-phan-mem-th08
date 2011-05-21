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
        private XmlDocument xmlDocument;

        public XmlDocument XmlDocument
        {
            get { return xmlDocument; }
            set { xmlDocument = value; }
        }
        private int tongSoLuongGiaoDich;

        public int TongSoLuongGiaoDich
        {
            get { return tongSoLuongGiaoDich; }
            set { tongSoLuongGiaoDich = value; }
        }
        /// <summary>
        /// Load file XML
        /// </summary>
        /// <param name="FileName">
        /// Tên của file xml để Load
        /// </param>
        /// <returns>
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private void LoadFileXML(string FileName)
        {
            try
            {
                xmlDocument = new XmlDocument();
                xmlDocument.Load(FileName);
            }
            catch (System.IO.FileNotFoundException fileNotFoundEx)
            {
                throw fileNotFoundEx;
            }
            catch (System.Xml.XmlException xmlEx)
            {
                throw xmlEx;
            }
            catch (System.IO.FileLoadException fileLoadEx)
            {
                throw fileLoadEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Lưu file XML
        /// </summary>
        /// <returns>
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private void SaveFileXML(string FileName)
        {
            try
            {
                if(xmlDocument!=null)
                xmlDocument.Save(FileName);
                return;
            }
            catch (System.IO.FileNotFoundException fileNotFoundEx)
            {
                throw fileNotFoundEx;
            }
            catch (System.Xml.XmlException xmlEx)
            {
                throw xmlEx;
            }
            catch (OverflowException overflowEX)
            {
                throw overflowEX;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tạo một node với tên thẻ, ID, tỉ lệ giao dịch và tỉ lệ không giao dịch
        /// </summary>
        /// <returns>
        ///     Thành công: trả về Node mới được tạo
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private XmlNode TaoXMLNode(string TenThe,int ID,float TyLeGiaoDich, float TyLeKhongGiaoDich)
        {
            try
            {
                XmlNode Node = xmlDocument.CreateElement(TenThe);
                XmlAttribute xmlID = xmlDocument.CreateAttribute("ID");
                XmlAttribute xmlTyLeGiaoDich = xmlDocument.CreateAttribute("TyLeGiaoDich");
                XmlAttribute xmlTyLeKhongGiaoDich = xmlDocument.CreateAttribute("TyLeKhongGiaoDich");

                xmlID.Value = ID.ToString();
                xmlTyLeGiaoDich.Value = TyLeGiaoDich.ToString();
                xmlTyLeKhongGiaoDich.Value = TyLeKhongGiaoDich.ToString();

                Node.Attributes.Append(xmlID);
                Node.Attributes.Append(xmlTyLeGiaoDich);
                Node.Attributes.Append(xmlTyLeKhongGiaoDich);
                return Node;
            }
            catch (System.Xml.XmlException XmlEX)
            {
                throw XmlEX;
            }
            catch (OverflowException overflowEX)
            {
                throw overflowEX;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tạo một node có tên TY_LE_THEO_NGHE_NGHIEP
        /// Có 2 giá trị được ghi vào là tỷ lệ giao dịch của từng loại nghề nghiệp sử dụng với dòng máy được đưa vào
        /// Dựa trên danh sách các giao dịch được lưu
        /// </summary>
        /// <returns>
        ///     Thành công: trả về Node TY_LE_THEO_NGHE_NGHIEP
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private XmlNode TinhTyLeTheoNgheNghiep(CHITIETDONGLAPTOP LapTop, List<GIAODICH> DSGiaoDichTheoDongLaptop, List<NGHENGHIEP> DSNgheNghiep)
        {
            XmlNode TyLeTheoNgheNghiep;
            try
            {
                TyLeTheoNgheNghiep = xmlDocument.CreateElement("TY_LE_THEO_NGHE_NGHIEP");
            }
            catch (XmlException XmlEX)
            {
                throw XmlEX;
            }
            int SLCoGiaoDich, SLKhongGiaoDich, SoLuongKhachHangTheoNgheNghiep;
            float TyLeGiaoDich, TyLeKhongGiaoDich;
            for (int iNgheNghiep = 0; iNgheNghiep < DSNgheNghiep.Count; ++iNgheNghiep)
            {
                SLCoGiaoDich = 0;
                SLKhongGiaoDich = 0;            
                try
                {
                    SoLuongKhachHangTheoNgheNghiep = myKhachHangDAO.SLKhachHangTheoNgheNghiep(DSNgheNghiep[iNgheNghiep].MaNgheNghiep);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
             
                for (int iGiaoDich = 0; iGiaoDich < DSGiaoDichTheoDongLaptop.Count; ++iGiaoDich)
                {
                    if (DSNgheNghiep[iNgheNghiep].MaNgheNghiep == DSGiaoDichTheoDongLaptop[iGiaoDich].KHACHHANG.MaNgheNghiep)
                        ++SLCoGiaoDich;
                }
                
                try
                {
                    TyLeGiaoDich = ((float)SLCoGiaoDich / (float)DSGiaoDichTheoDongLaptop.Count) * 100;
                    SLKhongGiaoDich = SoLuongKhachHangTheoNgheNghiep - SLCoGiaoDich;
                    TyLeKhongGiaoDich = ((float)SLKhongGiaoDich / ((float)TongSoLuongGiaoDich - (float)DSGiaoDichTheoDongLaptop.Count)) * 100;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                try
                {
                    XmlNode xmlNgheNghiep = TaoXMLNode("NGHE_NGHIEP",DSNgheNghiep[iNgheNghiep].MaNgheNghiep, TyLeGiaoDich, TyLeKhongGiaoDich);
                    TyLeTheoNgheNghiep.AppendChild(xmlNgheNghiep);
                }
                catch (XmlException XmlEX)
                {
                    throw XmlEX;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return TyLeTheoNgheNghiep;
        }

        /// <summary>
        /// Tạo một node có tên TY_LE_THEO_MUC_DICH_SU_DUNG
        /// Có 2 giá trị được ghi vào là tỷ lệ giao dịch của từng loại mục đích sử dụng với dòng máy được đưa vào
        /// Dựa trên danh sách các giao dịch được lưu
        /// </summary>
        /// <returns>
        ///     Thành công: trả về Node TY_LE_THEO_MUC_DICH_SU_DUNG
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private XmlNode TinhTyLeTheoMucDichSuDung(CHITIETDONGLAPTOP LapTop, List<GIAODICH> DSGiaoDichTheoDongLaptop, List<MUCDICHSUDUNG> DSMucDichSuDung)
        {
            XmlNode TyLeTheoMucDichSuDung;
            try
            {
                TyLeTheoMucDichSuDung = xmlDocument.CreateElement("TY_LE_THEO_MUC_DICH_SU_DUNG");
            }
            catch (XmlException XmlEX)
            {
                throw XmlEX;
            }
            int SLCoGiaoDich, SLKhongGiaoDich, SLKhachHangTheoMucDich;
            float TyLeGiaoDich, TyLeKhongGiaoDich;
            for (int k = 0; k < DSMucDichSuDung.Count; ++k)
            {
                SLCoGiaoDich = SLKhongGiaoDich = 0;            
                try
                {
                    SLKhachHangTheoMucDich = myKhachHangDAO.SLKhachHangTheoMucDich(DSMucDichSuDung[k].MaMucDichSuDung);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //SLCoGiaoDich = myGiaoDichDAO.DemGiaoDichTheoLaptopVaMucDich(LapTop.MaDongLapTop, DSMucDichSuDung[k].MaMucDichSuDung);
                for (int j = 0; j < DSGiaoDichTheoDongLaptop.Count; ++j)
                {
                    if (DSMucDichSuDung[k].MaMucDichSuDung == DSGiaoDichTheoDongLaptop[j].KHACHHANG.MaMucDichSuDung)
                        ++SLCoGiaoDich;
                }

                try
                {
                    TyLeGiaoDich = ((float)SLCoGiaoDich / (float)DSGiaoDichTheoDongLaptop.Count) * 100;
                    SLKhongGiaoDich = SLKhachHangTheoMucDich - SLCoGiaoDich;
                    TyLeKhongGiaoDich = ((float)SLKhongGiaoDich / ((float)TongSoLuongGiaoDich - (float)DSGiaoDichTheoDongLaptop.Count)) * 100;
                }

                catch (Exception ex)
                {
                    throw ex;
                }
                try
                {

                    XmlNode xmlMucDich = TaoXMLNode("MUC_DICH", DSMucDichSuDung[k].MaMucDichSuDung, TyLeGiaoDich, TyLeKhongGiaoDich);
                    TyLeTheoMucDichSuDung.AppendChild(xmlMucDich);
                }
                catch (XmlException XmlEX)
                {
                    throw XmlEX;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return TyLeTheoMucDichSuDung;
        }
        
        /// <summary>
        /// Tạo một node có tên TY_LE_THEO_DO_TUOI
        /// Có 2 giá trị được ghi vào là tỷ lệ giao dịch của từng loại độ tuổi với dòng máy được đưa vào
        /// Dựa trên danh sách các giao dịch được lưu
        /// </summary>
        /// <returns>
        ///     Thành công: trả về Node TY_LE_THEO_DO_TUOI
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private XmlNode TinhTyLeTheoDoTuoi(CHITIETDONGLAPTOP LapTop, List<GIAODICH> DSGiaoDichTheoDongLaptop, List<DOTUOI> DSDoTuoi)
        {
            XmlNode TyLeTheoDoTuoi;
            try
            {
                TyLeTheoDoTuoi = xmlDocument.CreateElement("TY_LE_THEO_DO_TUOI");
            }
            catch (XmlException XmlEX)
            {
                throw XmlEX;
            }
            int SLCoGiaoDich, SLKhongGiaoDich, SLKhachHangTheoDoTuoi;
            float TyLeGiaoDich, TyLeKhongGiaoDich;
            for (int k = 0; k < DSDoTuoi.Count; ++k)
            {
                SLCoGiaoDich = SLKhongGiaoDich = 0;
                try
                {
                    SLKhachHangTheoDoTuoi = myKhachHangDAO.SLKhachHangTheoDoTuoi(DSDoTuoi[k].MaDoTuoi);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
               // SLCoGiaoDich = myGiaoDichDAO.DemGiaoDichTheoLaptopVaDoTuoi(LapTop.MaDongLapTop, DSDoTuoi[k].MaDoTuoi);
                for (int j = 0; j < DSGiaoDichTheoDongLaptop.Count; ++j)
                {
                    if (DSDoTuoi[k].MaDoTuoi == DSGiaoDichTheoDongLaptop[j].KHACHHANG.MaDoTuoi)
                        ++SLCoGiaoDich;
                }

                try
                {
                    TyLeGiaoDich = ((float)SLCoGiaoDich / (float)DSGiaoDichTheoDongLaptop.Count) * 100;
                    SLKhongGiaoDich = SLKhachHangTheoDoTuoi - SLCoGiaoDich;
                    TyLeKhongGiaoDich = ((float)SLKhongGiaoDich / ((float)TongSoLuongGiaoDich - (float)DSGiaoDichTheoDongLaptop.Count)) * 100;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                try
                {
                    XmlNode xmlDoTuoi = TaoXMLNode("DO_TUOI", DSDoTuoi[k].MaDoTuoi, TyLeGiaoDich, TyLeKhongGiaoDich);
                    TyLeTheoDoTuoi.AppendChild(xmlDoTuoi);
                }
                catch (XmlException XmlEX)
                {
                    throw XmlEX;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return TyLeTheoDoTuoi;
        }
       
        /// <summary>
        /// Tạo một node có tên TY_LE_THEO_TINH_THANH
        /// Có 2 giá trị được ghi vào là tỷ lệ giao dịch của từng loại tỉnh thành với dòng máy được đưa vào
        /// Dựa trên danh sách các giao dịch được lưu
        /// </summary>
        /// <returns>
        ///     Thành công: trả về Node TY_LE_THEO_TINH_THANH
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private XmlNode TinhTyLeTheoTinhThanh(CHITIETDONGLAPTOP LapTop, List<GIAODICH> DSGiaoDichTheoDongLaptop, List<TINHTHANH> DSTinhThanh)
        {
            XmlNode TyLeTheoTinhThanh;
            try
            {
                TyLeTheoTinhThanh = xmlDocument.CreateElement("TY_LE_THEO_TINH_THANH");
            }
            catch (XmlException XmlEX)
            {
                throw XmlEX;
            }
            int SLCoGiaoDich, SLKhongGiaoDich, SLKhachHangTheoTinhThanh;
            float TyLeGiaoDich, TyLeKhongGiaoDich;
            for (int k = 0; k < DSTinhThanh.Count; ++k)
            {
                SLCoGiaoDich = SLKhongGiaoDich = 0;
                
                try
                {
                    SLKhachHangTheoTinhThanh = myKhachHangDAO.SLKhachHangTheoTinhThanh(DSTinhThanh[k].MaTinhThanh);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
              //  SLCoGiaoDich = myGiaoDichDAO.DemGiaoDichTheoLaptopVaTinhThanh(LapTop.MaDongLapTop, DSTinhThanh[k].MaTinhThanh);
                for (int j = 0; j < DSGiaoDichTheoDongLaptop.Count; ++j)
                {
                   if (DSTinhThanh[k].MaTinhThanh == DSGiaoDichTheoDongLaptop[j].KHACHHANG.MaTinhThanh)
                        ++SLCoGiaoDich;
                }

                try
                {
                    TyLeGiaoDich = ((float)SLCoGiaoDich / (float)DSGiaoDichTheoDongLaptop.Count) * 100;
                    SLKhongGiaoDich = SLKhachHangTheoTinhThanh - SLCoGiaoDich;
                    TyLeKhongGiaoDich = ((float)SLKhongGiaoDich / ((float)TongSoLuongGiaoDich - (float)DSGiaoDichTheoDongLaptop.Count)) * 100;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                try
                {
                    XmlNode xmlTinhThanh = TaoXMLNode("TINH_THANH", DSTinhThanh[k].MaTinhThanh, TyLeGiaoDich, TyLeKhongGiaoDich);
                    TyLeTheoTinhThanh.AppendChild(xmlTinhThanh);
                }
                catch (XmlException XmlEX)
                {
                    throw XmlEX;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return TyLeTheoTinhThanh;
        }

        /// <summary>
        /// Tạo một node có tên TY_LE_THEO_GIOI_TINH
        /// Có 2 giá trị được ghi vào là tỷ lệ giao dịch của từng loại giới tính với dòng máy được đưa vào
        /// Dựa trên danh sách các giao dịch được lưu
        /// </summary>
        /// <returns>
        ///     Thành công: trả về Node TY_LE_THEO_GIOI_TINH
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private XmlNode TinhTyLeTheoGioiTinh(CHITIETDONGLAPTOP LapTop, List<GIAODICH> DSGiaoDichTheoDongLaptop)
        {
            XmlNode TyLeTheoGioiTinh;
            try
            {
                TyLeTheoGioiTinh = xmlDocument.CreateElement("TY_LE_THEO_GIOI_TINH");
            }
            catch (XmlException XmlEX)
            {
                throw XmlEX;
            }
            int SLCoGiaoDich, SLKhongGiaoDich, SLKhachHangTheoGioiTinh;
            float TyLeGiaoDich, TyLeKhongGiaoDich;
            for (int k = 0; k < 2; ++k)
            {
                SLCoGiaoDich = SLKhongGiaoDich = 0;
               
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
                        ++SLCoGiaoDich;
                }

                try
                {
                    TyLeGiaoDich = ((float)SLCoGiaoDich / ((float)DSGiaoDichTheoDongLaptop.Count)) * 100;
                    SLKhongGiaoDich = SLKhachHangTheoGioiTinh - SLCoGiaoDich;
                    TyLeKhongGiaoDich = ((float)SLKhongGiaoDich / ((float)TongSoLuongGiaoDich - (float)DSGiaoDichTheoDongLaptop.Count)) * 100;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                try
                {
                    XmlNode xmlGioiTinh = TaoXMLNode("GIOI_TINH", k, TyLeGiaoDich, TyLeKhongGiaoDich);
                    TyLeTheoGioiTinh.AppendChild(xmlGioiTinh);
                }
                catch (XmlException XmlEX)
                {
                    throw XmlEX;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return TyLeTheoGioiTinh;
        }

        /// <summary>
        /// Thực thi thuật toán bayes. Dữ liệu được lấy trong bảng giao dịch trong csdl
        /// Thực hiện tính xác xuất từng yếu tố ảnh hưởng tới quyết định chọn dòng máy của khách hàng với mỗi dòng máy
        /// </summary>
        /// <returns>
        ///     Thành công: trả về file xml
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public void AnalyseData()
        {
           
            LoadFileXML("ResultAnalyseData.xml");

            XmlNode NavasBayes = xmlDocument.DocumentElement;
            NavasBayes.RemoveAll();

            List<NGHENGHIEP> DSNgheNgiep;
            List<MUCDICHSUDUNG> DSMucDichSuDung;
            List<DOTUOI> DSDoTuoi;
            List<TINHTHANH> DSTinhThanh;           
            List<CHITIETDONGLAPTOP> DSDongLaptop;
            try
            {
                DSNgheNgiep = myNgheNghiepDAO.LayNgheNghiep();
                DSMucDichSuDung = myMucDichSuDungDAO.LayMucDichSuDung();
                DSDoTuoi = myDoTuoiDAO.LayDoTuoi();
                DSTinhThanh = myTinhThanhDAO.LayTinhThanh();
                TongSoLuongGiaoDich = myGiaoDichDAO.LaySoLuongGiaoDich();
                DSDongLaptop = myChiTietDongLaptopDAO.LayTatCaChiTietDongLaptop();
            }
            catch (OverflowException OverflowEX)
            {
                throw OverflowEX;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<GIAODICH> DSGiaoDichTheoDongLaptop;
          
            for (int i = 0; i < DSDongLaptop.Count; ++i)
            {
                try
                {
                    DSGiaoDichTheoDongLaptop = myGiaoDichDAO.LayDanhSachGiaoDichTheoMaDongLapTop(DSDongLaptop[i].MaDongLapTop);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
               // SoLuongGiaoDichTheoDongLaptop = myGiaoDichDAO.DemGiaoDichTheoLaptop(DSDongLaptop[i].MaDongLapTop);
                // create thẻ xml
                XmlNode DongLapTop = xmlDocument.CreateElement("DONGLAPTOP");
                XmlAttribute MaDongLapTop = xmlDocument.CreateAttribute("ID");
                XmlAttribute TenDongLapTop = xmlDocument.CreateAttribute("TenDongLaptop");
                XmlAttribute SoLuongDaBan = xmlDocument.CreateAttribute("SoLuongDaBan");
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
           
                // thong ke theo nghe nghiep
                XmlNode xmlTyLeTheoNgheNghiep = TinhTyLeTheoNgheNghiep(DSDongLaptop[i], DSGiaoDichTheoDongLaptop, DSNgheNgiep);               
                DongLapTop.AppendChild(xmlTyLeTheoNgheNghiep);
             
                // thong ke theo muc dich su dung
                XmlNode xmlTyLeTheoMucDichSuDung = TinhTyLeTheoMucDichSuDung(DSDongLaptop[i], DSGiaoDichTheoDongLaptop, DSMucDichSuDung);
                DongLapTop.AppendChild(xmlTyLeTheoMucDichSuDung);

                // thong ke theo do tuoi
                XmlNode xmlTyLeTheoDoTuoi = TinhTyLeTheoDoTuoi(DSDongLaptop[i], DSGiaoDichTheoDongLaptop, DSDoTuoi);
                DongLapTop.AppendChild(xmlTyLeTheoDoTuoi);

                // thong ke theo tinh thanh
                XmlNode xmlTyLeTheoTinhThanh = TinhTyLeTheoTinhThanh(DSDongLaptop[i], DSGiaoDichTheoDongLaptop, DSTinhThanh);
                DongLapTop.AppendChild(xmlTyLeTheoTinhThanh);

                // thong ke theo gioi tinh
                XmlNode xmlTyLeTheoGioiTinh = TinhTyLeTheoGioiTinh(DSDongLaptop[i], DSGiaoDichTheoDongLaptop);
                DongLapTop.AppendChild(xmlTyLeTheoGioiTinh);

                NavasBayes.AppendChild(DongLapTop);
            }
            SaveFileXML("ResultAnalyseData.xml");
        }
        
    }
}
