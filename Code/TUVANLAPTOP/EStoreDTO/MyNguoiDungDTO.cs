using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class MyNguoiDungDTO
    {
        string tenDangNhap;

        public string TenDangNhap
        {
            get { return this.tenDangNhap; }
            set { this.tenDangNhap = value; }
        }

        string matKhau;

        public string MatKhau
        {
            get { return this.matKhau; }
            set { this.matKhau = value; }
        }
    }
}
