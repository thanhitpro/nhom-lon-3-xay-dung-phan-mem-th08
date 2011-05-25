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
    /// Tạo dữ liệu kiểu Struct để lưu lại kết quả tích các tỉ lệ của từng dòng laptop
    /// </summary>
    public struct MyStruct
    {
        public double gt;
        public int id;
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
        /// danh sách tất cả các nghề nghiệp có trong CSDL
        /// </summary>
        private List<NGHENGHIEP> danhSachNgheNghiep;

        public List<NGHENGHIEP> DanhSachNgheNghiep
        {
            get { return danhSachNgheNghiep; }
            set { danhSachNgheNghiep = value; }
        }

        /// <summary>
        /// danh sách tất cả các loại mục đích sử dụng có trong CSDL
        /// </summary>
        private List<MUCDICHSUDUNG> danhSachMucDichSuDung;

        public List<MUCDICHSUDUNG> DanhSachMucDichSuDung
        {
            get { return danhSachMucDichSuDung; }
            set { danhSachMucDichSuDung = value; }
        }

        /// <summary>
        /// danh sách tất cả các loại độ tuổi có trong CSDL
        /// </summary>
        private List<DOTUOI> danhSachDoTuoi;

        public List<DOTUOI> DanhSachDoTuoi
        {
            get { return danhSachDoTuoi; }
            set { danhSachDoTuoi = value; }
        }

        /// <summary>
        /// danh sách tất cả các tỉnh thành có trong CSDL
        /// </summary>
        private List<TINHTHANH> danhSachTinhThanh;

        public List<TINHTHANH> DanhSachTinhThanh
        {
            get { return danhSachTinhThanh; }
            set { danhSachTinhThanh = value; }
        }

        /// <summary>
        /// danh sách tất cả các dòng laptop có trong CSDL
        /// </summary>
        private List<CHITIETDONGLAPTOP> danhSachDongLaptop;

        public List<CHITIETDONGLAPTOP> DanhSachDongLaptop
        {
            get { return danhSachDongLaptop; }
            set { danhSachDongLaptop = value; }
        }

        /// <summary>
        /// hàm khởi tạo
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
        /// Tính ra tất cả các tỷ lệ giao dịch của từng nghề nghiệp theo từng dòng máy tính nhất định
        /// </summary>
        /// <param name="lapTop"> Laptop cần thống kê</param>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách bao gồm các tỷ lệ giao dịch của từng nghề nghiệp theo từng laptop
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private List<float> TinhTyLeTheoNgheNghiep(CHITIETDONGLAPTOP lapTop, List<GIAODICH> danhSachGiaoDichTheoDongLaptop)
        {
            if (this.danhSachNgheNghiep == null)
                return null;
            List<float> danhSachTyLeGiaoDich;
            int soLuongCoGiaoDich;   
            float tyLeGiaoDich;
            try
            {
                danhSachTyLeGiaoDich = new List<float>();
                for (int iNgheNghiep = 0; iNgheNghiep < this.danhSachNgheNghiep.Count; ++iNgheNghiep)
                {
                    soLuongCoGiaoDich = 0;
                    for (int iGiaoDich = 0; iGiaoDich < danhSachGiaoDichTheoDongLaptop.Count; ++iGiaoDich)
                    {
                        if (danhSachNgheNghiep[iNgheNghiep].MaNgheNghiep == danhSachGiaoDichTheoDongLaptop[iGiaoDich].KHACHHANG.MaNgheNghiep)
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
        /// <param name="lapTop"> Laptop cần thống kê</param>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách bao gồm các tỷ lệ giao dịch của từng mục đích sử dụng theo từng laptop
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private List<float> TinhTyLeTheoMucDichSuDung(CHITIETDONGLAPTOP lapTop, List<GIAODICH> danhSachGiaoDichTheoDongLaptop)
        {
            if (this.danhSachMucDichSuDung == null)
                return null;
            List<float> danhSachTyLeGiaoDich;
            int soLuongCoGiaoDich;
            float tyLeGiaoDich;
            try
            {
                danhSachTyLeGiaoDich = new List<float>();
                for (int iMucDich = 0; iMucDich < this.danhSachMucDichSuDung.Count; ++iMucDich)
                {
                    soLuongCoGiaoDich = 0;
                    for (int iGiaoDich = 0; iGiaoDich < danhSachGiaoDichTheoDongLaptop.Count; ++iGiaoDich)
                    {
                        if (danhSachMucDichSuDung[iMucDich].MaMucDichSuDung == danhSachGiaoDichTheoDongLaptop[iGiaoDich].KHACHHANG.MaMucDichSuDung)
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
        /// <param name="lapTop"> Laptop cần thống kê</param>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách bao gồm các tỷ lệ giao dịch của từng độ tuổi theo từng laptop
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private List<float> TinhTyLeTheoDoTuoi(CHITIETDONGLAPTOP lapTop, List<GIAODICH> danhSachGiaoDichTheoDonglapTop)
        {
            if (this.danhSachDoTuoi == null)
                return null;
            List<float> danhSachTyLeGiaoDich;
            int soLuongCoGiaoDich;
            float tyLeGiaoDich;
            try
            {
                danhSachTyLeGiaoDich = new List<float>();
                for (int iDoTuoi = 0; iDoTuoi < danhSachDoTuoi.Count; ++iDoTuoi)
                {
                    soLuongCoGiaoDich =0;
                    for (int iGiaoDich = 0; iGiaoDich < danhSachGiaoDichTheoDonglapTop.Count; ++iGiaoDich)
                    {
                        if (danhSachDoTuoi[iDoTuoi].MaDoTuoi == danhSachGiaoDichTheoDonglapTop[iGiaoDich].KHACHHANG.MaDoTuoi)
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
        /// <param name="lapTop"> Laptop cần thống kê</param>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách bao gồm các tỷ lệ giao dịch của từng tỉnh thành theo từng laptop
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private List<float> TinhTyLeTheoTinhThanh(CHITIETDONGLAPTOP lapTop, List<GIAODICH> danhSachGiaoDichTheoDongLaptop)
        {
            if (this.danhSachTinhThanh == null)
                return null;
            List<float> danhSachTyLeGiaoDich;
            int soLuongCoGiaoDich;
            float tyLeGiaoDich;
            try
            {
                danhSachTyLeGiaoDich = new List<float>();
                for (int iTinhThanh = 0; iTinhThanh < danhSachTinhThanh.Count; ++iTinhThanh)
                {
                    soLuongCoGiaoDich = 0;
                    for (int iGiaoDich = 0; iGiaoDich < danhSachGiaoDichTheoDongLaptop.Count; ++iGiaoDich)
                    {
                        if (danhSachTinhThanh[iTinhThanh].MaTinhThanh == danhSachGiaoDichTheoDongLaptop[iGiaoDich].KHACHHANG.MaTinhThanh)
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
        /// <param name="lapTop"> Laptop cần thống kê</param>
        /// <param name="danhSachGiaoDichTheoDongLaptop">danh sách giao dịch theo dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách bao gồm các tỷ lệ giao dịch của từng giới tính theo từng laptop
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        private List<float> TinhTyLeTheoGioiTinh(CHITIETDONGLAPTOP lapTop, List<GIAODICH> danhSachGiaoDichTheoDongLaptop)
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
                    for (int iGiaoDich = 0; iGiaoDich < danhSachGiaoDichTheoDongLaptop.Count; ++iGiaoDich)
                    {
                        if ((danhSachGiaoDichTheoDongLaptop[iGiaoDich].KHACHHANG.GioiTinhNam == true && k == 1) || (danhSachGiaoDichTheoDongLaptop[iGiaoDich].KHACHHANG.GioiTinhNam == false && k == 0))
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
        /// lưu vào xml các tỷ lệ giao dịch của tất cả tiêu chí theo nghề nghiệp,mục đích,giới tính...vào 1 node cha(parentNode: node lưu 1 dòng laptop nào đó)
        /// </summary>
        /// <param name="parentNode">node cha: dùng để xác định dòng laptop nào</param>
        /// <param name="danhSachTyLeGiaoDich"> danh sách các tỷ lệ giao dịch</param>
        /// <param name="TenThe">tên thẻ :dùng để xác định lưu theo từng tiêu chí nào :Nghề nghiệp, mục đích sử dụng,giới tính ...</param>
        private void LuuVaoXmlFile(XmlNode parentNode, List<float> danhSachTyLeGiaoDich, string TenThe)
        {
            try
            {
                XmlDocument xmlDocument = parentNode.OwnerDocument;
                XmlNode newNode;
                newNode = xmlDocument.CreateElement("TY_LE_THEO_" + TenThe);
                XmlNode nodeTyLe;
                XmlAttribute xmlID;
                XmlAttribute xmlTyLeGiaoDich;
                for (int index = 0; index < danhSachTyLeGiaoDich.Count; ++index)
                {
                    nodeTyLe = xmlDocument.CreateElement(TenThe);
                    xmlID = xmlDocument.CreateAttribute("ID");
                    xmlTyLeGiaoDich = xmlDocument.CreateAttribute("TyLeGiaoDich");
                    if (TenThe.Equals("GIOI_TINH"))
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

        /// <summary>
        /// Thực thi thuật toán bayes. Dữ liệu được lấy trong bảng giao dịch trong csdl
        /// Thực hiện tính xác xuất từng yếu tố ảnh hưởng tới quyết định chọn dòng máy của khách hàng với mỗi dòng máy
        /// </summary>
        public void PhanTichDuLieu()
        {
            XmlDocument xmlDocument= this.LoadFileXML("ResultAnalyseData.xml");
            XmlNode navasBayes = xmlDocument.DocumentElement;
            navasBayes.RemoveAll();
            List<GIAODICH> danhSachGiaoDichTheoDongLaptop;
            XmlNode dongLapTop;
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

                try
                {
                    dongLapTop = xmlDocument.CreateElement("DONGLAPTOP");
                    XmlAttribute maDongLapTop = xmlDocument.CreateAttribute("ID");
                    maDongLapTop.Value = danhSachDongLaptop[i].MaDongLapTop.ToString();
                    dongLapTop.Attributes.Append(maDongLapTop);
                }
                catch (XmlException xmlEx)
                {
                    throw xmlEx;
                }

                List<float> DanhSachTyLeTheoNgheNghiep = this.TinhTyLeTheoNgheNghiep(danhSachDongLaptop[i], danhSachGiaoDichTheoDongLaptop);
                this.LuuVaoXmlFile(dongLapTop, DanhSachTyLeTheoNgheNghiep, "NGHE_NGHIEP");

                List<float> DanhSachTyLeTheoMucDichSuDung = this.TinhTyLeTheoMucDichSuDung(danhSachDongLaptop[i], danhSachGiaoDichTheoDongLaptop);
                this.LuuVaoXmlFile(dongLapTop, DanhSachTyLeTheoMucDichSuDung, "MUC_DICH_SU_DUNG");

                List<float> DanhSachTyLeTheoDoTuoi = this.TinhTyLeTheoDoTuoi(danhSachDongLaptop[i], danhSachGiaoDichTheoDongLaptop);
                this.LuuVaoXmlFile(dongLapTop, DanhSachTyLeTheoDoTuoi, "DO_TUOI");

                List<float> DanhSachTyLeTheoTinhThanh = this.TinhTyLeTheoTinhThanh(danhSachDongLaptop[i], danhSachGiaoDichTheoDongLaptop);
                this.LuuVaoXmlFile(dongLapTop, DanhSachTyLeTheoTinhThanh, "TINH_THANH");

                List<float> DanhSachTyLeTheoGioiTinh = this.TinhTyLeTheoGioiTinh(danhSachDongLaptop[i], danhSachGiaoDichTheoDongLaptop);
                this.LuuVaoXmlFile(dongLapTop, DanhSachTyLeTheoGioiTinh, "GIOI_TINH");

                navasBayes.AppendChild(dongLapTop);
            }

            this.SaveFileXML(xmlDocument,"ResultAnalyseData.xml");
        }

        /// <summary>
        /// Sắp xếp list MyStruct
        /// Đầu vào là một list phần tử kiểu MyStruct
        /// </summary>
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
                    if (listSanPham[i].gt < listSanPham[j].gt)
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
        /// <returns>
        ///     Thành công: trả về List MyStruct chứa ID của các laptop được chọn
        ///     Thất bại: throw một Exception ra màn hình
        /// </returns>
        public List<MyStruct> ThuatToanNaiveBayes(
            int IDNgheNghiep,
            int IDGioiTinh,
            int IDDoTuoi,
            int IDTinhThanh,
            int IDMucDich,
            int IDMucGia)
        {
            List<string> listXPath = new List<string>();
            List<XmlNodeList> listXmlNodeList = new List<XmlNodeList>();
            List<MyStruct> listMyStruct = new List<MyStruct>();
            List<MyStruct> listSanPhamDatYeuCau = new List<MyStruct>();

            try
            {
                listXPath = KhoiTaoXPath(IDNgheNghiep, IDGioiTinh, IDDoTuoi, IDTinhThanh, IDMucDich);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            listXmlNodeList = LayDuLieuTuFileXML(listXPath[0], listXPath[1], listXPath[2], listXPath[3], listXPath[4], "ResultAnalyseData.xml");
            listMyStruct = ThuaNhanNaives(listXmlNodeList[0], listXmlNodeList[1], listXmlNodeList[2], listXmlNodeList[3], listXmlNodeList[4]);
            
            try
            {
                listMyStruct = KiemTraHopLe(listMyStruct, IDMucGia);
                if (listMyStruct.Count > 0)
                {
                    listMyStruct = SapXep(listMyStruct);
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
        /// <returns>
        ///     Thành công: trả về List MyStruct chứa ID của các laptop hợp lệ
        ///     Thất bại: throw một Exception ra màn hình
        /// </returns>
        public List<MyStruct> KiemTraHopLe(List<MyStruct> listSanPham, int IDMucGia)
        {
            List<MyStruct> listSanPhamDatYeuCau = new List<MyStruct>();

            for (int i = 0; i < listSanPham.Count; i++)
            {
                try
                {
                    bool isHopLe = myChiTietDongLaptopBUS.KiemTraGiaTienHopLe(listSanPham[i].id + 1, IDMucGia);
                    if (isHopLe == true)
                        if (myChiTietDongLaptopBUS.KiemTraSanPhamTonTai(listSanPham[i].id + 1) == false)
                        {
                            listSanPhamDatYeuCau.Add(listSanPham[i]);
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
        /// <returns>
        ///     Thành công: trả về List MyStruct chứa ID của các laptop được chọn
        ///     Thất bại: throw một Exception ra màn hình
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
                        ketQua = (double.Parse(nodeListTinhThanh[i].InnerText));
                    if (nodeListNgheNghiep[i].InnerText != null)
                        ketQua *= (double.Parse(nodeListNgheNghiep[i].InnerText));
                    if (nodeListMucDich[i].InnerText != null)
                        ketQua *= (double.Parse(nodeListMucDich[i].InnerText));
                    if (nodeListGioiTinh[i].InnerText != null)
                        ketQua *= (double.Parse(nodeListGioiTinh[i].InnerText));
                    if (nodeListDoTuoi[i].InnerText != null)
                        ketQua *= (double.Parse(nodeListDoTuoi[i].InnerText));
                    MyStruct myStruct = new MyStruct();
                    myStruct.gt = ketQua;
                    myStruct.id = i;
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
        /// <returns>
        ///     Thành công: trả về List XmlNodeList
        ///     Thất bại: throw một Exception ra màn hình
        /// </returns>
        public List<XmlNodeList> LayDuLieuTuFileXML(
            string xPathNgheNghiep,
            string xPathGioiTinh,
            string xPathDoTuoi,
            string xPathTinhThanh,
            string xPathMucDich,
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

            string xPath = xPathNgheNghiep;
            List<XmlNodeList> listNodeList = new List<XmlNodeList>();

            try
            {
                XmlNodeList nodeListNgheNghiep = xmlDoc.SelectNodes(xPath);
                xPath = xPathDoTuoi;
                XmlNodeList nodeListDoTuoi = xmlDoc.SelectNodes(xPath);
                xPath = xPathGioiTinh;
                XmlNodeList nodeListGioiTinh = xmlDoc.SelectNodes(xPath);
                xPath = xPathMucDich;
                XmlNodeList nodeListMucDich = xmlDoc.SelectNodes(xPath);
                xPath = xPathTinhThanh;
                XmlNodeList nodeListTinhThanh = xmlDoc.SelectNodes(xPath);
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
        /// Khởi tạo XPatch truy xuất file xml
        /// </summary>
        /// <returns>
        ///     Thành công: trả về List MyStruct chứa ID của các laptop được chọn
        ///     Thất bại: throw một Exception ra màn hình
        /// </returns>
        public List<string> KhoiTaoXPath(int IDNgheNghiep, int IDGioiTinh, int IDDoTuoi, int IDTinhThanh, int IDMucDich)
        {
            List<string> listXPath = new List<string>();

            try
            {
                string xPathNgheNghiep = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_NGHE_NGHIEP/NGHE_NGHIEP/@TyLeGiaoDich[../@ID='" + IDNgheNghiep.ToString() + "']";
                string xPathGioiTinh = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_GIOI_TINH/GIOI_TINH/@TyLeGiaoDich[../@ID='" + IDGioiTinh.ToString() + "']";
                string xPathDoTuoi = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_DO_TUOI/DO_TUOI/@TyLeGiaoDich[../@ID='" + IDDoTuoi.ToString() + "']";
                string xPathTinhThanh = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_TINH_THANH/TINH_THANH/@TyLeGiaoDich[../@ID='" + IDTinhThanh.ToString() + "']";
                string xPathMucDich = "/NAVAS_BAYES/DONGLAPTOP/TY_LE_THEO_MUC_DICH_SU_DUNG/MUC_DICH_SU_DUNG/@TyLeGiaoDich[../@ID='" + IDMucDich.ToString() + "']";
                listXPath.Add(xPathDoTuoi);
                listXPath.Add(xPathGioiTinh);
                listXPath.Add(xPathMucDich);
                listXPath.Add(xPathNgheNghiep);
                listXPath.Add(xPathTinhThanh);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listXPath;
        }
    }
}
