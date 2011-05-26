

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using EStoreDAO;

    /// <summary>
    /// Tạo dữ liệu kiểu Struct để lưu lại kết quả tích các tỉ lệ của từng dòng laptop
    /// </summary>
    public struct MyStruct
    {
        /// <summary>
        /// giá trị của từng dòng laptop
        /// </summary>
        public double Gt;

        /// <summary>
        /// identity của thể hiện
        /// </summary>
        public int Id;
    }

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
        /// this.danhSachNgheNghiep sách tất cả các nghề nghiệp có trong CSDL
        /// </summary>
        private List<NGHENGHIEP> danhSachNgheNghiep;

        /// <summary>
        /// danh sách tất cả các loại độ tuổi có trong CSDL
        /// </summary>
        private List<DOTUOI> danhSachDoTuoi;

        /// <summary>
        /// danh sách tất cả các loại mục đích sử dụng có trong CSDL
        /// </summary>
        private List<MUCDICHSUDUNG> danhSachMucDichSuDung;

        /// <summary>
        /// danh sách tất cả các tỉnh thành có trong CSDL
        /// </summary>
        private List<TINHTHANH> danhSachTinhThanh;

        /// <summary>
        /// danh sách tất cả các dòng laptop có trong CSDL
        /// </summary>
        private List<CHITIETDONGLAPTOP> danhSachDongLaptop;

        /// <summary>
        /// Initializes a new instance of the AlgorithmNavasBayes class
        /// </summary>
        public AlgorithmNavasBayes()
        {
            try
            {
                this.danhSachNgheNghiep = myNgheNghiepDAO.LayNgheNghiep();
                this.danhSachMucDichSuDung = myMucDichSuDungDAO.LayMucDichSuDung();
                this.danhSachDoTuoi = myDoTuoiDAO.LayDoTuoi();
                this.danhSachTinhThanh = myTinhThanhDAO.LayTinhThanh();
                this.danhSachDongLaptop = myChiTietDongLaptopDAO.LayTatCaChiTietDongLaptop();
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
        /// Gets or sets Danh sách Nghề nghiệp
        /// </summary>
        public List<NGHENGHIEP> DanhSachNgheNghiep
        {
            get { return this.danhSachNgheNghiep; }
            set { this.danhSachNgheNghiep = value; }
        }

        /// <summary>
        /// Gets or sets Danh sách mục đích sử dụng
        /// </summary>
        public List<MUCDICHSUDUNG> DanhSachMucDichSuDung
        {
            get { return this.danhSachMucDichSuDung; }
            set { this.danhSachMucDichSuDung = value; }
        }

        /// <summary>
        /// Gets or sets Danh sách độ tuổi
        /// </summary>
        public List<DOTUOI> DanhSachDoTuoi
        {
            get { return this.danhSachDoTuoi; }
            set { this.danhSachDoTuoi = value; }
        }

        /// <summary>
        /// Gets or sets Danh sách tỉnh thành
        /// </summary>
        public List<TINHTHANH> DanhSachTinhThanh
        {
            get { return this.danhSachTinhThanh; }
            set { this.danhSachTinhThanh = value; }
        }

        /// <summary>
        /// Gets or sets Danh sách dòng laptop
        /// </summary>
        public List<CHITIETDONGLAPTOP> DanhSachDongLaptop
        {
            get { return this.danhSachDongLaptop; }
            set { this.danhSachDongLaptop = value; }
        }

        /// <summary>
        /// Tính ra tất cả các tỷ lệ giao dịch của từng nghề nghiệp theo từng dòng máy tính nhất định
        /// </summary>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách bao gồm các tỷ lệ giao dịch của từng nghề nghiệp theo từng laptop
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public List<float> TinhTyLeTheoNgheNghiep(List<GIAODICH> danhSachGiaoDichTheoDongLaptop)
        {
            if (this.danhSachNgheNghiep == null)
            {
                return null;
            }

            List<float> danhSachTyLeGiaoDich;
            int soLuongCoGiaoDich;   
            float tyLeGiaoDich;

            try
            {
                danhSachTyLeGiaoDich = new List<float>();

                for (int ngheNghiep = 0; ngheNghiep < this.danhSachNgheNghiep.Count; ++ngheNghiep)
                {
                    soLuongCoGiaoDich = 0;

                    for (int giaoDich = 0; giaoDich < danhSachGiaoDichTheoDongLaptop.Count; ++giaoDich)
                    {
                        if (this.danhSachNgheNghiep[ngheNghiep].MaNgheNghiep == danhSachGiaoDichTheoDongLaptop[giaoDich].KHACHHANG.MaNgheNghiep)
                        {
                            ++soLuongCoGiaoDich;
                        }
                    }

                    tyLeGiaoDich = ((float)soLuongCoGiaoDich / (float)danhSachGiaoDichTheoDongLaptop.Count) * 100;
                    danhSachTyLeGiaoDich.Add(tyLeGiaoDich);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return danhSachTyLeGiaoDich;
        }

        /// <summary>
        /// Tính ra tất cả các tỷ lệ giao dịch của từng mục đích sử dụng theo từng dòng máy tính nhất định
        /// </summary>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách bao gồm các tỷ lệ giao dịch của từng mục đích sử dụng theo từng laptop
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public List<float> TinhTyLeTheoMucDichSuDung(List<GIAODICH> danhSachGiaoDichTheoDongLaptop)
        {
            if (this.danhSachMucDichSuDung == null)
            {
                return null;
            }

            List<float> danhSachTyLeGiaoDich;
            int soLuongCoGiaoDich;
            float tyLeGiaoDich;

            try
            {
                danhSachTyLeGiaoDich = new List<float>();

                for (int mucDich = 0; mucDich < this.danhSachMucDichSuDung.Count; ++mucDich)
                {
                    soLuongCoGiaoDich = 0;

                    for (int giaoDich = 0; giaoDich < danhSachGiaoDichTheoDongLaptop.Count; ++giaoDich)
                    {
                        if (this.danhSachMucDichSuDung[mucDich].MaMucDichSuDung == danhSachGiaoDichTheoDongLaptop[giaoDich].KHACHHANG.MaMucDichSuDung)
                        {
                            ++soLuongCoGiaoDich;
                        }
                    }

                    tyLeGiaoDich = ((float)soLuongCoGiaoDich / (float)danhSachGiaoDichTheoDongLaptop.Count) * 100;
                    danhSachTyLeGiaoDich.Add(tyLeGiaoDich);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return danhSachTyLeGiaoDich;
        }

        /// <summary>
        /// Tính ra tất cả các tỷ lệ giao dịch của từng độ tuổi theo từng dòng máy tính nhất định
        /// </summary>
        /// <param name="danhSachGiaoDichTheoDonglapTop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách bao gồm các tỷ lệ giao dịch của từng độ tuổi theo từng laptop
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public List<float> TinhTyLeTheoDoTuoi(List<GIAODICH> danhSachGiaoDichTheoDonglapTop)
        {
            if (this.danhSachDoTuoi == null)
            {
                return null;
            }

            List<float> danhSachTyLeGiaoDich;
            int soLuongCoGiaoDich;
            float tyLeGiaoDich;

            try
            {
                danhSachTyLeGiaoDich = new List<float>();

                for (int iDoTuoi = 0; iDoTuoi < this.danhSachDoTuoi.Count; ++iDoTuoi)
                {
                    soLuongCoGiaoDich = 0;

                    for (int giaoDich = 0; giaoDich < danhSachGiaoDichTheoDonglapTop.Count; ++giaoDich)
                    {
                        if (this.danhSachDoTuoi[iDoTuoi].MaDoTuoi == danhSachGiaoDichTheoDonglapTop[giaoDich].KHACHHANG.MaDoTuoi)
                        {
                            ++soLuongCoGiaoDich;
                        }
                    }

                    tyLeGiaoDich = ((float)soLuongCoGiaoDich / (float)danhSachGiaoDichTheoDonglapTop.Count) * 100;
                    danhSachTyLeGiaoDich.Add(tyLeGiaoDich);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return danhSachTyLeGiaoDich;
        }

        /// <summary>
        /// Tính ra tất cả các tỷ lệ giao dịch của từng tỉnh thành theo từng dòng máy tính nhất định
        /// </summary>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách bao gồm các tỷ lệ giao dịch của từng tỉnh thành theo từng laptop
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public List<float> TinhTyLeTheoTinhThanh(List<GIAODICH> danhSachGiaoDichTheoDongLaptop)
        {
            if (this.danhSachTinhThanh == null)
            {
                return null;
            }

            List<float> danhSachTyLeGiaoDich;
            int soLuongCoGiaoDich;
            float tyLeGiaoDich;

            try
            {
                danhSachTyLeGiaoDich = new List<float>();

                for (int tinhThanh = 0; tinhThanh < this.danhSachTinhThanh.Count; ++tinhThanh)
                {
                    soLuongCoGiaoDich = 0;
                    for (int giaoDich = 0; giaoDich < danhSachGiaoDichTheoDongLaptop.Count; ++giaoDich)
                    {
                        if (this.danhSachTinhThanh[tinhThanh].MaTinhThanh == danhSachGiaoDichTheoDongLaptop[giaoDich].KHACHHANG.MaTinhThanh)
                        {
                            ++soLuongCoGiaoDich;
                        }
                    }

                    tyLeGiaoDich = ((float)soLuongCoGiaoDich / (float)danhSachGiaoDichTheoDongLaptop.Count) * 100;
                    danhSachTyLeGiaoDich.Add(tyLeGiaoDich);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return danhSachTyLeGiaoDich;
        }

        /// <summary>
        /// Tính ra tất cả các tỷ lệ giao dịch của từng giới tính theo từng dòng máy tính nhất định
        /// </summary>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách bao gồm các tỷ lệ giao dịch của từng giới tính theo từng laptop
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public List<float> TinhTyLeTheoGioiTinh(List<GIAODICH> danhSachGiaoDichTheoDongLaptop)
        {
            List<float> danhSachTyLeGiaoDich;
            int soLuongCoGiaoDich;
            float tyLeGiaoDich;
            try
            {
                danhSachTyLeGiaoDich = new List<float>();

                for (int k = 0; k < 2; ++k)
                {
                    soLuongCoGiaoDich = 0;
                    for (int giaoDich = 0; giaoDich < danhSachGiaoDichTheoDongLaptop.Count; ++giaoDich)
                    {
                        if ((danhSachGiaoDichTheoDongLaptop[giaoDich].KHACHHANG.GioiTinhNam == true && k == 1) || (danhSachGiaoDichTheoDongLaptop[giaoDich].KHACHHANG.GioiTinhNam == false && k == 0))
                        {
                            ++soLuongCoGiaoDich;
                        }
                    }

                    tyLeGiaoDich = ((float)soLuongCoGiaoDich / ((float)danhSachGiaoDichTheoDongLaptop.Count)) * 100;
                    danhSachTyLeGiaoDich.Add(tyLeGiaoDich);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return danhSachTyLeGiaoDich;
        }

        /// <summary>
        /// Load file XML
        /// </summary>
        /// <param name="fileName">
        /// Tên của file xml để Load
        /// </param>
        /// <returns>
        ///     thành công : trả về 1 XmlDocument
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public XmlDocument LoadFileXML(string fileName)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                return xmlDocument;
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
        /// <param name="xmlDocument"> đối tượng XmlDocument</param>
        /// <param name="fileName"> tên của file xml</param>
        /// <returns>
        ///     thành công : trả về true và ngược lại trả về false
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public bool SaveFileXML(XmlDocument xmlDocument, string fileName)
        {
            try
            {
                if (xmlDocument != null)
                {
                    xmlDocument.Save(fileName);
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

        /*
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
        private XmlNode TaoXmlNode(string tenThe, int id, float tyLeGiaoDich)
        {
            try
            {
                XmlNode node = this.xmlDocument.CreateElement(tenThe);
                XmlAttribute xmlID = this.xmlDocument.CreateAttribute("ID");
                XmlAttribute xmlTyLeGiaoDich = this.xmlDocument.CreateAttribute("TyLeGiaoDich");

                xmlID.Value = id.ToString();
                xmlTyLeGiaoDich.Value = tyLeGiaoDich.ToString();

                node.Attributes.Append(xmlID);
                node.Attributes.Append(xmlTyLeGiaoDich);
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
        */

        /// <summary>
        /// Thực thi thuật toán bayes. Dữ liệu được lấy trong bảng giao dịch trong csdl
        /// Thực hiện tính xác xuất từng yếu tố ảnh hưởng tới quyết định chọn dòng máy của khách hàng với mỗi dòng máy
        /// </summary>
        public void PhanTichDuLieu()
        {
            XmlDocument xmlDocument = this.LoadFileXML("ResultAnalyseData.xml");
            XmlNode navasBayes = xmlDocument.DocumentElement;
            navasBayes.RemoveAll();
            List<GIAODICH> danhSachGiaoDichTheoDongLaptop;
            XmlNode dongLapTop;
            for (int i = 0; i < this.danhSachDongLaptop.Count; ++i)
            {
                try
                {
                    danhSachGiaoDichTheoDongLaptop = myGiaoDichDAO.LayDanhSachGiaoDichTheoMaDongLapTop(this.danhSachDongLaptop[i].MaDongLapTop);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                try
                {
                    dongLapTop = xmlDocument.CreateElement("DONGLAPTOP");
                    XmlAttribute maDongLapTop = xmlDocument.CreateAttribute("ID");
                    maDongLapTop.Value = this.danhSachDongLaptop[i].MaDongLapTop.ToString();
                    dongLapTop.Attributes.Append(maDongLapTop);
                }
                catch (XmlException xmlEx)
                {
                    throw xmlEx;
                }

                List<float> danhSachTyLeTheoNgheNghiep = this.TinhTyLeTheoNgheNghiep(danhSachGiaoDichTheoDongLaptop);
                this.LuuVaoXmlFile(dongLapTop, danhSachTyLeTheoNgheNghiep, "NGHE_NGHIEP");

                List<float> danhSachTyLeTheoMucDichSuDung = this.TinhTyLeTheoMucDichSuDung(danhSachGiaoDichTheoDongLaptop);
                this.LuuVaoXmlFile(dongLapTop, danhSachTyLeTheoMucDichSuDung, "MUC_DICH_SU_DUNG");

                List<float> danhSachTyLeTheoDoTuoi = this.TinhTyLeTheoDoTuoi(danhSachGiaoDichTheoDongLaptop);
                this.LuuVaoXmlFile(dongLapTop, danhSachTyLeTheoDoTuoi, "DO_TUOI");

                List<float> danhSachTyLeTheoTinhThanh = this.TinhTyLeTheoTinhThanh(danhSachGiaoDichTheoDongLaptop);
                this.LuuVaoXmlFile(dongLapTop, danhSachTyLeTheoTinhThanh, "TINH_THANH");

                List<float> danhSachTyLeTheoGioiTinh = this.TinhTyLeTheoGioiTinh(danhSachGiaoDichTheoDongLaptop);
                this.LuuVaoXmlFile(dongLapTop, danhSachTyLeTheoGioiTinh, "GIOI_TINH");

                navasBayes.AppendChild(dongLapTop);
            }

            this.SaveFileXML(xmlDocument, "ResultAnalyseData.xml");
        }

        /// <summary>
        /// Sắp xếp list MyStruct
        /// Đầu vào là một list phần tử kiểu MyStruct
        /// </summary>
        /// <param name="listSanPham">danh sách sản phẩm</param>
        /// <returns>
        ///     Thành công: trả về List MyStruct đã được sắp xếp tăng dần
        ///     Thất bại: throw một Exception ra màn hình
        /// </returns>
        public List<MyStruct> SapXep(List<MyStruct> listSanPham)
        {
            if (listSanPham == null)
            {
                return null;
            }

            for (int i = 0; i < listSanPham.Count; i++)
            {
                for (int j = i; j < listSanPham.Count; j++)
                {
                    if (listSanPham[i].Gt < listSanPham[j].Gt)
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
        /// Thực thi thuật toán NaiveBayes
        /// </summary>
        /// <param name="iDNgheNghiep">ID nghề nghiệp</param>
        /// <param name="iDGioiTinh"> ID Giới tính</param>
        /// <param name="iDDoTuoi">ID độ tuổi</param>
        /// <param name="iDTinhThanh">ID tỉnh thành</param>
        /// <param name="iDMucDich">ID mục đích</param>
        /// <param name="iDMucGia">ID múc giá</param>
        /// <returns> 
        ///     Thành công: trả về List MyStruct chứa ID của các laptop được chọn
        ///     Thất bại: throw một Exception ra màn hình
        /// </returns>
        public List<MyStruct> ThuatToanNaiveBayes(
            int iDNgheNghiep,
            int iDGioiTinh,
            int iDDoTuoi,
            int iDTinhThanh,
            int iDMucDich,
            int iDMucGia)
        {
            List<string> listXPath = new List<string>();
            List<XmlNodeList> listXmlNodeList = new List<XmlNodeList>();
            List<MyStruct> listMyStruct = new List<MyStruct>();
            List<MyStruct> listSanPhamDatYeuCau = new List<MyStruct>();

            try
            {
                listXPath = this.KhoiTaoXPath(iDNgheNghiep, iDGioiTinh, iDDoTuoi, iDTinhThanh, iDMucDich);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            listXmlNodeList = this.LayDuLieuTuFileXML(listXPath[0], listXPath[1], listXPath[2], listXPath[3], listXPath[4], "ResultAnalyseData.xml");
            listMyStruct = this.ThuaNhanNaives(listXmlNodeList[0], listXmlNodeList[1], listXmlNodeList[2], listXmlNodeList[3], listXmlNodeList[4]);
            
            try
            {
                listMyStruct = this.KiemTraHopLe(listMyStruct, iDMucGia);
                if (listMyStruct.Count > 0)
                {
                    listMyStruct = this.SapXep(listMyStruct);
                    listSanPhamDatYeuCau.Add(listMyStruct[0]);
                    listSanPhamDatYeuCau.Add(listMyStruct[1]);
                    listSanPhamDatYeuCau.Add(listMyStruct[2]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listSanPhamDatYeuCau;
        }

        /// <summary>
        /// Đầu vào là list các ID của laptop
        /// Đầu ra là list các ID của laptop đã được kiểm tra tồn tại và các điều kiện
        /// </summary>
        /// <param name="listSanPham">danh sách sản phẩm</param>
        /// <param name="iDMucGia">ID của mức giá</param>
        /// <returns>
        ///     Thành công: trả về List MyStruct chứa ID của các laptop hợp lệ
        ///     Thất bại: throw một Exception ra màn hình
        /// </returns>
        public List<MyStruct> KiemTraHopLe(List<MyStruct> listSanPham, int iDMucGia)
        {
            List<MyStruct> listSanPhamDatYeuCau = new List<MyStruct>();

            for (int i = 0; i < listSanPham.Count; i++)
            {
                try
                {
                    bool isHopLe = MyChiTietDongLaptopBUS.KiemTraGiaTienHopLe(listSanPham[i].Id + 1, iDMucGia);
                   
                    if (isHopLe)
                    {
                        if (MyChiTietDongLaptopBUS.KiemTraSanPhamTonTai(listSanPham[i].Id + 1) == false)
                        {
                            listSanPhamDatYeuCau.Add(listSanPham[i]);
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    listSanPhamDatYeuCau = null;
                    throw ex;
                }
            }

            return listSanPhamDatYeuCau;
        }

        /// <summary>
        /// Thực thi thuật toán thừa nhận Naive
        /// </summary>
        /// <param name="nodeListTinhThanh"> node list của tỉnh thành</param>
        /// <param name="nodeListNgheNghiep">node list của nghề nghiệp</param>
        /// <param name="nodeListDoTuoi">node list của độ tuổi</param>
        /// <param name="nodeListMucDich">node list của mục địch</param>
        /// <param name="nodeListGioiTinh">node list của giới tính</param>
        /// <returns>
        /// Thành công: trả về List MyStruct chứa ID của các laptop được chọn
        /// Thất bại: throw một Exception ra màn hình
        /// </returns>
        public List<MyStruct> ThuaNhanNaives(
            XmlNodeList nodeListTinhThanh,
            XmlNodeList nodeListNgheNghiep,
            XmlNodeList nodeListDoTuoi,
            XmlNodeList nodeListMucDich,
            XmlNodeList nodeListGioiTinh)
        {
            List<MyStruct> listKetQua = new List<MyStruct>();

            try
            {
                for (int i = 0; i < nodeListNgheNghiep.Count; i++)
                {
                    double ketQua = 0;

                    if (nodeListTinhThanh[i].InnerText != null)
                    {
                        ketQua = double.Parse(nodeListTinhThanh[i].InnerText);
                    }

                    if (nodeListNgheNghiep[i].InnerText != null)
                    {
                        ketQua *= double.Parse(nodeListNgheNghiep[i].InnerText);
                    }

                    if (nodeListMucDich[i].InnerText != null)
                    {
                        ketQua *= double.Parse(nodeListMucDich[i].InnerText);
                    }

                    if (nodeListGioiTinh[i].InnerText != null)
                    {
                        ketQua *= double.Parse(nodeListGioiTinh[i].InnerText);
                    }

                    if (nodeListDoTuoi[i].InnerText != null)
                    {
                        ketQua *= double.Parse(nodeListDoTuoi[i].InnerText);
                    }

                    MyStruct myStruct = new MyStruct();
                    myStruct.Gt = ketQua;
                    myStruct.Id = i;
                    listKetQua.Add(myStruct);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listKetQua;
        }

        /// <summary>
        /// Lấy dữ liệu từ file XML
        /// </summary>
        /// <param name="pathNgheNghiep"> đường đi của nghề nghiệp</param>
        /// <param name="pathGioiTinh"> đường đi của giới tính</param>
        /// <param name="pathDoTuoi"> đường đi của độ tuôi</param>
        /// <param name="pathTinhThanh">đường đi của tỉnh thành</param>
        /// <param name="pathMucDich">đường đi của mục đích</param>
        /// <param name="fileXmlName">tên của file XML</param>
        /// <returns>
        ///  Thành công: trả về List XmlNodeList
        ///  Thất bại: throw một Exception ra màn hình
        /// </returns>
        public List<XmlNodeList> LayDuLieuTuFileXML(
            string pathNgheNghiep,
            string pathGioiTinh,
            string pathDoTuoi,
            string pathTinhThanh,
            string pathMucDich,
            string fileXmlName)
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(fileXmlName);
            }
            catch (System.Xml.XmlException ex)
            {
                throw ex;
            }

            string path = pathNgheNghiep;
            List<XmlNodeList> listNodeList = new List<XmlNodeList>();

            try
            {
                XmlNodeList nodeListNgheNghiep = xmlDoc.SelectNodes(path);
                path = pathDoTuoi;
                XmlNodeList nodeListDoTuoi = xmlDoc.SelectNodes(path);
                path = pathGioiTinh;
                XmlNodeList nodeListGioiTinh = xmlDoc.SelectNodes(path);
                path = pathMucDich;
                XmlNodeList nodeListMucDich = xmlDoc.SelectNodes(path);
                path = pathTinhThanh;
                XmlNodeList nodeListTinhThanh = xmlDoc.SelectNodes(path);
                listNodeList.Add(nodeListDoTuoi);
                listNodeList.Add(nodeListGioiTinh);
                listNodeList.Add(nodeListMucDich);
                listNodeList.Add(nodeListNgheNghiep);
                listNodeList.Add(nodeListTinhThanh);
            }
            catch (System.Xml.XmlException ex)
            {
                throw ex;
            }

            return listNodeList;
        }

        /// <summary>
        /// Khởi tạo đường đi
        /// </summary>
        /// <param name="iDNgheNghiep">ID nghề nghiệp</param>
        /// <param name="iDGioiTinh">ID giới tính</param>
        /// <param name="iDDoTuoi">ID độ tuổi</param>
        /// <param name="iDTinhThanh">ID tỉnh thành</param>
        /// <param name="iDMucDich">ID mục đích</param>
        /// <returns>trả về list danh sách các đường</returns>
        public List<string> KhoiTaoXPath(int iDNgheNghiep, int iDGioiTinh, int iDDoTuoi, int iDTinhThanh, int iDMucDich)
        {
            List<string> listXPath = new List<string>();

            try
            {
                string pathNgheNghiep = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_NGHE_NGHIEP/NGHE_NGHIEP/@TyLeGiaoDich[../@ID='" + iDNgheNghiep.ToString() + "']";
                string pathGioiTinh = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_GIOI_TINH/GIOI_TINH/@TyLeGiaoDich[../@ID='" + iDGioiTinh.ToString() + "']";
                string pathDoTuoi = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_DO_TUOI/DO_TUOI/@TyLeGiaoDich[../@ID='" + iDDoTuoi.ToString() + "']";
                string pathTinhThanh = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_TINH_THANH/TINH_THANH/@TyLeGiaoDich[../@ID='" + iDTinhThanh.ToString() + "']";
                string pathMucDich = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_MUC_DICH_SU_DUNG/MUC_DICH_SU_DUNG/@TyLeGiaoDich[../@ID='" + iDMucDich.ToString() + "']";
                listXPath.Add(pathDoTuoi);
                listXPath.Add(pathGioiTinh);
                listXPath.Add(pathMucDich);
                listXPath.Add(pathNgheNghiep);
                listXPath.Add(pathTinhThanh);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listXPath;
        }

        /// <summary>
        /// lưu vào xml các tỷ lệ giao dịch của tất cả tiêu chí theo nghề nghiệp,mục đích,giới tính...vào 1 node cha(parentNode: node lưu 1 dòng laptop nào đó)
        /// </summary>
        /// <param name="parentNode">node cha: dùng để xác định dòng laptop nào</param>
        /// <param name="danhSachTyLeGiaoDich"> danh sách các tỷ lệ giao dịch</param>
        /// <param name="tenThe">tên thẻ :dùng để xác định lưu theo từng tiêu chí nào :Nghề nghiệp, mục đích sử dụng,giới tính ...</param>
        private void LuuVaoXmlFile(XmlNode parentNode, List<float> danhSachTyLeGiaoDich, string tenThe)
        {
            try
            {
                XmlDocument xmlDocument = parentNode.OwnerDocument;
                XmlNode newNode;
                newNode = xmlDocument.CreateElement("TY_LE_THEO_" + tenThe);
                XmlNode nodeTyLe;
                XmlAttribute xmlID;
                XmlAttribute xmlTyLeGiaoDich;
                for (int index = 0; index < danhSachTyLeGiaoDich.Count; ++index)
                {
                    nodeTyLe = xmlDocument.CreateElement(tenThe);
                    xmlID = xmlDocument.CreateAttribute("ID");
                    xmlTyLeGiaoDich = xmlDocument.CreateAttribute("TyLeGiaoDich");
                    if (tenThe.Equals("GIOI_TINH"))
                    {
                        xmlID.Value = index.ToString();
                    }
                    else
                    {
                        xmlID.Value = (index + 1).ToString();
                    }

                    xmlTyLeGiaoDich.Value = danhSachTyLeGiaoDich[index].ToString();

                    nodeTyLe.Attributes.Append(xmlID);
                    nodeTyLe.Attributes.Append(xmlTyLeGiaoDich);
                    newNode.AppendChild(nodeTyLe);
                }

                parentNode.AppendChild(newNode);
            }
            catch (XmlException xmlEx)
            {
                throw xmlEx;
            }
        }
    }
}
