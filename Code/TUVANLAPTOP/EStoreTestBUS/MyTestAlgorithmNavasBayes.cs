using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using NUnit.Framework;
using EStoreDTO;
using EStoreBUS;
using EStoreDAO;

namespace EStoreTestBUS
{
    [TestFixture]
    class MyTestAlgorithmNavasBayes
    {
        /// <summary>
        /// Đã pass
        /// </summary>
        [Test]
        public void LoadFileXMLTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            XmlDocument xmlDocument = NavasBayes.LoadFileXML("ResultAnalyseData.xml");
            Assert.NotNull(xmlDocument);
        }

        [Test]
        public void SaveFileXMLTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            XmlDocument xmlDocument = NavasBayes.LoadFileXML("ResultAnalyseData.xml");
            bool Actual = NavasBayes.SaveFileXML(xmlDocument, "ResultAnalyseData.xml");
            Assert.IsTrue(Actual);
        }


        [Test]
        public void KiemTraHopLe()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            List<EStoreBUS.MyStruct> listSanPham_Expect = new List<MyStruct>();
            EStoreBUS.MyStruct myStruct1 = new MyStruct();
            myStruct1.Gt = 2.2424;
            myStruct1.Id = 3;
            listSanPham_Expect.Add(myStruct1);
            int IDMucGia = 5;
            List<EStoreBUS.MyStruct> listSanPham_Actual = new List<MyStruct>();
            listSanPham_Actual = NavasBayes.KiemTraHopLe(listSanPham_Expect, IDMucGia);
            Assert.AreEqual(listSanPham_Expect, listSanPham_Actual);
        }

        /// <summary>
        /// Chưa test
        /// </summary>

        [Test]
        public void TinhTyLeTheoNgheNghiepTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();

            GIAODICH giaoDich1 = new GIAODICH();
            giaoDich1.MaDongLaptop = 1;
            KHACHHANG khachhang = new KHACHHANG();
            khachhang.MaKhachHang = 1;
            khachhang.MaNgheNghiep = 1;
            giaoDich1.KHACHHANG = khachhang;
            giaoDich1.MaGiaoDich = 1;
            giaoDich1.MaKhachHang = 1;
            giaoDich1.NgayMua = DateTime.Now;
            List<GIAODICH> DanhSachGiaoDich = new List<GIAODICH>();
            DanhSachGiaoDich.Add(giaoDich1);
            List<float> TyLeGiaoDich_Actual = new List<float>();
            List<float> TyLeGiaoDich_Expect = new List<float>();
            for (int index = 0; index < NavasBayes.DanhSachNgheNghiep.Count; ++index)
            {
                TyLeGiaoDich_Expect.Add(0f);
            }
            TyLeGiaoDich_Expect[0] = 100f;
            try
            {
                TyLeGiaoDich_Actual = NavasBayes.TinhTyLeTheoNgheNghiep(DanhSachGiaoDich);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Assert.AreEqual(TyLeGiaoDich_Expect, TyLeGiaoDich_Actual);
        }

        [Test]
        public void TinhTyLeTheoMucDichSuDungTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();

            GIAODICH giaoDich1 = new GIAODICH();
            giaoDich1.MaDongLaptop = 1;
            KHACHHANG khachhang = new KHACHHANG();
            khachhang.MaKhachHang = 1;
            khachhang.MaMucDichSuDung = 1;
            giaoDich1.KHACHHANG = khachhang;
            giaoDich1.MaGiaoDich = 1;
            giaoDich1.MaKhachHang = 1;
            giaoDich1.NgayMua = DateTime.Now;
            List<GIAODICH> DanhSachGiaoDich = new List<GIAODICH>();
            DanhSachGiaoDich.Add(giaoDich1);
            List<float> TyLeGiaoDich_Actual = new List<float>();
            List<float> TyLeGiaoDich_Expect = new List<float>();
            for (int index = 0; index < NavasBayes.DanhSachMucDichSuDung.Count; ++index)
            {
                TyLeGiaoDich_Expect.Add(0f);
            }
            TyLeGiaoDich_Expect[0] = 100f;
            try
            {
                TyLeGiaoDich_Actual = NavasBayes.TinhTyLeTheoMucDichSuDung(DanhSachGiaoDich);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Assert.AreEqual(TyLeGiaoDich_Expect, TyLeGiaoDich_Actual);
        }

        [Test]
        public void TinhTyLeTheoDoTuoiTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            GIAODICH giaoDich1 = new GIAODICH();
            giaoDich1.MaDongLaptop = 1;
            KHACHHANG khachhang = new KHACHHANG();
            khachhang.MaKhachHang = 1;
            khachhang.MaDoTuoi = 1;
            giaoDich1.KHACHHANG = khachhang;
            giaoDich1.MaGiaoDich = 1;
            giaoDich1.MaKhachHang = 1;
            giaoDich1.NgayMua = DateTime.Now;
            List<GIAODICH> DanhSachGiaoDich = new List<GIAODICH>();
            DanhSachGiaoDich.Add(giaoDich1);
            List<float> TyLeGiaoDich_Actual = new List<float>();
            List<float> TyLeGiaoDich_Expect = new List<float>();
            for (int index = 0; index < NavasBayes.DanhSachDoTuoi.Count; ++index)
            {
                TyLeGiaoDich_Expect.Add(0f);
            }
            TyLeGiaoDich_Expect[0] = 100f;
            try
            {
                TyLeGiaoDich_Actual = NavasBayes.TinhTyLeTheoDoTuoi(DanhSachGiaoDich);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Assert.AreEqual(TyLeGiaoDich_Expect, TyLeGiaoDich_Actual);
        }

        [Test]
        public void TinhTyLeTheoTinhThanhTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            GIAODICH giaoDich1 = new GIAODICH();
            giaoDich1.MaDongLaptop = 1;
            KHACHHANG khachhang = new KHACHHANG();
            khachhang.MaKhachHang = 1;
            khachhang.MaTinhThanh = 1;
            giaoDich1.KHACHHANG = khachhang;
            giaoDich1.MaGiaoDich = 1;
            giaoDich1.MaKhachHang = 1;
            giaoDich1.NgayMua = DateTime.Now;
            List<GIAODICH> DanhSachGiaoDich = new List<GIAODICH>();
            DanhSachGiaoDich.Add(giaoDich1);
            List<float> TyLeGiaoDich_Actual = new List<float>();
            List<float> TyLeGiaoDich_Expect = new List<float>();
            for (int index = 0; index < NavasBayes.DanhSachTinhThanh.Count; ++index)
            {
                TyLeGiaoDich_Expect.Add(0f);
            }
            TyLeGiaoDich_Expect[0] = 100f;
            try
            {
                TyLeGiaoDich_Actual = NavasBayes.TinhTyLeTheoTinhThanh(DanhSachGiaoDich);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Assert.AreEqual(TyLeGiaoDich_Expect, TyLeGiaoDich_Actual);
        }

        [Test]
        public void TinhTyLeTheoGioiTinhTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            GIAODICH giaoDich1 = new GIAODICH();
            giaoDich1.MaDongLaptop = 1;
            KHACHHANG khachhang = new KHACHHANG();
            khachhang.MaKhachHang = 1;
            khachhang.GioiTinhNam = true;
            giaoDich1.KHACHHANG = khachhang;
            giaoDich1.MaGiaoDich = 1;
            giaoDich1.MaKhachHang = 1;
            giaoDich1.NgayMua = DateTime.Now;
            List<GIAODICH> DanhSachGiaoDich = new List<GIAODICH>();
            DanhSachGiaoDich.Add(giaoDich1);
            List<float> TyLeGiaoDich_Actual = new List<float>();
            List<float> TyLeGiaoDich_Expect = new List<float>();
            for (int index = 0; index < 2; ++index)
            {
                TyLeGiaoDich_Expect.Add(0f);
            }
            TyLeGiaoDich_Expect[1] = 100f;
            try
            {
                TyLeGiaoDich_Actual = NavasBayes.TinhTyLeTheoGioiTinh(DanhSachGiaoDich);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Assert.AreEqual(TyLeGiaoDich_Expect, TyLeGiaoDich_Actual);
        }

        [Test]
        public void ThuatToanNaiveBayesTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            List<EStoreBUS.MyStruct> listSanPham_Expect = new List<MyStruct>();
            EStoreBUS.MyStruct struct1 = new MyStruct();
            struct1.Gt = 5759248.8350906251;
            struct1.Id = 4;
            listSanPham_Expect.Add(struct1);
            struct1.Gt = 4828876.38854652;
            struct1.Id = 30;
            listSanPham_Expect.Add(struct1);
            struct1.Gt = 4124136.477564469;
            struct1.Id = 3;
            listSanPham_Expect.Add(struct1);
            List<EStoreBUS.MyStruct> listSanPham_Actual = new List<MyStruct>();
            listSanPham_Actual = NavasBayes.ThuatToanNaiveBayes(2, 0, 4, 1, 1, 5);
            Assert.AreEqual(listSanPham_Expect, listSanPham_Actual);
        }

        [Test]
        public void SapXepTest()
        {
        }


    }
}
