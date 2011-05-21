using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.SqlClient;
using EStoreDTO;

namespace EStoreDAO
{

    public class myChiTietDongLaptopDAO
    {
        private static DataClasses1DataContext storeDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy thông tin laptop dựa vào mã laptop
        /// </summary>
        /// <param name="_iMaChiTietDongLaptop">Mã Laptop cần lấy thông tin</param>
        /// <returns>
        ///     Thành công: đối tượng ChiTietDongLaptop DTO với đầy đủ thông tin
        ///     Thất bại: throw một Exception cho tầng trên xử lý
        /// </returns>
        public static myChiTietDongLaptopDTO LayChiTietDongLaptop(int intMaChiTietDongLaptop)
        {
            myChiTietDongLaptopDTO chiTietDongLaptop = null;
            try
            {
                var query = from dongLaptop in storeDataContext.CHITIETDONGLAPTOPs 
                            where dongLaptop.MaDongLapTop == intMaChiTietDongLaptop 
                            select dongLaptop;
                if (query.Count() > 0)
                {
                    CHITIETDONGLAPTOP temp = query.Single();
                    chiTietDongLaptop = new myChiTietDongLaptopDTO();

                    //Ma laptop:
                    chiTietDongLaptop.IMaDongLaptop = temp.MaDongLapTop;

                    //FingerprintReader:
                    chiTietDongLaptop.BFingerprintReader = BitConverter.GetBytes(temp.FingerprintReader.Value)[0];

                    //BHDMI:
                    chiTietDongLaptop.BHDMI = BitConverter.GetBytes(temp.HDMI.Value)[0];

                    //RAM:
                    chiTietDongLaptop.ChiTietDongRam = myChiTietDongRamDAO.LayChiTietDongRam(temp.CHITIETDONGRAM.MaDongRAM);

                    //CardDoHoa:
                    chiTietDongLaptop.ChiTietDongCacDoHoa = myChiTietDongCardDoHoaDAO.LayChiTietDongCardDoHoa(temp.CHITIETDONGCARDDOHOA.MaDongCardDoHoa);

                    //Card Mang:
                    chiTietDongLaptop.ChiTietDongCardMang = myChiTietDongCardMangDAO.LayChiTietDongCardMang(temp.CHITIETDONGCARDMANG.MaDongCardMang);

                    //Card Reader:
                    chiTietDongLaptop.ChiTietDongCardReader = myChiTietDongCardReaderDAO.LayChiTietDongCardReader(temp.CHITIETDONGCARDREADER.MaDongCardReader);

                    //CPU:
                    chiTietDongLaptop.ChiTietDongCPU = myChiTietDongCPUDAO.LayChiTietDongCPU(temp.CHITIETDONGCPU.MaDongCPU);

                    //Loa:
                    chiTietDongLaptop.ChiTietDongLoa = myChiTietDongLoaDAO.LayChiTietDongLoa(temp.CHITIETDONGLOA.MaDongLoa);

                    //Man hinh:
                    chiTietDongLaptop.ChiTietDongManHinh = myChiTietDongManHinhDAO.LayChiTietDongManHinh(temp.CHITIETDONGMANHINH.MaDongManHinh);

                    //O cung:
                    chiTietDongLaptop.ChiTietDongOCung = myChiTietDongOCungDAO.LayChiTietDongOCung(temp.CHITIETDONGOCUNG.MaDongOCung);

                    //O quang:
                    chiTietDongLaptop.ChiTietDongODiaQuang = myChiTietDongODiaQuangDAO.LayChiTietDongODiaQuang(temp.CHITIETDONGODIAQUANG.MaDongODiaQuang);

                    //Pin:
                    chiTietDongLaptop.ChiTietDongPin = myChiTietDongPinDAO.LayChiTietDongPin(temp.CHITIETDONGPIN.MaDongPin);

                    //WebCam:
                    chiTietDongLaptop.ChiTietDongWebCam = myChiTietDongWebcamDAO.LayChiTietDongWebcam(temp.CHITIETDONGWEBCAM.MaDongWebCam);

                    //He dieu hanh:
                    chiTietDongLaptop.ChiTietHeDieuHanh = myChiTietHeDieuHanhDAO.LayChiTietHDH(temp.HEDIEUHANH.CHITIETHEDIEUHANH.MaChiTietHeDieuHanh);

                    //Danh gia:
                    chiTietDongLaptop.DanhGia = myDanhGiaDAO.LayDanhGia(temp.DANHGIA.MaDanhGia);

                    //Nha SX:
                    chiTietDongLaptop.NhaSanXuat = new myNhaSanXuatDTO(temp.NHASANXUAT.TenNhaSanXuat);

                    //Hinh anh:
                    chiTietDongLaptop.SHinhAnh = temp.HinhAnh;

                    //Mau sac:
                    chiTietDongLaptop.SMauSac = temp.MauSac;

                    //Mo ta them:
                    chiTietDongLaptop.SMoTaThem = temp.MoTaThem;

                    //Ten laptop:
                    chiTietDongLaptop.STenChiTietDongLapTop = temp.TenChiTietDongLapTop;

                    //Gia:
                    chiTietDongLaptop.FGiaBanHienHanh = (float)temp.GiaBanHienHanh.Value;

                    //So luong cong USB:
                    chiTietDongLaptop.ISoLuongCongUSB = temp.SoLuongCongUSB.Value;

                    //So luong Nhap:
                    chiTietDongLaptop.ISoLuongNhap = temp.SoLuongNhap.Value;

                    // Ngay Nhap

                    chiTietDongLaptop.DNgayNhap = temp.NgayNhap.Value;

                    //So luong con lai
                    chiTietDongLaptop.ISoLuongConLai = temp.SoLuongConLai.Value;

                    //Thoi gian bao hanh:
                    chiTietDongLaptop.IThoiGianBaoHanh = temp.ThoiGianBaoHanh.Value;

                    //Trong luong:
                    chiTietDongLaptop.ChiTietTrongLuong = myChiTietTrongLuongDAO.LayChiTietTrongLuong(temp.CHITIETTRONGLUONG.MaChiTietTrongLuong);

                    //Da xoa hay chua:
                    chiTietDongLaptop.BDeleted = Convert.ToBoolean(temp.Deleted);
                }

                //Giá trị trả về có thể NULL, nên kiểm tra trước khi dùng:
                return chiTietDongLaptop;
            }
            catch (SqlException sqlex)
            {
                throw new Exception("Lỗi lấy thông tin dòng Laptop : không thể kết nối với CSDL. Xem lại kết nối và thử lại !", sqlex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy danh sách các laptop với đầy đủ thông tin chi tiết
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách các ChiTietDongLapTopDTO với thông tin chi tiết.
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public static List<myChiTietDongLaptopDTO> LayDanhSachChiTietDongLaptop()
        {
            try
            {
                var Query = from dongLaptop in storeDataContext.CHITIETDONGLAPTOPs select dongLaptop.MaDongLapTop;
                List<int> iDChiTietLaptops = new List<int>();
                foreach (int idDongLaptop in Query)
                {
                    iDChiTietLaptops.Add(idDongLaptop);
                }
                List<myChiTietDongLaptopDTO> danhSachChiTietDongLapTop = new List<myChiTietDongLaptopDTO>();
                foreach (int iDChiTietDongLaptop in iDChiTietLaptops)
                {
                    myChiTietDongLaptopDTO temp = myChiTietDongLaptopDAO.LayChiTietDongLaptop(iDChiTietDongLaptop);
                    danhSachChiTietDongLapTop.Add(temp);
                }

                return danhSachChiTietDongLapTop;
            }
            catch (SqlException sqlex)
            {
                throw new Exception("Lỗi lấy thông tin tất cả dòng Laptop : không thể kết nối với CSDL. Xem lại kết nối và thử lại !", sqlex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy dánh sách các laptop với đầy đủ thông tin
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách các CHITIETDONGLAPTOP với thông tin chi tiết.
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public static List<CHITIETDONGLAPTOP> LayTatCaChiTietDongLaptop()
        {
            try
            {
                List<CHITIETDONGLAPTOP> Result = new List<CHITIETDONGLAPTOP>();
                var Query = from dongLaptop in storeDataContext.CHITIETDONGLAPTOPs select dongLaptop;

                foreach (CHITIETDONGLAPTOP laptop in Query)
                {
                    Result.Add(laptop);
                }

                return Result;
            }
            catch (SqlException sqlex)
            {
                throw new Exception("Lỗi lấy thông tin tất cả dòng Laptop : không thể kết nối với CSDL. Xem lại kết nối và thử lại !", sqlex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tra cứu thông tin các laptop thỏa yêu cầu của người dùng
        /// </summary>
        /// <param name="infoCombobox">Thông tin tiêu chí tra cứu của người dùng</param>
        /// <returns></returns>
        public List<myChiTietDongLaptopDTO> TraCuu(InfoComboboxOfFormTraCuu infoCombobox)
        {
            try
            {
                List<myChiTietDongLaptopDTO> danhsachChiTietDongLapTop = new List<myChiTietDongLaptopDTO>();
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                int flag = 0;
                string sql = "select * from ChiTietDongLapTop where ";

                if (string.Compare(infoCombobox.STendongLapTop, null) != 0)
                {
                    sql += "TenChiTietDongLapTop=N'" + infoCombobox.STendongLapTop + "' ";
                    flag = 1;
                }
                if (string.Compare(infoCombobox.SRam, null) != 0)
                {
                    int maDongRam = myChiTietDongRamDAO.LayMaDongRam(infoCombobox.SRam);
                    if (flag == 0)
                    {
                        sql += "MaDongRam=" + maDongRam.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongRam=" + maDongRam.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SCPU, null) != 0)
                {
                    int maDongCPU = myChiTietDongCPUDAO.LayMaDongCPU(infoCombobox.SCPU);
                    if (flag == 0)
                    {
                        sql += "MaDongCPU=" + maDongCPU.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongCPU=" + maDongCPU.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SOCung, null) != 0)
                {
                    int maDong = myChiTietDongOCungDAO.LayMaDongOCung(infoCombobox.SOCung);
                    if (flag == 0)
                    {
                        sql += "MaDongOCung=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongOCung=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SManHinh, null) != 0)
                {
                    int maDong = myChiTietDongManHinhDAO.LayMaDongManHinh(infoCombobox.SManHinh);
                    if (flag == 0)
                    {
                        sql += "MaDongManHinh=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongManHinh=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SCardManHinh, null) != 0)
                {
                    int maDong = myChiTietDongCardDoHoaDAO.LayMaDongCardDoHoa(infoCombobox.SCardManHinh);
                    if (flag == 0)
                    {
                        sql += "MaDongCardDoHoa=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongCardDoHoa=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SDongLoa, null) != 0)
                {
                    int maDong = myChiTietDongLoaDAO.LayMaDongLoa(infoCombobox.SDongLoa);
                    if (flag == 0)
                    {
                        sql += "MaDongLoa=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongLoa=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SOQuang, null) != 0)
                {
                    int maDong = myChiTietDongODiaQuangDAO.LayMaDongODiaQuang(infoCombobox.SOQuang);
                    if (flag == 0)
                    {
                        sql += "MaDongODiaQuang=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongODiaQuang=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SCardMang, null) != 0)
                {
                    int maDong = myChiTietDongCardMangDAO.LayMaDongCardMang(infoCombobox.SCardMang);
                    if (flag == 0)
                    {
                        sql += "MaDongCardMang=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongCardMang=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SCardReader, null) != 0)
                {
                    int maDong = myChiTietDongCardReaderDAO.LayMaDongCardReader(infoCombobox.SCardReader);
                    if (flag == 0)
                    {
                        sql += "MaDongCardReader=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongCardReader=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SWebCam, null) != 0)
                {
                    int maDong = myChiTietDongWebcamDAO.LayMaDongWebCam(infoCombobox.SWebCam);
                    if (flag == 0)
                    {
                        sql += "MaDongWebCam=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongWebCam=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SPin, null) != 0)
                {
                    int maDong = myChiTietDongPinDAO.LayMaDongPin(infoCombobox.SPin);
                    if (flag == 0)
                    {
                        sql += "MaDongPin=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaDongPin=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SHeDieuHanh, null) != 0)
                {
                    int maDong = myChiTietHeDieuHanhDAO.LayMaDongHeDieuHanh(infoCombobox.SHeDieuHanh);
                    if (flag == 0)
                    {
                        sql += "MaHeDieuHanh=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaHeDieuHanh=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SNhaSanXuat, null) != 0)
                {
                    int maDong = myNhaSanXuatDAO.LayMaNhaSanXuat(infoCombobox.SNhaSanXuat);
                    if (flag == 0)
                    {
                        sql += "MaNhaSanXuat=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaNhaSanXuat=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }

                if (infoCombobox.FTrongLuong != 0)
                {
                    int maDong = myChiTietTrongLuongDAO.LayMaChiTietTrongLuong(infoCombobox.FTrongLuong);
                    if (flag == 0)
                    {
                        sql += "MaChiTietTrongLuong=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MaChiTietTrongLuong=" + maDong.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SMauSac, null) != 0)
                {
                    if (flag == 0)
                    {
                        sql += "MauSac=N'" + infoCombobox.SMauSac + "' ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and MauSac=N'" + infoCombobox.SMauSac + "' ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SGiaBan, null) != 0)
                {
                    string substr = " triệu đồng";
                    string temp = ConvertString(infoCombobox.SGiaBan.Substring(0, infoCombobox.SGiaBan.Length - substr.Length));
                    if (flag == 0)
                    {
                        sql += "GiaBanHienHanh=" + temp + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and GiaBanHienHanh=" + temp + " ";
                        flag = 1;
                    }
                }
                if (infoCombobox.ISoCongUSB != 0)
                {
                    if (flag == 0)
                    {
                        sql += "SoLuongCongUSB=" + infoCombobox.ISoCongUSB.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and SoLuongCongUSB=" + infoCombobox.ISoCongUSB.ToString() + " ";
                        flag = 1;
                    }
                }
                if (infoCombobox.IThoigianBH != 0)
                {
                    if (flag == 0)
                    {
                        sql += "ThoiGianBaoHanh=" + infoCombobox.IThoigianBH.ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and ThoiGianBaoHanh=" + infoCombobox.IThoigianBH.ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SCongHDMI, null) != 0)
                {
                    bool kq;
                    if (string.Compare(infoCombobox.SCongHDMI, "Có") == 0)
                    {
                        kq = true;
                    }
                    else
                    {
                        kq = false;
                    }

                    if (flag == 0)
                    {
                        sql += "HDMI=" + BitConverter.GetBytes(kq)[0].ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and HDMI=" + BitConverter.GetBytes(kq)[0].ToString() + " ";
                        flag = 1;
                    }
                }
                if (string.Compare(infoCombobox.SNhanDangVanTay, null) != 0)
                {
                    bool kq;
                    if (string.Compare(infoCombobox.SNhanDangVanTay, "Có") == 0)
                    {
                        kq = true;
                    }
                    else
                    {
                        kq = false;
                    }

                    if (flag == 0)
                    {
                        sql += "FingerprintReader=" + BitConverter.GetBytes(kq)[0].ToString() + " ";
                        flag = 1;
                    }
                    else if (flag == 1)
                    {
                        sql += "and FingerprintReader=" + BitConverter.GetBytes(kq)[0].ToString() + " ";
                        flag = 1;
                    }
                }
                var query = m_EStore.ExecuteQuery<CHITIETDONGLAPTOP>(sql);

                if (query == null)
                    return null;
                foreach (CHITIETDONGLAPTOP laptop in query)
                {
                    //Chi tiet dong Laptop
                    #region ChiTietDongLapTop
                    myChiTietDongLaptopDTO dongLapTop = new myChiTietDongLaptopDTO();
                    dongLapTop.STenChiTietDongLapTop = laptop.TenChiTietDongLapTop;
                    dongLapTop.SMauSac = laptop.MauSac;
                    dongLapTop.IThoiGianBaoHanh = (int)laptop.ThoiGianBaoHanh;
                    dongLapTop.FGiaBanHienHanh = (float)laptop.GiaBanHienHanh;
                    dongLapTop.ChiTietDongRam = myChiTietDongRamDAO.LayChiTietDongRam((int)laptop.MaDongRAM);
                    dongLapTop.ChiTietDongOCung = myChiTietDongOCungDAO.LayChiTietDongOCung((int)laptop.MaDongOCung);
                    dongLapTop.ChiTietDongCacDoHoa = myChiTietDongCardDoHoaDAO.LayChiTietDongCardDoHoa((int)laptop.MaDongCardDoHoa);
                    dongLapTop.ChiTietDongCardMang = myChiTietDongCardMangDAO.LayChiTietDongCardMang((int)laptop.MaDongCardMang);
                    dongLapTop.ChiTietDongCPU = myChiTietDongCPUDAO.LayChiTietDongCPU((int)laptop.MaDongCPU);
                    dongLapTop.ChiTietDongCardReader = myChiTietDongCardReaderDAO.LayChiTietDongCardReader((int)laptop.MaDongCardReader);
                    dongLapTop.ChiTietDongLoa = myChiTietDongLoaDAO.LayChiTietDongLoa((int)laptop.MaDongLoa);
                    dongLapTop.ChiTietDongManHinh = myChiTietDongManHinhDAO.LayChiTietDongManHinh((int)laptop.MaDongManHinh);
                    dongLapTop.ChiTietDongODiaQuang = myChiTietDongODiaQuangDAO.LayChiTietDongODiaQuang((int)laptop.MaDongODiaQuang);
                    dongLapTop.ChiTietDongPin = myChiTietDongPinDAO.LayChiTietDongPin((int)laptop.MaDongPin);
                    dongLapTop.ChiTietDongWebCam = myChiTietDongWebcamDAO.LayChiTietDongWebcam((int)laptop.MaDongWebCam);
                    dongLapTop.ChiTietHeDieuHanh = myChiTietHeDieuHanhDAO.LayChiTietHDH((int)laptop.MaHeDieuHanh);
                    dongLapTop.ChiTietTrongLuong = myChiTietTrongLuongDAO.LayChiTietTrongLuong((int)laptop.MaChiTietTrongLuong);
                    dongLapTop.BFingerprintReader = BitConverter.GetBytes(laptop.FingerprintReader.Value)[0];
                    dongLapTop.BHDMI = BitConverter.GetBytes(laptop.HDMI.Value)[0];
                    dongLapTop.ISoLuongCongUSB = (int)laptop.SoLuongCongUSB;
                    dongLapTop.NhaSanXuat = new myNhaSanXuatDTO(laptop.NHASANXUAT.TenNhaSanXuat);
                    dongLapTop.DanhGia = myDanhGiaDAO.LayDanhGia(laptop.DANHGIA.MaDanhGia);
                    dongLapTop.FGiaBanHienHanh = (float)laptop.GiaBanHienHanh;
                    dongLapTop.SMoTaThem = (string)laptop.MoTaThem;
                    dongLapTop.ISoLuongNhap = (int)laptop.SoLuongNhap;
                    dongLapTop.ISoLuongConLai = (int)laptop.SoLuongConLai;
                    dongLapTop.IThoiGianBaoHanh = (int)laptop.ThoiGianBaoHanh;
                    dongLapTop.SHinhAnh = (string)laptop.HinhAnh;
                    dongLapTop.SMauSac = (string)laptop.MauSac;
                    #endregion

                    danhsachChiTietDongLapTop.Add(dongLapTop);
                }

                return danhsachChiTietDongLapTop;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Chuyễn đổi kiểm dữ liệu của giá bán String sang kiểu float
        /// </summary>
        /// <param name="giaban">thông tin giá bán của sản phẩm</param>
        /// <returns></returns>
        public static string ConvertString(string giaban)
        {
            string temp = "";

            for (int i = 0; i < giaban.Length; i++)
            {
                if (giaban[i] == 44)
                {
                    temp += '.';
                }
                else
                {
                    temp += giaban[i];
                }
            }

            return temp;
        }


        /// <summary>
        /// Xóa một dòng thông tin laptop với thông tin mã laptop
        /// </summary>
        /// <param name="_liMaDongLaptops"> Danh sách mã các dòng laptop cần xóa</param>
        /// <returns> true : thành công ; false : thất bại</returns>
        public static bool CapNhatXoaChiTietDongLaptop(List<int> _liMaDongLaptops)
        {
            try
            {
                for (int iCount = 0; iCount < _liMaDongLaptops.Count; iCount++)
                {
                    CHITIETDONGLAPTOP temp = null;
                    var query = from dongLaptop in storeDataContext.CHITIETDONGLAPTOPs where dongLaptop.MaDongLapTop == _liMaDongLaptops[iCount] select dongLaptop;
                    if (query.Count() > 0)
                    {
                        //Lấy chi tiết dòng laptop
                        temp = query.Single();

                        //Thay đổi trạng thái deleted của laptop
                        temp.Deleted = !temp.Deleted;

                        //Cập nhật lại csdl
                        storeDataContext.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

            return true;
        }

        /// <summary>
        /// Lấy danh sách những Laptop mới nhất
        /// </summary>
        /// <param name="donglaptop">Thông tin dòng laptop cùng loại</param>
        /// <returns>
        ///     Thành công: trả về danh sách dòng laptop mới nhất
        ///     Thất bại: trả về null
        /// </returns>
        public static List<myChiTietDongLaptopDTO> LayChiTietDongLaptopMoiNhat(myChiTietDongLaptopDTO donglaptop)
        {
            List<myChiTietDongLaptopDTO> listChiTietDongLapTop = new List<myChiTietDongLaptopDTO>();
            var query = from mayTinh in storeDataContext.CHITIETDONGLAPTOPs
                        where mayTinh.CHITIETDONGCARDDOHOA.CHITIETBONHOCARDDOHOA.TenChiTietBoNhoCardDoHoa == donglaptop.ChiTietDongCacDoHoa.ChiTietBoNhoCardDoHoa.STenChiTietCardDoHoa
                            && mayTinh.CHITIETDONGCPU.CHITIETCONGNGHECPU.TenChiTietCongNgheCPU == donglaptop.ChiTietDongCPU.ChiTietCongNgheCPU.STenChiTietCongNgheCPU
                            && mayTinh.CHITIETDONGRAM.CHITIETBONHORAM.TenChiTietBoNhoRAM == donglaptop.ChiTietDongRam.ChiTietBoNhoRam.STenChiTietBoNhoRam
                        select mayTinh;
            if (query == null)
                return null;
            foreach (CHITIETDONGLAPTOP laptop in query)
            {
                if (laptop.NgayNhap.Value.Subtract(DateTime.Today).Days <-1000 || laptop.MaDongLapTop == donglaptop.IMaDongLaptop)
                {
                    continue;
                }
                myChiTietDongLaptopDTO chiTietDongLapTop = TaoChiTietLapTop(laptop);
                listChiTietDongLapTop.Add(chiTietDongLapTop);
            }
            return listChiTietDongLapTop;
        }

        /// <summary>
        /// Tạo chi tiết laptop
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách các ChiTietDongLapTopDTO với thông tin chi tiết.
        ///     Thất bại: throw một Exception để tầng trên xử lý.
        /// </returns>
        public static myChiTietDongLaptopDTO TaoChiTietLapTop(CHITIETDONGLAPTOP laptop)
        {
            myChiTietDongLaptopDTO dongLapTop = new myChiTietDongLaptopDTO();
            dongLapTop.STenChiTietDongLapTop = laptop.TenChiTietDongLapTop;
            dongLapTop.SMauSac = laptop.MauSac;
            dongLapTop.IMaDongLaptop = laptop.MaDongLapTop;
            dongLapTop.IThoiGianBaoHanh = (int)laptop.ThoiGianBaoHanh;
            dongLapTop.FGiaBanHienHanh = (float)laptop.GiaBanHienHanh;
            dongLapTop.ChiTietDongRam = myChiTietDongRamDAO.LayChiTietDongRam((int)laptop.MaDongRAM);
            dongLapTop.ChiTietDongOCung = myChiTietDongOCungDAO.LayChiTietDongOCung((int)laptop.MaDongOCung);
            dongLapTop.ChiTietDongCacDoHoa = myChiTietDongCardDoHoaDAO.LayChiTietDongCardDoHoa((int)laptop.MaDongCardDoHoa);
            dongLapTop.ChiTietDongCardMang = myChiTietDongCardMangDAO.LayChiTietDongCardMang((int)laptop.MaDongCardMang);
            dongLapTop.ChiTietDongCPU = myChiTietDongCPUDAO.LayChiTietDongCPU((int)laptop.MaDongCPU);
            dongLapTop.ChiTietDongCardReader = myChiTietDongCardReaderDAO.LayChiTietDongCardReader((int)laptop.MaDongCardReader);
            dongLapTop.ChiTietDongLoa = myChiTietDongLoaDAO.LayChiTietDongLoa((int)laptop.MaDongLoa);
            dongLapTop.ChiTietDongManHinh = myChiTietDongManHinhDAO.LayChiTietDongManHinh((int)laptop.MaDongManHinh);
            dongLapTop.ChiTietDongODiaQuang = myChiTietDongODiaQuangDAO.LayChiTietDongODiaQuang((int)laptop.MaDongODiaQuang);
            dongLapTop.ChiTietDongPin = myChiTietDongPinDAO.LayChiTietDongPin((int)laptop.MaDongPin);
            dongLapTop.ChiTietDongWebCam = myChiTietDongWebcamDAO.LayChiTietDongWebcam((int)laptop.MaDongWebCam);
            dongLapTop.ChiTietHeDieuHanh = myChiTietHeDieuHanhDAO.LayChiTietHDH((int)laptop.MaHeDieuHanh);
            dongLapTop.ChiTietTrongLuong = myChiTietTrongLuongDAO.LayChiTietTrongLuong((int)laptop.MaChiTietTrongLuong);
            dongLapTop.BFingerprintReader = BitConverter.GetBytes(laptop.FingerprintReader.Value)[0];
            dongLapTop.BHDMI = BitConverter.GetBytes(laptop.HDMI.Value)[0];
            dongLapTop.ISoLuongCongUSB = (int)laptop.SoLuongCongUSB;
            dongLapTop.NhaSanXuat = new myNhaSanXuatDTO(laptop.NHASANXUAT.TenNhaSanXuat);
            dongLapTop.DanhGia = myDanhGiaDAO.LayDanhGia(laptop.DANHGIA.MaDanhGia);
            dongLapTop.FGiaBanHienHanh = (float)laptop.GiaBanHienHanh;
            dongLapTop.SMoTaThem = (string)laptop.MoTaThem;
            dongLapTop.ISoLuongNhap = (int)laptop.SoLuongNhap;
            dongLapTop.ISoLuongConLai = (int)laptop.SoLuongConLai;
            dongLapTop.IThoiGianBaoHanh = (int)laptop.ThoiGianBaoHanh;
            dongLapTop.SHinhAnh = (string)laptop.HinhAnh;
            dongLapTop.SMauSac = (string)laptop.MauSac;

            return dongLapTop;
        }

        /// <summary>
        /// Thêm một dòng LapTop mới
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        public static void ThemMoiChiTietDongLaptop(CHITIETDONGLAPTOP dongLaptopMoi)
        {
            try
            {
                storeDataContext.CHITIETDONGLAPTOPs.InsertOnSubmit(dongLaptopMoi);
                storeDataContext.SubmitChanges();
            }
            catch
            {
                throw;
            }
        }



        /// <summary>
        /// Cập nhật tên chi tiết dòng Laptop
        /// 
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>Trả về chi tiết dòng laptop </returns>
        public static CHITIETDONGLAPTOP CapNhatTenChiTietDongLapTop(CHITIETDONGLAPTOP dongLaptopMoi)
        {
            CHITIETDONGLAPTOP laptop;
            try
            {
                laptop = storeDataContext.CHITIETDONGLAPTOPs.Single(p => p.MaDongLapTop == dongLaptopMoi.MaDongLapTop);
                //Update TenLapTop
                laptop.TenChiTietDongLapTop = dongLaptopMoi.TenChiTietDongLapTop;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop;
        }

        /// <summary>
        /// Cập nhật Chi tiết dòng Ram
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>Chi tiết dòng ram</returns>
        public static CHITIETDONGRAM CapNhatChiTietDongRam(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGRAM ram;
            //Update Ram
            try
            {
                ram = storeDataContext.CHITIETDONGRAMs.Single(p => p.MaDongRAM == dongLaptopMoi.MaDongRAM);
                laptop.CHITIETDONGRAM = ram;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return laptop.CHITIETDONGRAM;
        }

        /// <summary>
        /// Cap nhat chi tiet dong CPU
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>Chi tiet dong CPU</returns>
        public static CHITIETDONGCPU CapNhatChiTietDongCPU(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGCPU cpu;
            // Update CPU
            try
            {
                cpu = storeDataContext.CHITIETDONGCPUs.Single(p => p.MaDongCPU == dongLaptopMoi.MaDongCPU);
                laptop.CHITIETDONGCPU = cpu;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.CHITIETDONGCPU;
        }

        /// <summary>
        /// Cap nhat chi tiet dong o cung
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>Chi tiet dong o cung</returns>
        public static CHITIETDONGOCUNG CapNhatChiTietDongOCung(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGOCUNG ocung;
            //Update OCung
            try
            {
                ocung = storeDataContext.CHITIETDONGOCUNGs.Single(p => p.MaDongOCung == dongLaptopMoi.MaDongOCung);
                laptop.CHITIETDONGOCUNG = ocung;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return laptop.CHITIETDONGOCUNG;
        }

        /// <summary>
        /// cap nhat chi tiet dong man hinh
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>chi tiet dong man hinh</returns>
        public static CHITIETDONGMANHINH CapNhatChiTietDongManHinh(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGMANHINH manhinh;
            //Update Man Hinh
            try
            {
                manhinh = storeDataContext.CHITIETDONGMANHINHs.Single(p => p.MaDongManHinh == dongLaptopMoi.MaDongManHinh);
                laptop.CHITIETDONGMANHINH = manhinh;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.CHITIETDONGMANHINH;
        }

        /// <summary>
        /// cap nhat chi tiet dong card man hinh
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>chi tiet card man hinh</returns>
        public static CHITIETDONGCARDDOHOA CapNhatChiTietDongCardDoHoa(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGCARDDOHOA dohoa;
            //Update Card màn hình
            try
            {
                dohoa = storeDataContext.CHITIETDONGCARDDOHOAs.Single(p => p.MaDongCardDoHoa == dongLaptopMoi.MaDongCardDoHoa);
                laptop.CHITIETDONGCARDDOHOA = dohoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.CHITIETDONGCARDDOHOA;
        }

        /// <summary>
        /// cap nha chi tiet dong Loa
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>Chi tiet dong Loa</returns>
        public static CHITIETDONGLOA CapNhatChiTietDongLoa(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGLOA loa;
            // Update Loa
            try
            {
                loa = storeDataContext.CHITIETDONGLOAs.Single(p => p.MaDongLoa == dongLaptopMoi.MaDongLoa);
                laptop.CHITIETDONGLOA = loa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return laptop.CHITIETDONGLOA;
        }

        /// <summary>
        /// cap nhat chi tiet o dia quang
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>chi tiet o dia quuang</returns>
        public static CHITIETDONGODIAQUANG CapNhatChiTietDongODiaQuang(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGODIAQUANG oquang;
            // Update O Dia Quang
            try
            {
                oquang = storeDataContext.CHITIETDONGODIAQUANGs.Single(p => p.MaDongODiaQuang == dongLaptopMoi.MaDongODiaQuang);
                laptop.CHITIETDONGODIAQUANG = oquang;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.CHITIETDONGODIAQUANG;
        }

        /// <summary>
        /// cap nhat he dieu hanh
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>He dieu Hanh</returns>
        public static HEDIEUHANH CapNhatHeDieuHanh(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            HEDIEUHANH hdh;
            //Update HDH
            try
            {
                hdh = storeDataContext.HEDIEUHANHs.Single(p => p.MaHeDieuHanh == dongLaptopMoi.MaHeDieuHanh);
                laptop.HEDIEUHANH = hdh;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.HEDIEUHANH;
        }

        /// <summary>
        /// cap nha chi tiet trong luong
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>Chi tiet trong luong</returns>
        public static CHITIETTRONGLUONG CapNhatChiTietTrongLuong(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETTRONGLUONG trongluong;
            //Update Tronluong
            try
            {
                trongluong = storeDataContext.CHITIETTRONGLUONGs.Single(p => p.MaChiTietTrongLuong == dongLaptopMoi.MaChiTietTrongLuong);
                laptop.CHITIETTRONGLUONG = trongluong;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.CHITIETTRONGLUONG;
        }


        /// <summary>
        /// cap nhat chi tiet dong card mang
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>chi tiet dong card mang</returns>
        public static CHITIETDONGCARDMANG CapNhatChiTietDongCardMang(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGCARDMANG cardmang;
            //Update Card Mang
            try
            {
                cardmang = storeDataContext.CHITIETDONGCARDMANGs.Single(p => p.MaDongCardMang == dongLaptopMoi.MaDongCardMang);
                laptop.CHITIETDONGCARDMANG = cardmang;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.CHITIETDONGCARDMANG;
        }

        /// <summary>
        /// cap nhat chi tiet dong card reader
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>chi tiet don card reader</returns>
        public static CHITIETDONGCARDREADER CapNhatChiTietDongCardReader(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGCARDREADER cardreader;
            //Update CardReader
            try
            {
                cardreader = storeDataContext.CHITIETDONGCARDREADERs.Single(p => p.MaDongCardReader == dongLaptopMoi.MaDongCardReader);
                laptop.CHITIETDONGCARDREADER = cardreader;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.CHITIETDONGCARDREADER;
        }

        /// <summary>
        /// cap nhat chi tiet web cam
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>chi tiet webcame</returns>
        public static CHITIETDONGWEBCAM CapNhatChiTietDongWebCam(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGWEBCAM webcam;
            //Update Webcam
            try
            {

                webcam = storeDataContext.CHITIETDONGWEBCAMs.Single(p => p.MaDongWebCam == dongLaptopMoi.MaDongWebCam);
                laptop.CHITIETDONGWEBCAM = webcam;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.CHITIETDONGWEBCAM;
        }

        /// <summary>
        /// cap nhat chi tiet dong pIn
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>chi tiet dong pin</returns>
        public static CHITIETDONGPIN CapNhatChiTietDongPin(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            CHITIETDONGPIN pin;
            //Update Pin
            try
            {
                pin = storeDataContext.CHITIETDONGPINs.Single(p => p.MaDongPin == dongLaptopMoi.MaDongPin);
                laptop.CHITIETDONGPIN = pin;
                //Update Nhan Dang Van Tay
                laptop.FingerprintReader = dongLaptopMoi.FingerprintReader;
                //Update So cong Usb
                laptop.SoLuongCongUSB = dongLaptopMoi.SoLuongCongUSB;
                //Update HDMI
                laptop.HDMI = dongLaptopMoi.HDMI;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.CHITIETDONGPIN;
        }

        /// <summary>
        /// cap nhat Nha san xuat
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        /// <returns>chi tiet nha san xuat</returns>
        public static NHASANXUAT CapNhatNhaSanXuat(CHITIETDONGLAPTOP dongLaptopMoi, CHITIETDONGLAPTOP laptop)
        {
            NHASANXUAT nhasx;
            //Update NhaSx
            try
            {
                nhasx = storeDataContext.NHASANXUATs.Single(p => p.MaNhaSanXuat == dongLaptopMoi.MaNhaSanXuat);
                laptop.NHASANXUAT = nhasx;
                //Update Thoi Gian Bao Hanh
                laptop.ThoiGianBaoHanh = dongLaptopMoi.ThoiGianBaoHanh;
                //Update GiaBan
                laptop.GiaBanHienHanh = dongLaptopMoi.GiaBanHienHanh;
                //Update So Luong Nhap
                laptop.SoLuongNhap = dongLaptopMoi.SoLuongNhap;
                //Update Ngay Nhap
                laptop.NgayNhap = dongLaptopMoi.NgayNhap;
                //Update Mo Ta Them
                laptop.MoTaThem = dongLaptopMoi.MoTaThem;
                //Update Hinh Anh
                laptop.HinhAnh = dongLaptopMoi.HinhAnh;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return laptop.NHASANXUAT;
        }




        /// <summary>
        /// Cập nhật thông tin một dòng Laptop
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        static public bool CapNhatChiTietDongLaptop(CHITIETDONGLAPTOP dongLaptopMoi)
        {
            bool kq = true;
            try
            {
                CHITIETDONGLAPTOP laptop = CapNhatTenChiTietDongLapTop(dongLaptopMoi);

                //ram
                CapNhatChiTietDongRam(dongLaptopMoi, laptop);
                //cpu
                CapNhatChiTietDongCPU(dongLaptopMoi, laptop);
                //o cung
                CapNhatChiTietDongOCung(dongLaptopMoi, laptop);
                //man hinh
                CapNhatChiTietDongManHinh(dongLaptopMoi, laptop);
                //card man hinh
                CapNhatChiTietDongCardDoHoa(dongLaptopMoi, laptop);
                //loa
                CapNhatChiTietDongLoa(dongLaptopMoi, laptop);
                //o dia quang
                CapNhatChiTietDongODiaQuang(dongLaptopMoi, laptop);
                //he dieu hanh
                CapNhatHeDieuHanh(dongLaptopMoi, laptop);
                //trong luong
                CapNhatChiTietTrongLuong(dongLaptopMoi, laptop);
                //card mang
                CapNhatChiTietDongCardMang(dongLaptopMoi, laptop);
                //card reader
                CapNhatChiTietDongCardReader(dongLaptopMoi, laptop);
                //webcam
                CapNhatChiTietDongWebCam(dongLaptopMoi, laptop);
                //pin
                CapNhatChiTietDongPin(dongLaptopMoi, laptop);
                //nha san xuat
                CapNhatNhaSanXuat(dongLaptopMoi, laptop);

                storeDataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                kq = false;
                //                throw ex;
            }

            return kq;

        }

    }
}
