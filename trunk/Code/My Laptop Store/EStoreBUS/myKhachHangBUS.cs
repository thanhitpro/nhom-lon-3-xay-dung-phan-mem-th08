using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDAO;
using EStoreDTO;

namespace EStoreBUS
{
    public class myKhachHangBUS
    {
        private myKhachHangDAO m_khachHangDAO = new myKhachHangDAO();

        /// <summary>
        /// Ham lay danh sach khach hang tu co so du lieu, goi ham DAO thuc hien
        /// </summary>
        /// <returns></returns>
        public List<myKhachHang> LayDanhSachKhachHang()
        {
            return m_khachHangDAO.LayDanhSachKhachHang();
        }

        /// <summary>
        /// Ham dua thong tin khach hang vao co so du lieu, goi ham DAO thuc hien
        /// </summary>
        /// <param name="_thongTinKhachHang"></param>
        /// <returns></returns>
        public bool ThemKhachHang(myKhachHang _thongTinKhachHang)
        {
            return m_khachHangDAO.ThemKhachHang(_thongTinKhachHang);
        }

        public bool XoaKhachHangTheoCMND(string scmnd)
        {
            return m_khachHangDAO.XoaKhachHangTheoCMND(scmnd);
        }
    }
}
