using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myKhachHangDAO
    {
        private EStoreDataContext m_eStoreDataContext = new EStoreDataContext();
        /// <summary>
        /// Ham lay danh sach khach hang tu co so du lieu
        /// </summary>
        /// <returns></returns>
        public List<myKhachHang> LayDanhSachKhachHang()
        {
            List<myKhachHang> danhSachKhachHang = new List<myKhachHang>();

            foreach (KHACHHANG khachHang_DAO in m_eStoreDataContext.KHACHHANGs)
            {
                myKhachHang khachHang_DTO = new myKhachHang();
                khachHang_DTO.STenKhachHang = khachHang_DAO.TenKhachHang;
                khachHang_DTO.SNgaySinh = khachHang_DAO.NgaySinh.ToShortDateString();
                khachHang_DTO.SGioiTinh = khachHang_DAO.GioiTinh;
                khachHang_DTO.SCMND = khachHang_DAO.CMND;
                khachHang_DTO.SDiaChi = khachHang_DAO.DiaChi;
                khachHang_DTO.SEmail = khachHang_DAO.Email;
                khachHang_DTO.SSoDienThoai = khachHang_DAO.SoDienThoai;
                danhSachKhachHang.Add(khachHang_DTO);
            }
            return danhSachKhachHang;
        }

        //public myKhachHang LayDanhSachKhachHangTheoMa(int _maKhachHang)
        //{
        //    myKhachHang khachHangDTO = new myKhachHang();
        //    KHACHHANG khacHang = m_eStoreDataContext.KHACHHANGs.Single(item => item.MaKhachHang == _maKhachHang);


        //    khachHangDTO.STenKhachHang = khacHang.TenKhachHang;
        //    khachHangDTO.SNgaySinh = khacHang.NgaySinh.ToShortDateString();
        //    khachHangDTO.SGioiTinh = khacHang.GioiTinh;
        //    khachHangDTO.SCMND = khacHang.CMND;
        //    khachHangDTO.SDiaChi = khacHang.DiaChi;
        //    khachHangDTO.SEmail = khacHang.Email;
        //    khachHangDTO.SSoDienThoai = khacHang.SoDienThoai;


        //    return khachHangDTO;
        //}
        /// <summary>
        /// Ham dua thong tin khach hang vao co so du lieu
        /// </summary>
        /// <param name="_thongTinKhachHang"></param>
        /// <returns></returns>
        public bool ThemKhachHang(myKhachHang _thongTinKhachHang)
        {
            KHACHHANG khachHang_DAO = new KHACHHANG();
            khachHang_DAO.TenKhachHang = _thongTinKhachHang.STenKhachHang;
            khachHang_DAO.NgaySinh = (DateTime)Convert.ToDateTime(_thongTinKhachHang.SNgaySinh);
            khachHang_DAO.CMND = _thongTinKhachHang.SCMND;
            khachHang_DAO.GioiTinh = _thongTinKhachHang.SGioiTinh;
            khachHang_DAO.DiaChi = _thongTinKhachHang.SDiaChi;
            khachHang_DAO.Email = _thongTinKhachHang.SEmail;
            khachHang_DAO.SoDienThoai = _thongTinKhachHang.SSoDienThoai;

            try
            {
                m_eStoreDataContext.KHACHHANGs.InsertOnSubmit(khachHang_DAO);
            }
            catch
            {
                return false;
            }
            finally
            {
                m_eStoreDataContext.SubmitChanges();
            }

            return true;
        }

        

        public bool XoaKhachHangTheoCMND(string cmnd)
        {
            bool _ketqua = true;
            
            try
            {
                KHACHHANG khacHang = m_eStoreDataContext.KHACHHANGs.Single(p => p.CMND == cmnd);
                m_eStoreDataContext.KHACHHANGs.DeleteOnSubmit(khacHang);
                m_eStoreDataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                _ketqua = false;
            }

            return _ketqua;
        }
    }
}
