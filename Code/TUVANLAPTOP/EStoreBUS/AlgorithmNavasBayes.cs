using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    /// <summary>
    /// class chính cho thuật toán NavasBayes
    /// class này làm nhiệm vụ tổng hợp dữ liệu từ CSDL để tính toán thông kê ra
    /// tỷ lệ giao dịch và không giao dịch của từng Laptop theo mỗi yếu tố từ khách hàng bao gồm: 
    /// theo nghề nghiệp, mục đích sử dụng, tỉnh thành,độ tuổi,giới tính
    /// kết quả thu được là file xml
    /// </summary>
    public class AlgorithmNavasBayes
    {
        /// <summary>
        /// xmlDocument của file xml
        /// </summary>
        private XmlDocument xmlDocument;

        /// <summary>
        /// xmlDocument của file xml
        /// </summary>
        public XmlDocument Xmldocument
        {
            get { return this.xmlDocument; }
            set { this.xmlDocument = value; }
        }

        /// <summary>
        /// tổng số lượng giao dịch trong csdl
        /// </summary>
        private int tongSoLuongGiaoDich;

        /// <summary>
        /// tổng số lượng giao dịch trong csdl
        /// </summary>
        public int TongSoLuongGiaoDich
        {
            get { return this.tongSoLuongGiaoDich; }
            set { this.tongSoLuongGiaoDich = value; }
        }

        /// <summary>
        /// Load file XML
        /// </summary>
        /// <param name="fileName">
        /// Tên của file xml để Load
        /// </param>
        /// <returns>
        ///     thành công : trả về true và người lại trả về false
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public bool LoadFileXML(string fileName)
        {
            try
            {
                this.xmlDocument = new XmlDocument();
                this.xmlDocument.Load(fileName);
                return true;
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
        /// <param name="fileName"> tên của file xml</param>
        /// <returns>
        ///     thành công : trả về true và ngược lại trả về false
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public bool SaveFileXML(string fileName)
        {
            try
            {
                if (this.xmlDocument != null)
                {
                    this.xmlDocument.Save(fileName);
                    return true;
                }

                return false;
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
        /// <param name="tenThe">Tên Thẻ của element</param>
        /// <param name="id"> ID của Node .cũng là ID của từng đối tượng</param>        
        /// <param name="tyLeGiaoDich">tỷ lệ giao dịch</param>
        /// <param name="tyLeKhongGiaoDich">tỷ lệ không giao dịch</param>
        /// <returns>
        ///     Thành công: trả về Node mới được tạo
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public XmlNode TaoXMLNode(string tenThe, int id, float tyLeGiaoDich, float tyLeKhongGiaoDich)
        {
            try
            {
                XmlNode node = this.xmlDocument.CreateElement(tenThe);
                XmlAttribute xmlID = this.xmlDocument.CreateAttribute("ID");
                XmlAttribute xmlTyLeGiaoDich = this.xmlDocument.CreateAttribute("TyLeGiaoDich");
                XmlAttribute xmlTyLeKhongGiaoDich = this.xmlDocument.CreateAttribute("TyLeKhongGiaoDich");

                xmlID.Value = id.ToString();
                xmlTyLeGiaoDich.Value = tyLeGiaoDich.ToString();
                xmlTyLeKhongGiaoDich.Value = tyLeKhongGiaoDich.ToString();

                node.Attributes.Append(xmlID);
                node.Attributes.Append(xmlTyLeGiaoDich);
                node.Attributes.Append(xmlTyLeKhongGiaoDich);
                return node;
            }
            catch (System.Xml.XmlException xmlEX)
            {
                throw xmlEX;
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
        /// <param name="lapTop"> Laptop cần thống kê</param>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <param name="danhSachNgheNghiep"> danh sách nghề nghiệp có trong CSDL</param>
        /// <returns>
        ///     Thành công: trả về Node TY_LE_THEO_NGHE_NGHIEP
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public XmlNode TinhTyLeTheoNgheNghiep(CHITIETDONGLAPTOP lapTop, List<GIAODICH> danhSachGiaoDichTheoDongLaptop, List<NGHENGHIEP> danhSachNgheNghiep)
        {
            XmlNode tyLeTheoNgheNghiep;
            try
            {
                tyLeTheoNgheNghiep = this.xmlDocument.CreateElement("TY_LE_THEO_NGHE_NGHIEP");
            }
            catch (XmlException xmlEX)
            {
                throw xmlEX;
            }

            int soLuongCoGiaoDich, soLuongKhongGiaoDich, soLuongKhachHangTheoNgheNghiep;
            float tyLeGiaoDich, tyLeKhongGiaoDich;
            for (int iNgheNghiep = 0; iNgheNghiep < danhSachNgheNghiep.Count; ++iNgheNghiep)
            {
                soLuongCoGiaoDich = 0;
                soLuongKhongGiaoDich = 0;            
                try
                {
                    soLuongKhachHangTheoNgheNghiep = myKhachHangDAO.SLKhachHangTheoNgheNghiep(danhSachNgheNghiep[iNgheNghiep].MaNgheNghiep);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
             
                for (int iGiaoDich = 0; iGiaoDich < danhSachGiaoDichTheoDongLaptop.Count; ++iGiaoDich)
                {
                    if (danhSachNgheNghiep[iNgheNghiep].MaNgheNghiep == danhSachGiaoDichTheoDongLaptop[iGiaoDich].KHACHHANG.MaNgheNghiep)
                    {
                        ++soLuongCoGiaoDich;
                    }
                }
                
                try
                {
                    tyLeGiaoDich = ((float)soLuongCoGiaoDich / (float)danhSachGiaoDichTheoDongLaptop.Count) * 100;
                    soLuongKhongGiaoDich = soLuongKhachHangTheoNgheNghiep - soLuongCoGiaoDich;
                    tyLeKhongGiaoDich = ((float)soLuongKhongGiaoDich / ((float)this.tongSoLuongGiaoDich - (float)danhSachGiaoDichTheoDongLaptop.Count)) * 100;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                try
                {
                    XmlNode xmlNgheNghiep = this.TaoXMLNode("NGHE_NGHIEP", danhSachNgheNghiep[iNgheNghiep].MaNgheNghiep, tyLeGiaoDich, tyLeKhongGiaoDich);
                    tyLeTheoNgheNghiep.AppendChild(xmlNgheNghiep);
                }
                catch (XmlException xmlEX)
                {
                    throw xmlEX;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return tyLeTheoNgheNghiep;
        }

        /// <summary>
        /// Tạo một node có tên TY_LE_THEO_MUC_DICH_SU_DUNG
        /// Có 2 giá trị được ghi vào là tỷ lệ giao dịch của từng loại mục đích sử dụng với dòng máy được đưa vào
        /// Dựa trên danh sách các giao dịch được lưu
        /// </summary>
        /// <param name="lapTop"> Laptop cần thống kê</param>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <param name="danhSachMucDichSuDung"> danh sách mục đích sử dụng có trong CSDL</param>
        /// <returns>
        ///     Thành công: trả về Node TY_LE_THEO_MUC_DICH_SU_DUNG
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public XmlNode TinhTyLeTheoMucDichSuDung(CHITIETDONGLAPTOP lapTop, List<GIAODICH> danhSachGiaoDichTheoDongLaptop, List<MUCDICHSUDUNG> danhSachMucDichSuDung)
        {
            XmlNode tyLeTheoMucDichSuDung;
            try
            {
                tyLeTheoMucDichSuDung = this.xmlDocument.CreateElement("TY_LE_THEO_MUC_DICH_SU_DUNG");
            }
            catch (XmlException xmlEX)
            {
                throw xmlEX;
            }

            int soLuongCoGiaoDich, soLuongKhongGiaoDich, soLuongKhachHangTheoMucDich;
            float tyLeGiaoDich, tyLeKhongGiaoDich;
            for (int k = 0; k < danhSachMucDichSuDung.Count; ++k)
            {
                soLuongCoGiaoDich = soLuongKhongGiaoDich = 0;            
                try
                {
                    soLuongKhachHangTheoMucDich = myKhachHangDAO.SLKhachHangTheoMucDich(danhSachMucDichSuDung[k].MaMucDichSuDung);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
               
                for (int j = 0; j < danhSachGiaoDichTheoDongLaptop.Count; ++j)
                {
                    if (danhSachMucDichSuDung[k].MaMucDichSuDung == danhSachGiaoDichTheoDongLaptop[j].KHACHHANG.MaMucDichSuDung)
                    {
                        ++soLuongCoGiaoDich;
                    }
                }

                try
                {
                    tyLeGiaoDich = ((float)soLuongCoGiaoDich / (float)danhSachGiaoDichTheoDongLaptop.Count) * 100;
                    soLuongKhongGiaoDich = soLuongKhachHangTheoMucDich - soLuongCoGiaoDich;
                    tyLeKhongGiaoDich = ((float)soLuongKhongGiaoDich / ((float)this.tongSoLuongGiaoDich - (float)danhSachGiaoDichTheoDongLaptop.Count)) * 100;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                try
                {
                    XmlNode xmlMucDich = this.TaoXMLNode("MUC_DICH", danhSachMucDichSuDung[k].MaMucDichSuDung, tyLeGiaoDich, tyLeKhongGiaoDich);
                    tyLeTheoMucDichSuDung.AppendChild(xmlMucDich);
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

            return tyLeTheoMucDichSuDung;
        }
        
        /// <summary>
        /// Tạo một node có tên TY_LE_THEO_DO_TUOI
        /// Có 2 giá trị được ghi vào là tỷ lệ giao dịch của từng loại độ tuổi với dòng máy được đưa vào
        /// Dựa trên danh sách các giao dịch được lưu
        /// </summary>
        /// <param name="lapTop"> lapTop cần thống kê</param>
        /// <param name="danhSachGiaoDichTheoDonglapTop">danh sách giao dịch theo dòng lapTop</param>
        /// <param name="danhSachDoTuoi"> danh sách độ tuổi có trong CSDL</param>
        /// <returns>
        ///     Thành công: trả về Node TY_LE_THEO_DO_TUOI
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public XmlNode TinhTyLeTheoDoTuoi(CHITIETDONGLAPTOP lapTop, List<GIAODICH> danhSachGiaoDichTheoDonglapTop, List<DOTUOI> danhSachDoTuoi)
        {
            XmlNode tyLeTheoDoTuoi;
            try
            {
                tyLeTheoDoTuoi = this.xmlDocument.CreateElement("TY_LE_THEO_DO_TUOI");
            }
            catch (XmlException XmlEX)
            {
                throw XmlEX;
            }

            int soLuongCoGiaoDich, soLuongKhongGiaoDich, soLuongKhachHangTheoDoTuoi;
            float tyLeGiaoDich, tyLeKhongGiaoDich;
            for (int k = 0; k < danhSachDoTuoi.Count; ++k)
            {
                soLuongCoGiaoDich = soLuongKhongGiaoDich = 0;
                try
                {
                    soLuongKhachHangTheoDoTuoi = myKhachHangDAO.SLKhachHangTheoDoTuoi(danhSachDoTuoi[k].MaDoTuoi);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
               
                for (int j = 0; j < danhSachGiaoDichTheoDonglapTop.Count; ++j)
                {
                    if (danhSachDoTuoi[k].MaDoTuoi == danhSachGiaoDichTheoDonglapTop[j].KHACHHANG.MaDoTuoi)
                    {
                        ++soLuongCoGiaoDich;
                    }
                }

                try
                {
                    tyLeGiaoDich = ((float)soLuongCoGiaoDich / (float)danhSachGiaoDichTheoDonglapTop.Count) * 100;
                    soLuongKhongGiaoDich = soLuongKhachHangTheoDoTuoi - soLuongCoGiaoDich;
                    tyLeKhongGiaoDich = ((float)soLuongKhongGiaoDich / ((float)this.tongSoLuongGiaoDich - (float)danhSachGiaoDichTheoDonglapTop.Count)) * 100;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                try
                {
                    XmlNode xmlDoTuoi = this.TaoXMLNode("DO_TUOI", danhSachDoTuoi[k].MaDoTuoi, tyLeGiaoDich, tyLeKhongGiaoDich);
                    tyLeTheoDoTuoi.AppendChild(xmlDoTuoi);
                }
                catch (XmlException xmlEX)
                {
                    throw xmlEX;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return tyLeTheoDoTuoi;
        }
       
        /// <summary>
        /// Tạo một node có tên TY_LE_THEO_TINH_THANH
        /// Có 2 giá trị được ghi vào là tỷ lệ giao dịch của từng loại tỉnh thành với dòng máy được đưa vào
        /// Dựa trên danh sách các giao dịch được lưu
        /// </summary>
        /// <param name="lapTop"> Laptop cần thống kê</param>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <param name="danhSachTinhThanh"> danh sách tỉnh thành có trong CSDL</param>
        /// <returns>
        ///     Thành công: trả về Node TY_LE_THEO_TINH_THANH
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public XmlNode TinhTyLeTheoTinhThanh(CHITIETDONGLAPTOP lapTop, List<GIAODICH> danhSachGiaoDichTheoDongLaptop, List<TINHTHANH> danhSachTinhThanh)
        {
            XmlNode tyLeTheoTinhThanh;
            try
            {
                tyLeTheoTinhThanh = this.xmlDocument.CreateElement("TY_LE_THEO_TINH_THANH");
            }
            catch (XmlException xmlEX)
            {
                throw xmlEX;
            }

            int soLuongCoGiaoDich, soLuongKhongGiaoDich, soLuongKhachHangTheoTinhThanh;
            float tyLeGiaoDich, tyLeKhongGiaoDich;
            for (int k = 0; k < danhSachTinhThanh.Count; ++k)
            {
                soLuongCoGiaoDich = soLuongKhongGiaoDich = 0;
                
                try
                {
                    soLuongKhachHangTheoTinhThanh = myKhachHangDAO.SLKhachHangTheoTinhThanh(danhSachTinhThanh[k].MaTinhThanh);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
             
                for (int j = 0; j < danhSachGiaoDichTheoDongLaptop.Count; ++j)
                {
                    if (danhSachTinhThanh[k].MaTinhThanh == danhSachGiaoDichTheoDongLaptop[j].KHACHHANG.MaTinhThanh)
                    {
                        ++soLuongCoGiaoDich;
                    }
                }

                try
                {
                    tyLeGiaoDich = ((float)soLuongCoGiaoDich / (float)danhSachGiaoDichTheoDongLaptop.Count) * 100;
                    soLuongKhongGiaoDich = soLuongKhachHangTheoTinhThanh - soLuongCoGiaoDich;
                    tyLeKhongGiaoDich = ((float)soLuongKhongGiaoDich / ((float)this.tongSoLuongGiaoDich - (float)danhSachGiaoDichTheoDongLaptop.Count)) * 100;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                try
                {
                    XmlNode xmlTinhThanh = this.TaoXMLNode("TINH_THANH", danhSachTinhThanh[k].MaTinhThanh, tyLeGiaoDich, tyLeKhongGiaoDich);
                    tyLeTheoTinhThanh.AppendChild(xmlTinhThanh);
                }
                catch (XmlException xmlEX)
                {
                    throw xmlEX;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return tyLeTheoTinhThanh;
        }

        /// <summary>
        /// Tạo một node có tên TY_LE_THEO_GIOI_TINH
        /// Có 2 giá trị được ghi vào là tỷ lệ giao dịch của từng loại giới tính với dòng máy được đưa vào
        /// Dựa trên danh sách các giao dịch được lưu
        /// </summary>
        ///  <param name="lapTop"> Laptop cần thống kê</param>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về Node TY_LE_THEO_GIOI_TINH
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public XmlNode TinhTyLeTheoGioiTinh(CHITIETDONGLAPTOP lapTop, List<GIAODICH> danhSachGiaoDichTheoDongLaptop)
        {
            XmlNode tyLeTheoGioiTinh;
            try
            {
                tyLeTheoGioiTinh = this.xmlDocument.CreateElement("TY_LE_THEO_GIOI_TINH");
            }
            catch (XmlException xmlEX)
            {
                throw xmlEX;
            }

            int soLuongCoGiaoDich, soLuongKhongGiaoDich, soLuongKhachHangTheoGioiTinh;
            float tyLeGiaoDich, tyLeKhongGiaoDich;
            for (int k = 0; k < 2; ++k)
            {
                soLuongCoGiaoDich = soLuongKhongGiaoDich = 0;               
                try
                {
                    if (k == 0)
                    {
                        soLuongKhachHangTheoGioiTinh = myKhachHangDAO.SLKhachHangTheoGioiTinh(false);
                    }
                    else
                    {
                        soLuongKhachHangTheoGioiTinh = myKhachHangDAO.SLKhachHangTheoGioiTinh(true);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }             

                for (int j = 0; j < danhSachGiaoDichTheoDongLaptop.Count; ++j)
                {
                    if ((danhSachGiaoDichTheoDongLaptop[j].KHACHHANG.GioiTinhNam == true && k == 1) || (danhSachGiaoDichTheoDongLaptop[j].KHACHHANG.GioiTinhNam == false && k == 0))
                    {
                        ++soLuongCoGiaoDich;
                    }
                }

                try
                {
                    tyLeGiaoDich = ((float)soLuongCoGiaoDich / ((float)danhSachGiaoDichTheoDongLaptop.Count)) * 100;
                    soLuongKhongGiaoDich = soLuongKhachHangTheoGioiTinh - soLuongCoGiaoDich;
                    tyLeKhongGiaoDich = ((float)soLuongKhongGiaoDich / ((float)this.tongSoLuongGiaoDich - (float)danhSachGiaoDichTheoDongLaptop.Count)) * 100;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                try
                {
                    XmlNode xmlGioiTinh = this.TaoXMLNode("GIOI_TINH", k, tyLeGiaoDich, tyLeKhongGiaoDich);
                    tyLeTheoGioiTinh.AppendChild(xmlGioiTinh);
                }
                catch (XmlException xmlEX)
                {
                    throw xmlEX;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return tyLeTheoGioiTinh;
        }

        /// <summary>
        /// Thực thi thuật toán bayes. Dữ liệu được lấy trong bảng giao dịch trong csdl
        /// Thực hiện tính xác xuất từng yếu tố ảnh hưởng tới quyết định chọn dòng máy của khách hàng với mỗi dòng máy
        /// </summary>
        public void AnalyseData()
        {           
            this.LoadFileXML("ResultAnalyseData.xml");
            XmlNode navasBayes = this.xmlDocument.DocumentElement;
            navasBayes.RemoveAll();

            List<NGHENGHIEP> danhSachNgheNgiep;
            List<MUCDICHSUDUNG> danhSachMucDichSuDung;
            List<DOTUOI> danhSachDoTuoi;
            List<TINHTHANH> danhSachTinhThanh;           
            List<CHITIETDONGLAPTOP> danhSachDongLaptop;
            try
            {
                danhSachNgheNgiep = myNgheNghiepDAO.LayNgheNghiep();
                danhSachMucDichSuDung = myMucDichSuDungDAO.LayMucDichSuDung();
                danhSachDoTuoi = myDoTuoiDAO.LayDoTuoi();
                danhSachTinhThanh = myTinhThanhDAO.LayTinhThanh();
                this.tongSoLuongGiaoDich = myGiaoDichDAO.LaySoLuongGiaoDich();
                danhSachDongLaptop = myChiTietDongLaptopDAO.LayTatCaChiTietDongLaptop();
            }
            catch (OverflowException overflowEX)
            {
                throw overflowEX;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<GIAODICH> danhSachGiaoDichTheoDongLaptop;
          
            for (int i = 0; i < danhSachDongLaptop.Count; ++i)
            {
                try
                {
                    danhSachGiaoDichTheoDongLaptop = myGiaoDichDAO.LayDanhSachGiaoDichTheoMaDongLapTop(danhSachDongLaptop[i].MaDongLapTop);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
               
                XmlNode dongLapTop = this.xmlDocument.CreateElement("DONGLAPTOP");
                XmlAttribute maDongLapTop = this.xmlDocument.CreateAttribute("ID");
                XmlAttribute tenDongLapTop = this.xmlDocument.CreateAttribute("TenDongLaptop");
                XmlAttribute soLuongDaBan = this.xmlDocument.CreateAttribute("SoLuongDaBan");
                maDongLapTop.Value = danhSachDongLaptop[i].MaDongLapTop.ToString();
                tenDongLapTop.Value = danhSachDongLaptop[i].TenChiTietDongLapTop;
                soLuongDaBan.Value = danhSachGiaoDichTheoDongLaptop.Count.ToString();
                try
                {
                    dongLapTop.Attributes.Append(maDongLapTop);
                    dongLapTop.Attributes.Append(tenDongLapTop);
                    dongLapTop.Attributes.Append(soLuongDaBan);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                XmlNode xmlTyLeTheoNgheNghiep = this.TinhTyLeTheoNgheNghiep(danhSachDongLaptop[i], danhSachGiaoDichTheoDongLaptop, danhSachNgheNgiep);               
                dongLapTop.AppendChild(xmlTyLeTheoNgheNghiep);
             
                XmlNode xmlTyLeTheoMucDichSuDung = this.TinhTyLeTheoMucDichSuDung(danhSachDongLaptop[i], danhSachGiaoDichTheoDongLaptop, danhSachMucDichSuDung);
                dongLapTop.AppendChild(xmlTyLeTheoMucDichSuDung);

                XmlNode xmlTyLeTheoDoTuoi = this.TinhTyLeTheoDoTuoi(danhSachDongLaptop[i], danhSachGiaoDichTheoDongLaptop, danhSachDoTuoi);
                dongLapTop.AppendChild(xmlTyLeTheoDoTuoi);

                XmlNode xmlTyLeTheoTinhThanh = this.TinhTyLeTheoTinhThanh(danhSachDongLaptop[i], danhSachGiaoDichTheoDongLaptop, danhSachTinhThanh);
                dongLapTop.AppendChild(xmlTyLeTheoTinhThanh);

                XmlNode xmlTyLeTheoGioiTinh = this.TinhTyLeTheoGioiTinh(danhSachDongLaptop[i], danhSachGiaoDichTheoDongLaptop);
                dongLapTop.AppendChild(xmlTyLeTheoGioiTinh);

                navasBayes.AppendChild(dongLapTop);
            }

            this.SaveFileXML("ResultAnalyseData.xml");
        }        
    }
}
