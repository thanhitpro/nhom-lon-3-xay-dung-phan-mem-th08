using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EStoreDTO;
using EStoreBUS;
using EStoreDAO;
namespace TUVANLAPTOP
{
    public partial class SANPHAMMOI : Form
    {
        public SANPHAMMOI()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SANPHAMMOI_Load(object sender, EventArgs e)
        {
            List<myChiTietDongLaptopDTO> listIDLaptopTuVan = new List<myChiTietDongLaptopDTO>();
            listIDLaptopTuVan = (List<myChiTietDongLaptopDTO>)this.Tag;
            if (listIDLaptopTuVan.Count == 0)
            {
                btn_SoSP.Text = "KHÔNG CÓ LAPTOP NÀO PHÙ HỢP VỚI BẠN ! THỬ LẠI...";
            }
            else
            {
                btn_SoSP.Text = string.Format("CÓ {0} LAPTOP PHÙ HỢP VỚI BẠN !", listIDLaptopTuVan.Count);
                foreach (myChiTietDongLaptopDTO laptop in listIDLaptopTuVan)
                    if (laptop != null)
                    {
                        UC_SanPham sanPhamControl = new UC_SanPham(laptop);
                        sanPhamControl.Link_TenLaptop.Click += new EventHandler(Link_TenLaptop_Click);
                        flp_DSLaptop.Controls.Add(sanPhamControl);
                    }
            }
        }

        void Link_TenLaptop_Click(object sender, EventArgs e)
        {
            myChiTietDongLaptopDTO dongLaptop = (myChiTietDongLaptopDTO)((LinkLabel)sender).Tag;
            if (dongLaptop != null)
            {
                int m_iMaLaptopDuocChon = dongLaptop.IMaDongLaptop;
                string m_sTenLaptop = dongLaptop.STenChiTietDongLapTop;

                btn_TenLaptop.Text = dongLaptop.STenChiTietDongLapTop;

                //CPU:
                tB_CPU.Text = dongLaptop.ChiTietDongCPU.STenDongCPU;

                //O Cung:
                tB_OCung.Text = dongLaptop.ChiTietDongOCung.STenDongOCung;

                //RAM:
                tB_RAM.Text = dongLaptop.ChiTietDongRam.STenDongRAM;

                //Card man hinh:
                tB_CardManHinh.Text = dongLaptop.ChiTietDongCacDoHoa.STenDongCardDoHoa + "  " + dongLaptop.ChiTietDongCacDoHoa.ChiTietBoNhoCardDoHoa.STenChiTietCardDoHoa;

                //Man hinh:
                tB_ManHinh.Text = dongLaptop.ChiTietDongManHinh.STenDongManHinh;

                //Trong luong:
                tB_TrongLuong.Text = dongLaptop.ChiTietTrongLuong.ChiTietLoaiTrongLuong.STenLoaiTrongLuong;

                //O quang:
                tB_OQuang.Text = dongLaptop.ChiTietDongODiaQuang.STenDongODiaQuang;

                //Webcam:
                tB_Webcam.Text = dongLaptop.ChiTietDongWebCam.STenDongWebCam + " (độ phân giải " + dongLaptop.ChiTietDongWebCam.FDoPhanGiai.ToString() + "MG pixel)";

                //Pin:
                tB_Pin.Text = dongLaptop.ChiTietDongPin.ChiTietThoiLuongPin.STenThoiLuongPin;

                //CardReader:
                tB_CardReader.Text = dongLaptop.ChiTietDongCardReader.ChiTietCongNgheCardReader.STenCongNgheCardReader;

                //Card mang:
                tB_CardMang.Text = dongLaptop.ChiTietDongCardMang.ChiTietLoaiKetNoiMang.STenLoaiKetNoiCardMang;

                //HDH:
                tB_HDH.Text = dongLaptop.ChiTietHeDieuHanh.STenHeDieuHanh;

                //Finger:
                if (dongLaptop.BFingerprintReader == 1)
                    tB_Finger.Text = "Có";
                else
                    tB_Finger.Text = "Không";

                //HDMI:
                if (dongLaptop.BHDMI == 1)
                    tB_HDMI.Text = "Có";
                else
                    tB_HDMI.Text = "Không";

                //Loa:
                if (dongLaptop.ChiTietDongLoa.BCoMicro == 1)
                    tB_Loa.Text = dongLaptop.ChiTietDongLoa.STenDongLoa + " (có Micro)";
                else
                    tB_Loa.Text = dongLaptop.ChiTietDongLoa.STenDongLoa + " (không có Micro)";

                //So cong USB:
                tB_SoCongUSB.Text = dongLaptop.ISoLuongCongUSB.ToString() + " cổng";

                //Mau sac:
                tB_MauSac.Text = dongLaptop.SMauSac;

                //Danh gia:
                tB_DanhGia.Text = dongLaptop.DanhGia.ITongDiem.ToString() + " điểm";

                //Mo ta them:s
                tB_MoTaThem.Text = dongLaptop.SMoTaThem;
            }
        }

    }
}
