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
                var query = from dongLaptop in storeDataContext.CHITIETDONGLAPTOPs where dongLaptop.MaDongLapTop == intMaChiTietDongLaptop select dongLaptop;
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

 
        public static List<myChiTietDongLaptopDTO> LayChiTietDongLaptopMoiNhat(myChiTietDongLaptopDTO donglaptop)
        {
            List<myChiTietDongLaptopDTO> danhsachChiTietDongLapTop = new List<myChiTietDongLaptopDTO>();
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
                //Chi tiet dong Laptop
                #region ChiTietDongLapTop
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
                #endregion

                danhsachChiTietDongLapTop.Add(dongLapTop);
            }
            return danhsachChiTietDongLapTop;
        }

        /// <summary>
        /// Thêm một dòng LapTop mới
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        static public void ThemMoiChiTietDongLaptop(CHITIETDONGLAPTOP dongLaptopMoi)
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
        /// Cập nhật thông tin một dòng Laptop
        /// </summary>
        /// <param name="dongLaptopMoi"></param>
        static public void CapNhatChiTietDongLaptop(CHITIETDONGLAPTOP dongLaptopMoi)
        {
            try
            {
                CHITIETDONGLAPTOP laptop = storeDataContext.CHITIETDONGLAPTOPs.Single(p => p.MaDongLapTop == dongLaptopMoi.MaDongLapTop);

                //Update TenLapTop
                laptop.TenChiTietDongLapTop = dongLaptopMoi.TenChiTietDongLapTop;
                //Update Ram
                CHITIETDONGRAM ram = storeDataContext.CHITIETDONGRAMs.Single(p => p.MaDongRAM == dongLaptopMoi.MaDongRAM);
                laptop.CHITIETDONGRAM = ram;
                // Update CPU
                CHITIETDONGCPU cpu = storeDataContext.CHITIETDONGCPUs.Single(p => p.MaDongCPU == dongLaptopMoi.MaDongCPU);
                laptop.CHITIETDONGCPU = cpu;
                //Update OCung
                CHITIETDONGOCUNG ocung = storeDataContext.CHITIETDONGOCUNGs.Single(p => p.MaDongOCung == dongLaptopMoi.MaDongOCung);
                laptop.CHITIETDONGOCUNG = ocung;
                //Update Man Hinh
                CHITIETDONGMANHINH manhinh = storeDataContext.CHITIETDONGMANHINHs.Single(p => p.MaDongManHinh == dongLaptopMoi.MaDongManHinh);
                laptop.CHITIETDONGMANHINH = manhinh;
                //Update Card màn hình
                CHITIETDONGCARDDOHOA dohoa = storeDataContext.CHITIETDONGCARDDOHOAs.Single(p => p.MaDongCardDoHoa == dongLaptopMoi.MaDongCardDoHoa);
                laptop.CHITIETDONGCARDDOHOA = dohoa;
                // Update Loa
                CHITIETDONGLOA loa = storeDataContext.CHITIETDONGLOAs.Single(p => p.MaDongLoa == dongLaptopMoi.MaDongLoa);
                laptop.CHITIETDONGLOA = loa;
                // Update O Dia Quang
                CHITIETDONGODIAQUANG oquang = storeDataContext.CHITIETDONGODIAQUANGs.Single(p => p.MaDongODiaQuang == dongLaptopMoi.MaDongODiaQuang);
                laptop.CHITIETDONGODIAQUANG = oquang;
                //Update HDH
                HEDIEUHANH hdh = storeDataContext.HEDIEUHANHs.Single(p => p.MaHeDieuHanh == dongLaptopMoi.MaHeDieuHanh);
                laptop.HEDIEUHANH = hdh;
                //Update Tronluong
                CHITIETTRONGLUONG trongluong = storeDataContext.CHITIETTRONGLUONGs.Single(p => p.MaChiTietTrongLuong == dongLaptopMoi.MaChiTietTrongLuong);
                laptop.CHITIETTRONGLUONG = trongluong;
                //Update MauSac
                laptop.MauSac = dongLaptopMoi.MauSac;
                //Update Card Mang
                CHITIETDONGCARDMANG cardmang = storeDataContext.CHITIETDONGCARDMANGs.Single(p => p.MaDongCardMang == dongLaptopMoi.MaDongCardMang);
                laptop.CHITIETDONGCARDMANG = cardmang;
                //Update CardReader
                CHITIETDONGCARDREADER cardreader = storeDataContext.CHITIETDONGCARDREADERs.Single(p => p.MaDongCardReader == dongLaptopMoi.MaDongCardReader);
                laptop.CHITIETDONGCARDREADER = cardreader;
                //Update Webcam
                CHITIETDONGWEBCAM webcam = storeDataContext.CHITIETDONGWEBCAMs.Single(p => p.MaDongWebCam == dongLaptopMoi.MaDongWebCam);
                laptop.CHITIETDONGWEBCAM = webcam;
                //Update Pin
                CHITIETDONGPIN pin = storeDataContext.CHITIETDONGPINs.Single(p => p.MaDongPin == dongLaptopMoi.MaDongPin);
                laptop.CHITIETDONGPIN = pin;
                //Update Nhan Dang Van Tay
                laptop.FingerprintReader = dongLaptopMoi.FingerprintReader;
                //Update So cong Usb
                laptop.SoLuongCongUSB = dongLaptopMoi.SoLuongCongUSB;
                //Update HDMI
                laptop.HDMI = dongLaptopMoi.HDMI;
                //Update NhaSx
                NHASANXUAT nhasx = storeDataContext.NHASANXUATs.Single(p => p.MaNhaSanXuat == dongLaptopMoi.MaNhaSanXuat);
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

                storeDataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
